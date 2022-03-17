using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Task1cl
    {
        public bool isEquilateral(double a, double b, double c)
        {
            bool isEq;

            if (a == b && b == c && a == c)
            {
                isEq = true;
            }
            else
            {
                isEq = false;
            }

            return isEq;
        }
        static void Main(string[] args)
        {
            bool cont = true;

            while (cont)
            {
                double a, b, c;

                Console.WriteLine("Введите стороны треугольника");

                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(a);

                Task1cl method = new Task1cl();

                if (method.isEquilateral(a, b, c))
                {
                    Console.WriteLine("Треугольник равносторонний");
                }
                else
                {
                    Console.WriteLine("Треугольник не равносторонний");
                }

                string s;
                do
                {
                    Console.WriteLine("Желаете продолжить?(1 - Да, 2 - Нет)");
                    s = Console.ReadLine();

                } while (s != "1" && s != "2");

                switch(s)
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
