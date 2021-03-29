NameSort.exe -s < "Sort Me.txt" > SortOutput.txt
fc Sorted.txt SortOutput.txt

NameSort.exe -r < "Sort Me.txt" > ReverseOutput.txt
fc ReverseSorted.txt ReverseOutput.txt

pause