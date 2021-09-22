using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Queries_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{ Id=1, Name = "Musa", Surname = "Küçük", Quiz1 = 55, Quiz2 = 90 },
                new Student{ Id=2, Name = "Mustafa", Surname = "Küçük", Quiz1 = 42, Quiz2 = 60 },
                new Student{ Id=3, Name = "Nursena", Surname = "Küçük", Quiz1 = 30, Quiz2 = 100 },
                new Student{ Id=4, Name = "Yavuz", Surname = "Küçük", Quiz1 = 34, Quiz2 = 55 },
                new Student{ Id=5, Name = "Jack", Surname = "Harlow", Quiz1 = 85, Quiz2 = 74}
            };

            List<Club> clubs = new List<Club>()
            {
                new Club { Id = 5, Title = "Tennis" },
                new Club { Id = 4 , Title = "Golf"},
                new Club { Id = 3 , Title = "Music"}
            };

            var query = from club in clubs
                        from student in students
                        where student.Surname == "Küçük"
                        select new { student.Name,club.Title};

            foreach (var item in query)
            {
                Console.WriteLine(String.Format("{0} adlı öğrenci {1} kulübüne gidiyor.",item.Name,item.Title));    
            }

            Console.ReadKey();
        }
    }
}
