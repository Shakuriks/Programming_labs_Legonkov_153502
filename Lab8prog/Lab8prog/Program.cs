using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8prog
{
    class Program
    {
        static void Main(string[] args)
        {
            HRD company = new HRD();

            company.AddNoPremiumJob("work1", 10);
            company.AddPremiumJob("work3", 30, 50);
            Console.WriteLine(company.GetTotalSalary());
            Console.ReadKey();
        }
    }
}
