using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Queries_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rakamlar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query = from rakam in rakamlar
                        select rakam + 1;

            foreach (var item in query)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.ReadKey();
        }
    }
}
