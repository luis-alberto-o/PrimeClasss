using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrimeClasss.entities.employees;

namespace PrimeClasss.entities.employees
{
    public class Administrative : Employee
    {
        public string Department { get; set; }

        public void Manage()
        {
            Console.WriteLine($"{Name} works in {Department} department");
        }
    }
}

