﻿using Inheritance2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class Employee : Person, IQuittable 
    {

        public new void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);

        }
        public void Quit()
        {
            Console.WriteLine("Samir Mayfeld...");

        } 
    }
}