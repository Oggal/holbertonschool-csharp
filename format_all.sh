#!/usr/bin/env bash

num="${#}"
cur=0
for f in "$@"
do
    echo "$cur/$num"
    echo -ne '\007'
    dotnet format "$f" -v n
    ((cur++))
done