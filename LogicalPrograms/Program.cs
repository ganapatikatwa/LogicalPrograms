﻿using LogicalPrograms;
using System;
namespace AddressBookProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            while (true)
            {

                Console.WriteLine("Enter The Choice \n1)Fibonacci Serries\n2)Perfect Number\n3)Prime Number" +
                    "\n4)Revers Number\n5)Stop Watch");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries=new FibonacciSeries();
                        fibonacciSeries.FSeries();
                        break;
                    case 2:
                        PerfectNumber perfectNumber=new PerfectNumber();
                        perfectNumber.PNumber();
                        break;
                    case 3:
                        PrimeNumber primeNumber=new PrimeNumber();
                        primeNumber.pnumber();
                        break;
                    case 4:
                        ReverseNumber reverseNumber=new ReverseNumber();
                        reverseNumber.RevNumber();
                        break;
                    case 5:
                        StopWatch stopWatch=new StopWatch();
                        stopWatch.Watch();
                        break;
                    default:
                        Console.WriteLine("Enter the Correct Choice");
                        break;

                }
            }
        }
    }
}

