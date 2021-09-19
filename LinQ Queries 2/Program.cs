using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Queries_2
{
    class Program
    {
        // Where And Drilling
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{ Name = "Musa", Surname = "Küçük", Quiz1 = 55, Quiz2 = 90 },
                new Student{ Name = "Mustafa", Surname = "Küçük", Quiz1 = 42, Quiz2 = 60 },
                new Student{ Name = "Nursena", Surname = "Küçük", Quiz1 = 30, Quiz2 = 100 },
                new Student{ Name = "Yavuz", Surname = "Küçük", Quiz1 = 34, Quiz2 = 55 }
            };

            var query = students.Where(x => x.Surname == "Küçük");

            foreach (var i in query)
            {
                Console.WriteLine(String.Format("Name and Surname of student: {0}",i.Name,i.Surname));
                foreach (var x in query)
                {
                    Console.WriteLine(x.Quiz1.ToString(),x.Quiz2.ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
