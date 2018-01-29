using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {   
        int a;
        int b;
        static int NOD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;

                }
                else if (b > a)
                {
                    b -= a;

                }

            }
            return a;
        }
        void Sim()
        {
            int q = NOD(a, b);
            a = a / q;
            b = b / q;
        }
        public Complex(int c, int d)
        {
            a = c;
            b = d;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex f = new Complex(c1.a * c2.b + c1.b * c2.a, c1.b * c2.b);
            f.Sim();
            return f;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
    }
    
}
