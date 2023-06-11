using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortierung_von_Arrays
{
    internal static class RandomSort
    {
        public static int[] sort(int[] data)
        {
            int count = 0;
            while (!isSorted(data))
            {                               
                Random random = new Random();
                int r1 = random.Next(data.Length);
                int r2 = random.Next(data.Length);
                (data[r1], data[r2]) = (data[r2], data[r1]);
                count++;
            }
            Console.WriteLine($"Needed Swaps: {count}");
            return data;
        }
        static private bool isSorted(int[] data)
        {
            bool sorted = true;
            for(int i = 1; i < data.Length; i++)
            {
                if (!sorted)
                    break;
                if (data[i - 1] > data[i])
                    sorted = false;
            }
            return sorted;
        }
    }
}
