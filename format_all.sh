#!/usr/bin/env bash

for f in "$@"
do
    echo -ne '\007'
    dotnet format "$f" -v n
done