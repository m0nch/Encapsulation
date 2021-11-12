using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            //Properties 
            Bank bank = new Bank();
            bank.Balance = 100;
            Console.WriteLine(bank.Balance);

            bank.Balance = -50;
            //Console.WriteLine(bank.Balance);

            Console.ReadKey();
        }
    }

    //Properties example
    public class Bank
    {
        private double _balance;
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                // validate the value
                if (value < 0)
                {
                    Console.WriteLine("value cannot be negative");
                }
                else
                {
                    _balance = value;
                }
            }
        }
    }
}
