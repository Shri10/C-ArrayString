using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArrayString
{
    internal class MaxMin
    {
        public static void MM(int[] array)
        {
            int max = array[0];
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("Maximum Element: " + max);
            Console.WriteLine("Minimum Element: " + min);
        }
    }
}
