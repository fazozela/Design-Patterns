using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Strategypattern
{
    public class BicicleStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una bici y me muevo sin motor");
        }
    }
}
