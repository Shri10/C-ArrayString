using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArrayString
{
    internal class DuplicateElements
    {
        public static void DuplicateCount(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            // Count total number of duplicate elements.
            foreach (int num in arr)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else 
                {
                    dict[num] = 1;
                }
            }

            int duplicateCount = 0;

            // Count how many numbers appeared more than once
            foreach (KeyValuePair<int, int> pair in dict)
            {
                if (pair.Value > 1)
                {
                    duplicateCount++;
                }
            }

            Console.WriteLine($"The array contains {duplicateCount} duplicate elements.");
        }


    }
}
