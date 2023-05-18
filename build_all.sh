#!/usr/bin/env bash

cur=0
num="${#}"
for f in "$@"
do
    ((cur++))
    echo "Building $f   $cur/$num"
    dotnet build "$f" &>/dev/null
done