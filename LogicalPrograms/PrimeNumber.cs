using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void pnumber()
        {
            bool prime = true;
            int i;
            Console.WriteLine("Enter the Number to Check Prime or Not");
            int num=Convert.ToInt32(Console.ReadLine());
            for(i=2;i<=num/2;i++)
            {
                if (num%i==0)
                {
                    prime = false;
                    Console.WriteLine("{0} is not a Prime Number--",num);
                    break;
                }
            }
            if(prime)
            {
                Console.WriteLine("{0} is not a Prime Number--",num);
            }
        }
    }
}
