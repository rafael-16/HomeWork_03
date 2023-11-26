using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork_03_01
{
    public class Filter
    {
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
        public int[] ArrayFiltering(int[] array_origin, int[] array_filter)
        {
            List<int> new_array = new List<int>();
            foreach (int item in array_origin)
            {
                if (!array_filter.Contains(item))
                {
                    new_array.Add(item);
                }
            }
            return new_array.ToArray();
        }
    }
}
