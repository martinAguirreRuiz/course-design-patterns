﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class MotoStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una moto y acelero");
        }
    }
}
