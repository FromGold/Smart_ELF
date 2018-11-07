#!/bin/bash
source ../venv/bin/activate

if [[ $# -ne 2 ]];
then echo "Wrong usage"
     exit 1
fi
python ../bindings/python/delete.py "$1" "$2"
deactivate
