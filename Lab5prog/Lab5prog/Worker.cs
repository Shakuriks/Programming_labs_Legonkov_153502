using System.Collections.Generic;


namespace Lab5prog
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
