﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laborotornaya_rabota_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double a1;
            double a2;
            double a3;
            double a4;
            double b1;
            double b2;
            double c1;
            double c2;
            double result;
            double a5, a6;
            a1 = (6.84 / (Math.Pow((28.57 - 25.15), (1f / 5f))));
            a2 = ((1 / 0.3) - 2.7) / 4.12;
            a3 = (34.06 - 33.81) * 4;
            a4 = 3 + (4.2 / 0.1);
            b1 = 2f / 3f;
            b2 = 4f / 21f;
            b = b1 / b2;
            c1 = 1 + Math.Pow(5, 1f / 3f);
            c2 = c1 / 3.5;
            c = Math.Pow(c2, 0.25);
            a5 = a3 / a1;
            a6 = Math.Sqrt(a4 / a2);
            a = 26 / (a5 - a6);
            result = a + b + c;


            Console.WriteLine(result);
            
        }
    }
}
