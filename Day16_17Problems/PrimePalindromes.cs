using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Problems
{
    internal class PrimePalindromes
    {
        internal class PrimePalindrome
        {
            int tmp, c, rev;
            public void primePalindrome(int m, int n)
            {
                for (int num = m; num <= n; num++)
                {
                    tmp = num;
                    c = 0;
                    rev = 0;
                    for (int i = 1; i <= tmp; i++)
                    {
                        if (tmp % i == 0)
                            c++;
                    }
                    if (c == 2)
                    {
                        while (tmp > 0)
                        {
                            rev = rev * 10 + (tmp % 10);
                            tmp /= 10;
                        }
                        if (rev == num)
                        {
                            Console.WriteLine(num);
                        }
                    }
                }

            }

        }



    }
}

