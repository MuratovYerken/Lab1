using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(1, 4);
            Complex co = new Complex(1, 4);
            Complex com = c + co;
            Console.WriteLine(com);
        }
    }
}
