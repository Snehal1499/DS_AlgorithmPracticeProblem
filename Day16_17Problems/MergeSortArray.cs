using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Problems
{
    internal class MergeSortArray
    {
        public void MergeSorting()
        {
            string[] list = { "C#", "Assignments", "Are", "Complicated", "This", "Time" };
            string[] firstHalf, secondHalf;
            Console.WriteLine("Spliting Array into Two halfs\n");
            firstHalf = list.Take(list.Length / 2).ToArray();
            secondHalf = list.Skip(list.Length / 2).ToArray();
            Console.WriteLine("Before Sorting First Half\n");
            for (int i = 0; i < list.Length / 2; i++)
            {
                Console.WriteLine(firstHalf[i] + " ");
            }
            Console.WriteLine("\n Before Sorting Second Half\n");
            for (int j = 0; j < list.Length / 2; j++)
            {

                Console.WriteLine(secondHalf[j] + " ");
            }
            Console.WriteLine("\nSorting First Half \n");
            Array.Sort(firstHalf);
            for (int k = 0; k < list.Length / 2; k++)
            {
                Console.WriteLine(firstHalf[k] + " ");

            }
            Console.WriteLine("\nSorting Second Half \n");
            Array.Sort(secondHalf);
            for (int l = 0; l < list.Length / 2; l++)
            {
                Console.WriteLine(secondHalf[l] + " ");
            }
            Console.WriteLine("\nMerging Both Arrays And Printing : \n");
            list = firstHalf.Concat(secondHalf).ToArray();
            for (int m = 0; m < list.Length; m++)
            {
                Console.WriteLine(list[m]);
            }




        }
    }
}

