using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17Problems
{
    internal class Bank
    {
        private double balance = 100000;


        public double bal
        {
            get { return balance; }
            set { balance = value; }
        }
    }
    class fuctions
    {
        Bank i = new Bank();
        string name;
        int account;
        double withdraw, dep, tobal;

        public void fun1()
        {
            Console.WriteLine("Enter Name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount :");
            dep = Convert.ToDouble(Console.ReadLine());
            tobal = i.bal + dep;

            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Name of the depositor : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + tobal);

        }
        public void fun2()
        {
            Console.WriteLine("Enter Account Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= i.bal)
            {
                tobal = i.bal - withdraw;
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Account Name : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("After Withdraw Amount balnace is : " + tobal);
            }
            else
                Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
        }

    }
}
    }
}
