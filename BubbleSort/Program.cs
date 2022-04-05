using System;

namespace DataStructure
{
    internal class BubbleSorting
    {
        public void BubbleSort()
        {
            int[] intArray = new int[5];
            Console.WriteLine("Enter 5 Numbers ");
            intArray[0] = Convert.ToInt32(Console.ReadLine());
            intArray[1] = Convert.ToInt32(Console.ReadLine());
            intArray[2] = Convert.ToInt32(Console.ReadLine());
            intArray[3] = Convert.ToInt32(Console.ReadLine());
            intArray[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Sorting ");
            for (int a = 0; a < intArray.Length; a++)
            {
                Console.WriteLine(intArray[a]);
            }
            Console.WriteLine("After Sorintg");
            int temp;
            for (int j = 0; j <= intArray.Length - 2; j++)
            {
                for (int i = 0; i <= intArray.Length - 2; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int p in intArray)
                Console.Write(p + "\n");
        }
    }
}