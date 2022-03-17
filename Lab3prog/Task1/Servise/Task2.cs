using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Servise
{
    public class Task2cl
    {
        public void f(double z)
        {
            double x;
            int branch;

            if (z <= 0)
            {
                x = Math.Pow(z, 2) + 5;
                branch = 1;
            }
            else
            {
                x = 1 / Math.Sqrt(z - 1);
                branch = 2;
            }

            Console.WriteLine($"Результат вычисления : {Math.Pow(Math.Sin(Math.Pow(x, 2) - 1), 3) + Math.Log10(Math.Abs(x)) + Math.Exp(x)}");
            Console.WriteLine($"Номер ветки : {branch}");
        }
    }
}
