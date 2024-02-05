using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class BikeStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una bici y acelero");
        }
    }
}
