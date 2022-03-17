using System;
using Task1.Servise;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Task1cl
    {
        static void Main(string[] args)
        {
            double x;
            double z;

            Console.WriteLine("Введите x :");
            x = Convert.ToDouble(Console.ReadLine());

            MyMath a = new MyMath();

            Console.WriteLine($"Результат вычисления x^2/2 + x^4/4 + x^6/6 равен  { a.f(2, x) + a.f(4, x) + a.f(6, x) }");

            Console.WriteLine("Введите z :");
            z = Convert.ToDouble(Console.ReadLine());

            Task2cl b = new Task2cl();
            b.f(z);

            DateServise d = new DateServise();
            string date1;
            Console.WriteLine("Введите дату, чобы узнать день недели");
            date1 = Console.ReadLine();
            Console.WriteLine(d.GetDay(date1));

            int day, month, year;
            Console.WriteLine("Введите день, месяц и год даты, до которой хотите посчитать количество дней");
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Дней до введенной даты : { d.GetDaysSpan(day, month, year)}");

            Console.ReadKey();
        }
    }
}
