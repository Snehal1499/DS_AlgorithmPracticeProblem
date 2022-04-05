using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Problems
{
    internal class GenericSearchAndSort
    {
        public void BinarySearchGeneric<T>()
        {

            string[] lines = { "Binary", "Search", "Word", "From", "List" };
            File.WriteAllLines(@"D:\.net\Day16&17Problems\infogeneric.txt", lines);
            string text = File.ReadAllText(@"D:\.net\Day16&17Problems\infogeneric.txt");
            Console.WriteLine("Before Soritng:\n" + text);
            Console.WriteLine("After Sorting the Words , They are :\n");
            Array.Sort(lines, StringComparer.InvariantCulture);
            Array.ForEach(lines, x => Console.WriteLine(x));
            File.ReadAllLines(@"D:\.net\Day16&17Problems\infogeneric.txt");
            Console.WriteLine("Enter Word to Search");
            bool value = lines.Contains(Console.ReadLine());
            Console.WriteLine("If the Word is Found then Print True else False : \n" + value);
        }
    }
}
    
