using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public  void PNumber()
        {
            int i;
            int a = 1;
            int count = 0;
            Console.WriteLine("Enter the Minimum Number");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Maximum Number");
            int max= Convert.ToInt32(Console.ReadLine());

            for(i=min; i<=max; i++)
            {
                a = 1;
                count = 0;
                while(a<i)
                {
                    if(i%a==0)
                    {
                        count = count + a;
                    }
                    a++;
                }
                if(count==i)
                {
                    Console.WriteLine("{0}"+i);
                }
            }
        }
    }
}
