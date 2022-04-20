using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название компании : ");
            HRD.Name = Console.ReadLine();

            Console.WriteLine("Введите количество работников компании : ");
            HRD.NumberOfWorkers = Convert.ToInt32(Console.ReadLine());

            HRD company = HRD.GetInstance();

            Console.WriteLine("Введите норму выработки часов в месяц : ");
            company.HoursPerMonth = Convert.ToInt32(Console.ReadLine());

            ProdRate[] workers = new ProdRate[HRD.NumberOfWorkers];
            Console.WriteLine("Введите оплаты работников за час");

            for (int i = 0; i < workers.Length; i++)
            {
                ProdRate prodRate = new ProdRate();
                workers[i] = prodRate;
                workers[i].PayPerHour = Convert.ToDouble(Console.ReadLine());
            }

 //           company.Workers = workers;

            bool cont = true;

            while(cont)
            {
                Console.WriteLine("Посчитать общую выплату по подоходному налогу - введите 1;");
                Console.WriteLine("Изменить норму выработки часов в месяц - введите 2;");
                Console.WriteLine("Завершить - введите 3;");

                string dialog = Console.ReadLine();

                switch(dialog)
                {
                    case "1":
                        double genTax = HRD.GetGeneralTax(workers);
                        Console.WriteLine(genTax);
                        break;
                    case "2":
                        Console.WriteLine("Введите новую норму выработки в месяц");
                        company.HoursPerMonth = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "3":
                        cont = false;
                        break;
                }
            }

        }
    }
}
