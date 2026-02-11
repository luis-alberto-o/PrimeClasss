using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeClasss.entities
{
    public class ExStudents : Community
    {
        public int GraduationYear { get; set; }

        public void Graduate()
        {
            Console.WriteLine($"{Name} graduated in {GraduationYear}");
        }
    }
}
