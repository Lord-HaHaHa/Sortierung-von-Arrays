using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortierung_von_Arrays
{
    internal class InsertionSort
    {
        public static int counter = 0;

        public static int[] sort(int[] data)
        {
            for(int i = 0; i< data.Length; i++)
            {
                int minidx = getMinIndex(data, i);
                (data[minidx], data[i]) = (data[i], data[minidx]);
                counter++;
            }
            return data;
        }

        static int getMinIndex(int[] data, int startidx=0)
        {
            int min = startidx;
            for(int i = startidx+1; i< data.Length; i++)
            {
                if (data[min] > data[i])
                    min = i;
            }
            return min;
        }
    }
}
