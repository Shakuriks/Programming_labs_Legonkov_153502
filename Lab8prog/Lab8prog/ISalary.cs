using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8prog
{
    interface ISalary
    {
        double GetSalary();
    }

    class NoPremium : ISalary
    {
        double salary;
        public NoPremium(double salary)
        {
            this.salary = salary;
        }
        public double GetSalary()
        {
            return salary;
        }
    }

    class Premium : ISalary
    {
        double salary;
        double premium;
        public Premium(double salary, double premium)
        {
            this.salary = salary;
            this.premium = premium;
        }
        public double GetSalary()
        {
            return salary + salary * premium / 100;
        }
    }
}
