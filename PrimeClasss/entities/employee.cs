using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrimeClasss.entities;

namespace PrimeClasss.entities.employees
{
    public class Employee : Community
    {
        public double Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($"{Name} is working");
        }
    }
}

