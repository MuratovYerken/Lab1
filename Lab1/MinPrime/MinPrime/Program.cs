using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_and_min
{
    class Program
    {
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
            FileStream fs = new FileStream("pat.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string a = sr.ReadLine();
            string[] b = a.Split(' ');
            bool found = false;
            int min = 0;
            
            for(int i = 0;i < b.Length; ++i)
            {
                if (IsPrime(int.Parse(b[i])) == true && found == false)
                {
                    min = int.Parse(b[i]);
                    found = true;
                }
                if(found == true && IsPrime(int.Parse(b[i])) == true && int.Parse(b[i]) < min){
                    min = int.Parse(b[i]);
                }

            }
            Console.WriteLine(min);


        }
    }
}