    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Queries_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Yol

            /*
            int[] rakamlar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = from rakam in rakamlar
                        where rakam < 5
                        select rakam;
            Console.WriteLine("5 den küçük rakamlar: ");
            foreach (var rakam in query)
            {
                Console.WriteLine(rakam);
            }
            */

            // 2. Yol

            int[] Rakamlar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("5 den küçük rakamlar:");
            var query = Rakamlar.Where(x => x < 5);
            foreach (var i in query)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
