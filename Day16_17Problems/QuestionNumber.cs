using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Problems
{
    internal class QuestionNumber
    {
        static int range, count, lower, upper, middle;
        static string input;

        public static void binarySearch(int lower, int upper, int middle, int count, string input, int n)
        {

            Console.WriteLine("Is your number:" + middle);
            Console.WriteLine();
            Console.WriteLine("Enter your answer in 'yes' or 'high' or 'low'");
            input = Convert.ToString(Console.ReadLine());
            do
            {
                if (input.Equals("high"))
                {
                    lower = middle;
                    count++;
                }
                else if (input.Equals("yes"))
                {
                    Console.WriteLine("The number you thought was: " + middle);
                    int no = count + 1;
                    Console.WriteLine("It takes " + no + " times to find your exact number");
                    break;
                }
                else if (input.Equals("low"))
                {
                    upper = middle;
                    count++;
                }
                if (count < n)
                {
                    middle = (lower + upper + 1) / 2;
                    Console.WriteLine("Is your number " + middle + ":");
                    input = Convert.ToString(Console.ReadLine());
                }
            }
            while (lower <= upper);
            if (count > n)
            {
                Console.WriteLine("Number not found");
            }
            else

                Environment.Exit(0);

        }


    }
}

    
