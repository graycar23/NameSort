#! /bin/bash

mcs -out:NameSort1.exe Program.cs

chmod u+x NameSort1.exe

mono NameSort1.exe -s < "Sort Me.txt" > SortOutput.txt
cmp Sorted.txt SortOutput.txt

mono NameSort1.exe -r < "Sort Me.txt" > ReverseOutput.txt
cmp ReverseSorted.txt ReverseOutput.txt
