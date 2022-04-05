using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Day16_17Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algorithm Programs \n1)  String Equal are not Program");
            StringEqual se = new StringEqual();
            string str = "SNEHAL";
            string str2 = "SNEHAL";
            string str3 = "snehal";
            int n = str.Length;
            int m = str2.Length;
            int o = str3.Length;
            StringEqual.permute(str, 0, n - 1);
            Console.WriteLine("\n" + StringEqual.s + "\n");
            StringEqual.s2 = StringEqual.s;
            StringEqual.permute(str2, 0, m - 1);
            Console.WriteLine("\n" + StringEqual.s);
            StringEqual.s3 = StringEqual.s;
            StringEqual.permute(str3, 0, o - 1);
            Console.WriteLine("\n" + StringEqual.s + "\n");
            StringEqual.s4 = StringEqual.s;
            Console.WriteLine("Checking Lengths : True is if both strings are equal : Str and Str2 ");
            Console.WriteLine(StringEqual.s2.Equals(StringEqual.s3));
            Console.WriteLine("Checking Lengths : True is if both strings are equal : Str2 and Str3 ");
            Console.WriteLine(StringEqual.s3.Equals(StringEqual.s4));
            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine("\nAlgorithm Programs \n2) Binary Search Word Program\n");
            BinarySearchWord bs = new BinarySearchWord();
            bs.BinarySearch();

            Console.WriteLine("\nAlgorithm Programs \n3) Sorted List Program\n");
            SortedList sp = new SortedList();
            sp.Sort();

            Console.WriteLine("\nAlgorithm Programs \n4) Bubble Sort Program\n");
            BubbleSorting bbs = new BubbleSorting();
            bbs.BubbleSort();

            Console.WriteLine("\nAlgorithm Programs \n5) Merge Sort \n");
            MergeSortArray ms = new MergeSortArray();
            ms.MergeSorting();

            Console.WriteLine("\nAlgorithm Programs \n 6) Angrams or Not\n");
            string firstString, secondString;

            Console.WriteLine("\nEnter first string\n");
            firstString = Console.ReadLine();
            Console.WriteLine("\nEnter second string\n");
            secondString = Console.ReadLine();
            Anagrams a = new Anagrams();

            if (a.areAnagram(firstString, secondString) == true)
            {
                Console.WriteLine("\nBoth string are anagram string\n");
            }
            else
            {
                Console.WriteLine("\nBoth string are not anagram string\n");
            }

            Console.WriteLine("\nAlgorithm Program \n7) Prime Number From 1 to 1000 Are :\n");
            PrimeRange1_1000 p = new PrimeRange1_1000();
            p.PrimeRange();

            Console.WriteLine("\nAlgorithm Program \n8) Prime Palindromes From 1 to 1000 Are :\n");
            PrimePalindromes pp = new PrimePalindromes();
            pp.PrimePalindromes(1, 1000);

            Console.WriteLine("\nAlgorithm Program \n9) Generic Search and Sort\n");
            GenericSearchAndSort g = new GenericSearchAndSort();
            g.BinarySearchGeneric<string>();


            Console.WriteLine("\nAlgorithm Programs \n10) Question Number\n");

            QuestionNumber q = new QuestionNumber();
            Console.WriteLine("Enter any Number :");
            int number = Convert.ToInt32(Console.ReadLine());
            int range = (int)(Math.Pow(2, n));
            Console.WriteLine("Take number between '0' to " + range);
            int count = 0;
            string input = null;
            int lower = 0;
            int upper = range;
            int middle = (lower + upper / 2);
            QuestionNumber.binarySearch(lower, upper, middle, count, input, number);


            Console.WriteLine("Note : After Runing for 10 algorithm Question please Comment the 10 problem Code So that Next Lines of Code Will Execute");


            Console.WriteLine("\nAlgorithms Program \n 12) Regex");
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Full Name");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter Contact Number");
            string contactNumber = Console.ReadLine();
            Console.WriteLine("Enter Date");
            string date = Console.ReadLine();
            RegexStringFunctions regex = new RegexStringFunctions();
            regex.patternString(firstName, fullName, contactNumber, date);

            Console.WriteLine("Data Structures \n1) Unordered List");
            List<string> my_list = new List<string>();
            my_list.Add("Program");
            my_list.Add("Adding");
            my_list.Add("Words");
            my_list.Add("To");
            my_list.Add("List");
            my_list.Add("In");
            my_list.Add("File");
            Console.WriteLine("\nWriting Data into List");
            File.WriteAllLines(@"D:\.net\Day16&17Problems\list.txt", my_list);
            foreach (string words in my_list)
            {
                Console.WriteLine(words);
            }
            Console.WriteLine("Reading data");
            File.ReadAllLines(@"D:\.net\Day16&17Problems\list.txt");
            Console.WriteLine("\nEnter Word to Search\n");
            string word = Console.ReadLine();
            Console.WriteLine("\n");
            bool value = my_list.Contains(word);
            if (value == true)
            {
                my_list.Remove(word);
                foreach (string ab in my_list)
                {
                    Console.WriteLine(ab);
                }
            }
            else
            {
                my_list.Add(word);
                foreach (string ab in my_list)
                {
                    Console.WriteLine(ab);
                }
            }

            Console.WriteLine("Data Structure \n2) OrderedList");
            int[] intArray = new int[5];
            Console.WriteLine("Enter 5 Numbers ");
            intArray[0] = Convert.ToInt32(Console.ReadLine());
            intArray[1] = Convert.ToInt32(Console.ReadLine());
            intArray[2] = Convert.ToInt32(Console.ReadLine());
            intArray[3] = Convert.ToInt32(Console.ReadLine());
            intArray[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers in Asending Order");
            int temp;
            for (int j1 = 0; j1 <= intArray.Length - 2; j1++)
            {
                for (int i1 = 0; i1 <= intArray.Length - 2; i1++)
                {
                    if (intArray[i1] > intArray[i1 + 1])
                    {
                        temp = intArray[i1 + 1];
                        intArray[i1 + 1] = intArray[i1];
                        intArray[i1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p1 in intArray)
                Console.Write(p1 + "\n");


            Console.WriteLine("Data Structures \n3) Balanced Paranthasis");
            Console.WriteLine("Enter max Size");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack(n1);
            Console.WriteLine("Enter expression: ");
            string exp = Console.ReadLine();
            int len = exp.Length;
            Console.WriteLine("Matches and Mismatches: ");
            for (int i2 = 0; i2 < len; i2++)
            {
                char ch = exp[i2];

                if (ch == '(')
                {
                    stack.push(i2);
                }
                else if (ch == ')')
                {
                    try
                    {
                        long p1 = (stack.pop() + 1);
                        Console.WriteLine("')' at index " + (i2 + 1) + " matched with '(' at index " + p1);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("')' at index " + (i2 + 1) + " is unmatched");
                    }
                }
            }
            while (!stack.isEmpty())
            {
                Console.WriteLine("'(' at index " + (stack.pop() + 1) + " is unmatched");
            }

            Console.WriteLine("Data Structure \n4) Bank Cash Counter");
            char agn;
            do
            {
                fuctions k1 = new fuctions();
                int num;
                Console.WriteLine("Please Select Any Function.");
                Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        k1.fun1();
                        break;
                    case 2:
                        k1.fun2();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                agn = Convert.ToChar(Console.ReadLine());

            } while (agn == 'y');

            Console.ReadKey();

            Console.WriteLine("Data Structure \n5) Palindrome Checker");
            string s, revs = "";
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            for (int i3 = s.Length - 1; i3 >= 0; i3--)
            {
                revs += s[i3].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }

            Console.WriteLine("Data Structure \n8) Prime Range Array");
            RangePrimeArray r = new RangePrimeArray();

            Console.WriteLine("Enter the number of rows : ");

            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns : ");

            int n2 = Convert.ToInt32(Console.ReadLine());



            int[,] A = new int[m1, n2];

            int[] B = new int[m1 * n2];

            int i = 0, j;

            int k = 1;

            while (i < m1 * n2)

            {

                if (r.isPrime(k) == true)

                {

                    B[i] = k;

                    i++;

                }

                k++;

            }

            int x = 0;

            for (i = 0; i < m1; i++)

            {

                for (j = 0; j < n2; j++)

                {

                    A[i, j] = B[x];

                    x++;

                }

            }

            Console.WriteLine("The Final Array is : ");

            for (i = 0; i < m1; i++)

            {

                for (j = 0; j < n2; j++)

                {

                    Console.WriteLine(A[i, j] + "\t");

                }

            }
            


        }
    }
}