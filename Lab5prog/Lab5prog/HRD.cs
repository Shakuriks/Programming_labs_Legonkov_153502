using System.Collections.Generic;


namespace Lab5prog
{
    public sealed class HRD
    {
        private HRD()
        {

        }

        private static HRD _instance;

        public static HRD GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HRD();
            }
            return _instance;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        List<Worker> lstWorkers = new List<Worker>();
        List<Job> lstJobs = new List<Job>();


        public void AddWorker(string secondName)
        {
            lstWorkers.Add(new Worker(secondName));
        }

        public void AddJobForWorker(string secondName, Job job)
        {
            foreach (Worker worker in lstWorkers)
            {
                if (worker.SecondName == secondName)
                    worker.AddJob(job);
            }
            lstJobs.Add(job);
        }

        public void AddJobForWorker(string secondName, string title, int payment)
        {
            foreach (Worker worker in lstWorkers)
            {
                if (worker.SecondName == secondName)
                    worker.AddJob(title, payment);
            }
            lstJobs.Add(new Job(title, payment));
        }

        public int SearchForPayment(string secondName)
        {
            foreach (Worker worker in lstWorkers)
            {
                if (worker.SecondName == secondName)
                    return worker.Payment();
            }
            return -1;
        }

        public string SearchForTitles(string secondName)
        {
            foreach (Worker worker in lstWorkers)
            {
                if (worker.SecondName == secondName)
                    return worker.Titles();
            }
            return "";
        }

        public int TotalPayment()
        {
            int result = 0;
            foreach (Worker worker in lstWorkers)
            {
                result += worker.Payment();
            }
            return result;
        }

        public string TotalTitles()
        {
            string result = "";
            foreach  (Job j in lstJobs)
            {
                result += j.Title + " ";
            }
            return result;
        }
    }
}
