#!/usr/bin/env bash

for f in "$@"
do
    echo "Building $f"
    dotnet build "$f" &>/dev/null
done