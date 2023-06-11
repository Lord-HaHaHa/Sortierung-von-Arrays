using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sortierung_von_Arrays
{
    static class HeapSort
    {
        public static int counter = 0;

        static private int getChildBitMap(int[] data, int j, int idx_last = -1)
        {
            if(idx_last == -1)
                idx_last = data.Length;
            int child = 0;
            // Check for valid right child
            if ((2 * j + 1) <= idx_last)
            {
                child += 1;
            }
            // Check for valid left child
            if ((2 * j) <= idx_last)
            {
                child += 2;
            }
            return child;
        }
        
        static public int[] BuildMinHeap(int[] data)
        {
            for (int j = data.Length-1; j >= 0; j--)
            {
                DownHeap(data, j);
            }
            return data;
        }
        
        static public int[] DownHeap(int[] data, int idx, int idx_last =-1)
        {
            int idx_logic = idx+1;
            int child = getChildBitMap(data, idx_logic, idx_last);
            switch (child)
            {
                // Do nothing
                case(0):
                    break;
                // Only right Child 
                case (1):
                    if (data[idx] > data[2 * idx_logic])
                    {
                        counter++;
                        (data[2 * idx_logic], data[idx]) = (data[idx], data[idx_logic * 2]);
                    }
                    break;
                // Only left Child
                case (2):
                    if (data[idx] > data[2 * idx_logic-1])
                    {
                        counter++;
                        (data[2 * idx_logic-1], data[idx]) = (data[idx], data[idx_logic * 2-1]);
                    }
                    break;
                // Both Child´s
                case(3):
                    int idx_swap = 0;
                    if (data[idx_logic * 2] < data[idx_logic * 2 - 1])
                        idx_swap = idx_logic * 2;
                    else
                        idx_swap = idx_logic * 2 - 1;
                    if (data[idx] > data[idx_swap])
                    {
                        counter++;
                        (data[idx_swap], data[idx]) = (data[idx], data[idx_swap]);
                    }
                    break;
                default:
                    throw new Exception();
            }
            return data;
        }
        
        static public int[] HeapSorting(int[] data)
        {
            Console.WriteLine("--- Generate Min Heap: ---");
            data = BuildMinHeap(data);
            PrintHeap(data);
            Console.WriteLine($"Needed Swaps to generate the Heap; {counter}");
            Console.WriteLine("--- Sorting with HeapSort ---");
            for(int i = 0; i<data.Length; i++)
            {
                (data[0], data[data.Length - 1 - i]) = (data[data.Length - 1 - i], data[0]);
                counter++;
                DownHeap(data, 0, data.Length-1-i);
            }
            return data;
        }

        static public void PrintHeap(int[] data, int idx = -1)
        {
            int i = 0;
            while(i < data.Length)
            {
                System.Console.Write($"{data[i]} ");
                if (Math.Log2(i+2) == Math.Ceiling(Math.Log2(i+2)))
                {
                    System.Console.WriteLine();
                }
                i++;
            }
            System.Console.WriteLine();
        }
    }
}
