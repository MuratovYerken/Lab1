using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    class Program
    {
        /// <summary>
        /// function that defines whether it is prime or not
        /// </summary>
        /// <param name="a">necessary number</param>
        /// <returns>a boolean value </returns>
        /// <exception cref="1 is not a prime number" ></exception>
        static bool IsPrime(int a)
        {
           if (a == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(a); ++i)
            {
                if (a % i == 0)
                {
                    return false;
                }

              
            }

                return true;
            
        }

      

        static void Main(string[] args)
             {

              string n = Console.ReadLine();
            string[] t = n.Split(' ');
            for(int i = 0;i < t.Length; ++i)
            {
                if(IsPrime(int.Parse(t[i])) == true)
                {
                    Console.WriteLine(t[i]);
                }
            }
             }
           }
        }
