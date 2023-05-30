using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArrayString
{
    internal class CountFreq
    {
        public static void Freq(int[] array)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            foreach (KeyValuePair<int, int> item in frequency)
            {
                Console.WriteLine($"Element {item.Key} occurs {item.Value} times");
            }
        }
    }
}
