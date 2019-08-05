#!/usr/bin/env python3

import re
import argparse
import sys

argparser = argparse.ArgumentParser(description='Replace constants in forth sources by values. No files changed, output will be send to stdout.')
argparser.add_argument('-i', '--inline', action="store_true", help="Use inline comments instead of end-of-line")
argparser.add_argument('template', help='Base template on which replacements should be made')
argparser.add_argument('definitions', nargs='*', help='Where to read the constants from')
args = argparser.parse_args()

get_const = re.compile("^(?:\s*|\\\\ @ +)(?P<value>[%$#]?\w+)\s+(?:constant|CONSTANT)\s+(?P<name>[^\s]+)(?:\Z|\s.*)")
# supports also inside comments with special syntax, '\ @ VALUE constant NAME'
replace_dict = {} # 'CONSTANT_NAME': 'CONSTANT_VALUE'
replace_re = {}   # 'CONSTANT_NAME': regexp that matches CONSTANT_NAME
# comments1 = re.compile(r"(^[^\\]*)(\\.*|$)") # only end-of-line ones; use with match()
comments2 = re.compile(r'(\( [^)]* \))|(\\.*)') # both types; use with split()

print("\ generated from template: %s" % (" ".join(sys.argv[:])))

# build replacement dictionary along with regexps that check for occurences
for filename in args.definitions + [args.template]:
    with open(filename) as f:
        for line in f:
            m = get_const.match(line)
            if m is not None:
                replace_dict[m.group('name')] = m.group('value')
                replace_re[m.group('name')] = re.compile(m.group('name'))

with open(args.template) as f:
    for line in f:
        # s = list(comments1.match(line.rstrip()).groups())
        for nam in sorted(replace_re.keys(),reverse=True): # revsort to avoid sub-name clashes
            s = list(filter(None, comments2.split(line.rstrip())))  # split into comments and non-coms
            t = ""  # build processed part
            k = 0  # if recording with \ comments, need to remember
            for tok in s:
                if tok.startswith('(') or tok.startswith('\\'):
                    t += tok
                    continue
                if args.inline:
                    t += replace_re[nam].sub(replace_dict[nam]+' ( '+nam+' )', tok)
                else:
                    upd, k = replace_re[nam].subn(replace_dict[nam], tok)
                    t += upd
            line = t # repeat with updated line
            if k > 0:
                line += (" \\ ("+replace_dict[nam]+":"+nam+")")
        print(line)
