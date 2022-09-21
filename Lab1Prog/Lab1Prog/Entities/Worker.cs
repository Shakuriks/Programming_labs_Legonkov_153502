using System;
using System.Collections.Generic;
using System.Linq;
using Lab1Prog.Collections;

namespace Lab1Prog.Entities
{
    public class Worker
    {
        public Worker(string secondName)
        {
            this.secondName = secondName;
        }
        private string secondName;

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        List<Job> lstJobs = new List<Job>();

        public void AddJob(string title, int payment)
        {
            lstJobs.Add(new Job(title, payment));
        }

        public void AddJob(Job job)
        {
            lstJobs.Add(job);
        }

        public int Payment()
        {
            return lstJobs.Select(item => item.Payment).Sum();
        }

        public string Titles()
        {
            var orderByCollection = lstJobs.OrderBy(item => item.Title).Select(item => item.Title);

            var result = "";
            foreach (var item in orderByCollection)
            {
                result += item + "; ";
            }
            return result;
        }

        public string SalaryList()
        {
            string result = "";

            var groupByCollection = lstJobs.GroupBy(item => item.Title);

            foreach(var t in groupByCollection)
            {
                result += $"{t.Key} : ";

                foreach (var p in t)
                {
                    result += p.Payment.ToString() + "; ";
                }

                result += '\n';
            }

            return result;
        }
    }
}
