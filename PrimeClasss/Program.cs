using System;
using PrimeClasss.entities;
using PrimeClasss.entities.employees;

namespace PrimeClasss
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students();
            student.Name = "Juan Perez";
            student.Id = "2024-001";
            student.Career = "Software Development";

            student.ShowInfo();
            student.Study();

            Console.WriteLine();

            
            Teaching teacher = new Teaching();
            teacher.Name = "Maria Lopez";
            teacher.Id = "EMP-101";
            teacher.Salary = 45000;
            teacher.Subject = "Programming";

            teacher.ShowInfo();
            teacher.Work();
            teacher.Teach();

            Console.WriteLine();

            Administrative admin = new Administrative();
            admin.Name = "Carlos Gomez";
            admin.Id = "EMP-202";
            admin.Salary = 40000;
            admin.Department = "Admissions";

            admin.ShowInfo();
            admin.Work();
            admin.Manage();

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}

