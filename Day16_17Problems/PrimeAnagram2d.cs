using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Problems
{
	internal class PrimeAnagram2d
	{
		public static bool isAnagram(string str1, string str2)
		{
			char[] arr1 = str1.ToCharArray();
			char[] arr2 = str2.ToCharArray();
			if (str1.Length != str2.Length)
			{
				return false;
			}
			else
			{
				Array.Sort(arr1);
				Array.Sort(arr2);
				if (Array.Equals(arr1, arr2))
				{
					return true;
				}
			}
			return false;
		}
	}
}
