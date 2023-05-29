using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public void Watch()
        {
            Stopwatch stopwatch= new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(5000);
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time is {0} ms",stopwatch.ElapsedMilliseconds);
        }
    }
}
