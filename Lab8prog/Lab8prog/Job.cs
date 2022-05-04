using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8prog
{
    class Job
    {
        public Job(string title, ISalary isalary)
        {
            this.title = title;
            this.isalary = isalary;
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        ISalary isalary;

        public double GetSalary()
        {
            return isalary.GetSalary();
        }

    }
}
