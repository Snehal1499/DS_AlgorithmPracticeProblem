using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Problems
{
    internal class RangePrimeArray
    {
        public bool isPrime(int n)

        {

            int c = 0;

            for (int i = 1; i <= n; i++)

            {

                if (n % i == 0)

                    c++;

            }

            if (c == 2)

                return true;

            else

                return false;

        }

    }
}
    
