﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_and_min
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("pato.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string a = sr.ReadLine();
            string[] b = a.Split(' ');
            int max = int.Parse(b[0]);
            int min = int.Parse(b[0]);
            sr.Close();
            fs.Close();
            for(int i = 1;i < b.Length; i++)
            {
                if(int.Parse(b[i]) > max)
                {
                    max = int.Parse(b[i]);
                }
                if(int.Parse(b[i]) < min)
                {
                    min = int.Parse(b[i]);
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            

        }
    }
}
