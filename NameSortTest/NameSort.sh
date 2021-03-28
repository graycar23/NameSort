#! /bin/bash

chmod u+x NameSort.exe

./NameSort.exe -s < "Sort Me.txt" > SortOutput.txt
cmp Sorted.txt SortOutput.txt

./NameSort.exe -r < "Sort Me.txt" > ReverseOutput.txt
cmp ReverseSorted.txt ReverseOutput.txt

sleep 1
