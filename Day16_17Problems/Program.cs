using System;

namespace Day16_17Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Algorithm Programs");
            Console.WriteLine("Algorithm Programs \n1)  String Equal are not Program");
            StringEqual se = new StringEqual();
            string str = "SNEHAL";
            string str2 = "SNEHAL";
            string str3 = "SNEHAL";
            int s = str.Length;
            int h = str2.Length;
            int l = str3.Length;
            StringEqual.permute(str, 0, s - 1);
            Console.WriteLine("\n" + StringEqual.s + "\n");
            StringEqual.s2 = StringEqual.s;
            StringEqual.permute(str2, 0, h - 1);
            Console.WriteLine("\n" + StringEqual.s);
            StringEqual.s3 = StringEqual.s;
            StringEqual.permute(str3, 0, l - 1);
            Console.WriteLine("\n" + StringEqual.s + "\n");
            StringEqual.s4 = StringEqual.s;
            Console.WriteLine("Checking Lengths : True is if both strings are equal : Str and Str2 ");
            Console.WriteLine(StringEqual.s2.Equals(StringEqual.s3));
            Console.WriteLine("Checking Lengths : True is if both strings are equal : Str2 and Str3 ");
            Console.WriteLine(StringEqual.s3.Equals(StringEqual.s4));
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
