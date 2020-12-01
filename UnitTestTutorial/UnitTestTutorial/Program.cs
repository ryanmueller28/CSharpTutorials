﻿using System;


namespace UnitTestTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Ryan Mueller", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current Balance is ${0}", ba.Balance);
        }
    }
}
