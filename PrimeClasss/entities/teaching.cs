using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrimeClasss.entities.employees;

namespace PrimeClasss.entities.employees
{
    public class Teaching : Employee
    {
        public string Subject { get; set; }

        public void Teach()
        {
            Console.WriteLine($"{Name} teaches {Subject}");
        }
    }
}
