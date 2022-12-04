using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                max = a;
            }
            else
            {
                max = b;
            }


            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
