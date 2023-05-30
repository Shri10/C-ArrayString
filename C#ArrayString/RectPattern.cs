using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArrayString
{
    internal class RectPattern
    {
        public static void rectPatt()
        {
            int size = 7;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
