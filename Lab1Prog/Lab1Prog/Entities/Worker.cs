using System;
using System.Collections.Generic;
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

        MyCustomCollection<Job> lstJobs = new MyCustomCollection<Job>();

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
            int result = 0;
            foreach (Job job in lstJobs)
            {
                result += job.Payment;
            }
            return result;
        }

        public string Titles()
        {
            string result = "";

            foreach (Job job in lstJobs)
            {
                result += job.Title + " ";
            }

            return result;
        }


    }
}
