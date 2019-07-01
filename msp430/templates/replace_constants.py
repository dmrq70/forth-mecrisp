#!/usr/bin/env python3

import re
import argparse

argparser = argparse.ArgumentParser(description='Replace constants in forth sources by values. No files changed, output will be send to stdout.')
argparser.add_argument('template', help='Base template on which replacements should be made')
argparser.add_argument('definitions', nargs='*', help='Where to read the constants from')
args = argparser.parse_args()

get_const = re.compile("^(?:\s*|\\\\ @ +)(?P<value>[%$#]?\w+)\s+(?:constant|CONSTANT)\s+(?P<name>[^\s]+)(?:\Z|\s.*)")
# supports also inside comments with special syntax, '\ @ VALUE constant NAME'
replace_dict = {}
replace_re = {}
comments = re.compile(r"(^[^\\]*)(\\.*|$)")

for filename in args.definitions + [args.template]:
    with open(filename) as f:
        for line in f:
            m = get_const.match(line)
            if m is not None:
                replace_dict[m.group('name')] = m.group('value')
                replace_re[m.group('name')] = re.compile(m.group('name'))

with open(args.template) as f:
    for line in f:
        s = list(comments.match(line.rstrip()).groups())
        for nam in replace_re:
            upd, k = replace_re[nam].subn(replace_dict[nam], s[0])
            if k > 0:
                s[0] = upd
                s.append(" \\ ("+replace_dict[nam]+":"+nam+")")
        print("".join(s))
