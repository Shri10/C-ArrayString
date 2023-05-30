using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArrayString
{
    internal class PrintUnique
    {
        public static void PrintUniqOnly(int[] array) 
        {
            Console.WriteLine("Unique Numbers");
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    { 
                        isUnique = false; 
                        break; 
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
