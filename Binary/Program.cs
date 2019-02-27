using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a);
            Console.WriteLine(a + 1);

            int n ;
            Console.WriteLine("bee");
            n = Convert.ToInt32(Console.ReadLine());
              
           string binary = Convert.ToString(n,2);

            Console.WriteLine(binary);

            Console.WriteLine();

            int b = int.MinValue;
            Console.WriteLine(b);
            //Console.WriteLine(b + 1);



            Console.Read();
        }
    }
}
