#! /bin/bash

sudo apt update
sudo apt install mono-complete

mcs -out:NameSort1.exe Program.cs

chmod u+x NameSort1.exe

mono NameSort1.exe -s < "Sort Me.txt" > SortOutput.txt
cmp -b  -i 1 Sorted.txt SortOutput.txt

mono NameSort1.exe -r < "Sort Me.txt" > ReverseOutput.txt
cmp -b -i 15 ReverseSorted.txt ReverseOutput.txt
