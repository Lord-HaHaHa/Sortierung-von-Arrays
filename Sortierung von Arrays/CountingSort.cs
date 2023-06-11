using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortierung_von_Arrays
{
    internal class CountingSort
    {
        public static int counter = 0;

        public static int[] Sort(int[] data)
        {
            // Generate Counter Array
            int[] count = new int[0];
            Console.WriteLine(count.Length);
            foreach (var item in data)
            {
                // Extend CounterArry if needed
                if(count.Length < item)
                {
                    int[] newcount = new int[item + 1];
                    for(int i = 0; i < count.Length; i++)
                        newcount[i] = count[i];
                    if(count.Length > 0)
                        for (int i = count.Length; i < newcount.Length; i++)
                            newcount[i] = newcount[i - 1];
                    count = newcount;
                }
                for(int i = item; i < count.Length; i++)
                    count[i]++;
            }
            
            foreach (int item in count)
                System.Console.Write($"{item},");
            System.Console.WriteLine();

            int[] ret_data = new int[data.Length];
            foreach(int item in data)
            {
                int idx = count[item];
                count[item]--;
                ret_data[idx-1] = item;
                counter++;
            }

            return ret_data;
        }
    }
}
