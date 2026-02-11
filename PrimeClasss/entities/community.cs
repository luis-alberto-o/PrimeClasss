using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeClasss.entities
{
    public class Community
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}");
        }
    }
}

