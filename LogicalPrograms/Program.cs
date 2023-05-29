using LogicalPrograms;
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

                Console.WriteLine("Enter The Choice \n1)Fibonacci Serries\n2)Perfect Number");
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
                    default:
                        Console.WriteLine("Enter the Correct Choice");
                        break;

                }
            }
        }
    }
}

