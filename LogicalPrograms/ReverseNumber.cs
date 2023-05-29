using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void RevNumber()
        {
            Console.WriteLine("Enter the Number to Reverse");
            int number= Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while(number > 0)
            {
                int reminder = number % 10;
                rev = (rev * 10) + reminder;
                number = number / 10;
            }
            Console.WriteLine("The Reverse Number of {0}--",rev);
        }
    }
}
