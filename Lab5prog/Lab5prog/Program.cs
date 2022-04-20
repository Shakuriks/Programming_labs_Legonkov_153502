using System;


namespace Lab5prog
{
    class Program
    {
        static void Main(string[] args)
        {
            HRD company = HRD.GetInstance();
            Console.WriteLine("Введите название компании");
            company.Name = Console.ReadLine();

            //company.AddWorker("Vadim");
            //company.AddJobForWorker("Vadim", new Job("cleaning", 10));
            //company.AddJobForWorker("Vadim", "secretary", 100);
            //company.AddWorker("Alexandr");
            //company.AddJobForWorker("Alexandr", "fighter", 50);
            //Console.WriteLine("Paymen for Vadim : ");
            //Console.WriteLine(company.SearchForPayment("Vadim"));
            //Console.WriteLine("Paymen for Alexandr : ");
            //Console.WriteLine(company.SearchForPayment("Alexandr"));
            //Console.WriteLine("Vadim's work : ");
            //Console.WriteLine(company.SearchForTitles("Vadim"));
            //Console.WriteLine("Alexandr's work : ");
            //Console.WriteLine(company.SearchForTitles("Alexandr"));
            //Console.WriteLine("Total payment : ");
            //Console.WriteLine(company.TotalPayment());
            //Console.WriteLine("Completed work : ");
            //Console.WriteLine(company.TotalTitles());

            bool cont = true;

            do
            {
                Console.WriteLine("1 - Добавить работника, 2 - Добавить работу работнику, 3 - Вывести зарплату работника,");
                Console.WriteLine(" 4 - Вывести работы работника, 5 - Вывести общую выплату, 6 - Вывести все проделанные работы, 7 - Завершить");
                int sw = Convert.ToInt32(Console.ReadLine());

                string secondName;

                switch (sw)
                {
                    case 1:
                        Console.WriteLine("Введите фамилию работника");
                        secondName = Console.ReadLine();
                        company.AddWorker(secondName);
                        break;
                    case 2:
                        Console.WriteLine("Введите фамилию работника");
                        secondName = Console.ReadLine();
                        Console.WriteLine("Введите название работы");
                        string title = Console.ReadLine();
                        Console.WriteLine("Введите выплату по данной работе");
                        int payment = Convert.ToInt32(Console.ReadLine());
                        company.AddJobForWorker(secondName, title, payment);
                        break;
                    case 3:
                        Console.WriteLine("Введите фамилию работника");
                        secondName = Console.ReadLine();
                        Console.WriteLine(company.SearchForPayment(secondName));
                        break;
                    case 4:
                        Console.WriteLine("Введите фамилию работника");
                        secondName = Console.ReadLine();
                        Console.WriteLine(company.SearchForTitles(secondName));
                        break;
                    case 5:
                        Console.WriteLine(company.TotalPayment());
                        break;
                    case 6:
                        Console.WriteLine(company.TotalTitles());
                        break;
                    case 7:
                        cont = false;
                        break;
                }
            } while (cont);


        }

    }
}
