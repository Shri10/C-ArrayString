using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArrayString
{
    internal class ReverseWords
    {
        public static string RevWords(string str) 
        {
            //Splitting String into words
            string[] words = str.Split(' ');


            //REverse Each words
            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i] = new string(chars);
            }

            //Make strings from words
            return string.Join(' ', words);
        }
    }
}
