using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortierung_von_Arrays
{
    public static class Quicksort
    {
        public static int[] sort(int[] data, int i=0, int j=0)
        {
            System.Console.Write($"{i} {j}\n");

            if (i < j)
            {
                int l = i;
                int r = j - 1;
                while (true)
                {
                    while (data[l] < data[j] && l < j)
                        l++;
                    while (data[r] > data[j] && r > 0)
                        r--;

                    // Tausche linkes und Rechtes Element
                    if (l < r)
                    {
                        (data[r], data[l]) = (data[l], data[r]);
                        l++;
                        r--;
                    }
                    else break;
                }
                (data[j], data[l]) = (data[l], data[j]);
                Quicksort.sort(data, i, l - 1);
                Quicksort.sort(data, l+1, j);
            }
            return data;
        }
    }

}
