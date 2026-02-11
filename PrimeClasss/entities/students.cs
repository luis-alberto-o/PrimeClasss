using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeClasss.entities
{
    public class Students : Community
    {
        public string Career { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying {Career}");
        }
    }
}

