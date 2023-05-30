using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArrayString
{
    internal class SumOfMatrix
    {
        public static void SOM(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j];
                }
                Console.WriteLine($"The sum of row {i + 1} is {rowSum}");
            }
        }
    }
}
