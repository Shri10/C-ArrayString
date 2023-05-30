using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArrayString
{
    internal class SumOfDigits
    {
        public static void SOD(int num)
        {
            int ognu = num;
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            //return sum;
            Console.WriteLine($"The sum of digits in {ognu} is {sum}.");
        }
    }
}