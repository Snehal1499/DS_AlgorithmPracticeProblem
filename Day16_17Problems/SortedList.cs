using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Problems
{
    internal class SortedList
    {
        public void Sort()
        {
            string[] words = new string[5];
            Console.WriteLine("Enter Words in Array");
            words[0] = Console.ReadLine();
            words[1] = Console.ReadLine();
            words[2] = Console.ReadLine();
            words[3] = Console.ReadLine();
            words[4] = Console.ReadLine();
            Console.WriteLine("Before Sorting\n");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i] + " ");
            }
            Console.WriteLine("After Sorting\n");
            Array.Sort(words, StringComparer.InvariantCulture);
            Array.ForEach(words, x => Console.WriteLine(x));


        }
    }
}
    
