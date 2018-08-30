using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
{
    class Math
    {
        public int numOne { get; set; }
        public int numTwo { get; set; }

        public void Addition()
        {
            int result = numOne + numTwo;
            Console.WriteLine(result);
        }
        
    }
}