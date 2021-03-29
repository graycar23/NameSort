#! /bin/bash

sudo apt update
sudo apt install mono-complete

mcs -out:NameSort1.exe Program.cs

chmod u+x NameSort1.exe

mono NameSort1.exe -s < "Sort Me.txt" > SortOutput.txt
diff -u <( tr -d '\r' <Sorted.txt ) SortOutput.txt | cat -t

mono NameSort1.exe -r < "Sort Me.txt" > ReverseOutput.txt
diff -u <( tr -d '\r' <ReverseSorted.txt ) ReverseOutput.txt | cat -t
