#!/usr/bin/env python3

import os
import argparse


def print_file(abspath,ontop=False,depth=0):
    (dirname,filename) = os.path.split(abspath)
    beginnote = ' '*4*depth + '\ {{{ ' + ('='*5*(depth+1)) + ' included %s%s =====\n'
    endnote = ' '*4*depth + '\ }}} ' + ('='*5*(depth+1)) + ' end of included %s =====\n'
    with open(abspath) as f:
        for line in f:
            if line.startswith('include '):
                newfile = line.split()[1]
                print(beginnote % ('', os.path.basename(newfile)))
                print_file(os.path.abspath(os.path.join(dirname,newfile)),ontop=ontop,depth=depth+1)
                print(endnote % os.path.basename(newfile))
            elif ontop and line.startswith('\\ on_top_of'):
                newfile = line.split()[2]
                print(beginnote % ('(on_top_of) ', os.path.basename(newfile)))
                print_file(os.path.abspath(os.path.join(dirname,newfile)),ontop=ontop,depth=depth+1)
                print(endnote % os.path.basename(newfile))
            else:
                print(' '*4*depth + line.rstrip())


argparser = argparse.ArgumentParser(description='Recursively replace ''include'' in forth sources by contents. No files changed, output will be send to stdout.')
argparser.add_argument('file', help='File to start with')
argparser.add_argument('-o', '--on_top_of', action='store_true', help='Resolve also "\ on_top_of"')
#argparser.add_argument('definitions', nargs='*', help='Where to read the constants from')
args = argparser.parse_args()

print_file(args.file,ontop=args.on_top_of,depth=0)

print('\n\ vim: filetype=forth:foldmethod=marker:')
