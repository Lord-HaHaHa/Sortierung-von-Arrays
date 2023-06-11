using Sortierung_von_Arrays;
using System.Diagnostics.Metrics;

int[] data_raw = { 5, 7, 31, 23, 47, 12, 1, 98, 563, 43 };

System.Console.WriteLine("RawData:");
foreach (int item in data_raw)
    System.Console.Write($"{item},");
System.Console.WriteLine();
System.Console.WriteLine();

/*
int[] data_quickSort = Quicksort.sort(data_raw,0, data_raw.Length-1);
System.Console.WriteLine("QuickSort:");
Console.WriteLine($"Needed Swaps: {Quicksort.counter}");
foreach (int item in data_quickSort)
    System.Console.Write($"{item},");
*/
System.Console.WriteLine();
System.Console.WriteLine("RawHeap:");
int[] data_heap = HeapSort.HeapSorting(data_raw);
Console.WriteLine($"Needed Swap: {HeapSort.counter}");
foreach (int item in data_heap)
    System.Console.Write($"{item},");
System.Console.WriteLine();


/*
System.Console.WriteLine();
System.Console.WriteLine("CountSort");
int[] data_CountingSort = CountingSort.Sort(data_raw);
foreach (int item in data_CountingSort)
    System.Console.Write($"{item},");
System.Console.WriteLine();
*/

/*
System.Console.WriteLine();
System.Console.WriteLine("InsertionSort");
int[] data_inserionSort = InsertionSort.sort(data_raw);
Console.WriteLine($"Needed Swap: {InsertionSort.counter}");
foreach (int item in data_inserionSort)
    System.Console.Write($"{item},");
System.Console.WriteLine();
*/
System.Console.WriteLine();
System.Console.WriteLine("RandomSort");
int[] data_randomSort = RandomSort.sort(data_raw);
Console.WriteLine($"Needed Swap: {RandomSort.counter}");
foreach (int item in data_randomSort)
    System.Console.Write($"{item},");
System.Console.WriteLine();
