using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Queries_6
{
    class Program
    {
        // ToUpper() method Usage

        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student{ Id=1, Name = "Musa", Surname = "Küçük", Quiz1 = 55, Quiz2 = 90 },
                new Student{ Id=2, Name = "Mustafa", Surname = "Küçük", Quiz1 = 42, Quiz2 = 60 },
                new Student{ Id=3, Name = "Nursena", Surname = "Küçük", Quiz1 = 30, Quiz2 = 100 },
                new Student{ Id=4, Name = "Yavuz", Surname = "Küçük", Quiz1 = 34, Quiz2 = 55 }
            };

            var query = from student in students
                        select (student.Name.ToUpper(), student.Surname.ToUpper());

            foreach (var item in query)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2);
            }

            Console.ReadKey();
        }
    }
}
