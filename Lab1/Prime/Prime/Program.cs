using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static bool IsPrime(int a)
        {
            for (int i = 2; i <= Math.Sqrt(a); ++i)
            {
                if (a % i == 0)
                {
                    return false;
                }

                else if (a == 1)
                {
                    return false;
                }
            }

            return true;

        }



        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }
    }
}