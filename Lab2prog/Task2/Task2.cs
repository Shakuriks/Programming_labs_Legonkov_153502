﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Task2cl
    {
        public double mod(double x)
        {
            double modx;

            if (x >= 0)
                modx = x;
            else
                modx = -x;

            return modx;
        }
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Введите x");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y");
                double y = Convert.ToDouble(Console.ReadLine());

                Task2cl method = new Task2cl();
                double modx = method.mod(x);

                if (y > modx && x * x + y * y < 225)
                    Console.WriteLine("Да");
                else if (y < modx || x * x + y * y > 225)
                    Console.WriteLine("Нет");
                else
                    Console.WriteLine("На границе");

                string s;
                do
                {
                    Console.WriteLine("Желаете продолжить?(1 - Да, 2 - Нет)");
                    s = Console.ReadLine();

                } while (s != "1" && s != "2");

                switch (s)
                {
                    case "1":
                        cont = true;
                        break;
                    case "2":
                        cont = false;
                        break;
                }
            }
        }
    }
}
