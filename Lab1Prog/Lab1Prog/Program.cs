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
            Journal journal = new Journal();

            company.WorkerAdded += journal.AddEvent;
            company.WorkDone += title => Console.WriteLine($"Competed work: {title};");
            company.AddWorker("Vadim");
            company.AddJobForWorker("Vadim", new Job("cleaning", 10));
            company.AddJobForWorker("Vadim", "secretary", 100);
            company.AddWorker("Alexandr");
            company.AddJobForWorker("Alexandr", "security", 50);
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
            Console.WriteLine("Completed work : ");
            Console.WriteLine(company.TotalTitles());
            company.GenerateIndexOutOfRangeException();
            company.ElementWasNotFoundException();
            journal.Print();

            Console.ReadKey();
        }
    }
}
