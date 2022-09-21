using Lab1Prog.Collections;
using Lab1Prog.Entities;
using System;



namespace Lab1Prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HRD company = HRD.GetInstance();
            Console.WriteLine("Введите название компании");
            company.Name = Console.ReadLine();

            company.AddJob("cleaning", 100);
            company.AddJob("security", 450);
            company.AddJob("secretary", 300);
            company.AddWorker("Vadim");
            company.AddJobForWorker("Vadim", "cleaning");
            company.AddJobForWorker("Vadim", "secretary");
            company.AddWorker("Alexandr");
            company.AddJobForWorker("Alexandr", "security");
            company.AddJobForWorker("Alexandr", "security");
            Console.WriteLine("Paymen for Vadim : ");
            Console.WriteLine(company.SearchForPayment("Vadim"));
            Console.WriteLine("Paymen for Alexandr : ");
            Console.WriteLine(company.SearchForPayment("Alexandr"));
            Console.WriteLine("Vadim's work : ");
            Console.WriteLine(company.SearchForTitles("Vadim"));
            Console.WriteLine("Alexandr's work : ");
            Console.WriteLine(company.SearchForTitles("Alexandr"));
            Console.WriteLine("Total payment : ");
            Console.WriteLine(company.TotalPayment());
            Console.WriteLine("Types of jobs : ");
            Console.WriteLine(company.TotalTitles());
            Console.WriteLine("Worker with max payment : ");
            Console.WriteLine(company.MaxPaymentWorker());
            Console.WriteLine("Count of workers, which have payment more than 430");
            Console.WriteLine(company.PaymentMore(430));
            Console.WriteLine("SalaryList of Vadim : ");
            Console.WriteLine(company.SalaryList("Vadim"));
            Console.WriteLine("SalaryList of Alexandr : ");
            Console.WriteLine(company.SalaryList("Alexandr"));
            //company.GenerateIndexOutOfRangeException();
            //company.ElementWasNotFoundException();
            company.journal.Print();

            Console.ReadKey();
        }
    }
}
