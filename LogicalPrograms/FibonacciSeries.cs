using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void FSeries()
        {
            int n1 = 0;
            int n2 = 1;
            int i;
            int n3=0;
            int count;
            Console.WriteLine("Enter The Number of Count Required for Fibonacci Series");
            count= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1+" "+n2+" ");
            for (i=2;i<count;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3+" ");
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine("Fibonacci Final Count is--"+n3);
        }
    }
}
