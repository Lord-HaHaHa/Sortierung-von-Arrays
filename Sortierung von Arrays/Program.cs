using Sortierung_von_Arrays;

int[] data_raw = { 5, 7, 31, 23, 47, 12, 1, 98, 563, 43 };

System.Console.WriteLine("RawData:");
foreach (int item in data_raw)
    System.Console.Write($"{item},");
System.Console.WriteLine();

/*
int[] data = Quicksort.sort(data_raw,0, data_raw.Length-1);
System.Console.WriteLine("QuickSort:");
foreach (int item in data)
    System.Console.Write($"{item},");
System.Console.WriteLine();
*/

/*
System.Console.WriteLine("RawHeap:");
int[] data_heap = HeapSort.HeapSorting(data_raw);
foreach (int item in data_heap)
    System.Console.Write($"{item},");
System.Console.WriteLine();
*/

System.Console.WriteLine("CountSort");
int[]data_CountingSort = CountingSort.Sort(data_raw);
foreach (int item in data_CountingSort)
    System.Console.Write($"{item},");
System.Console.WriteLine();