using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1Prog.Collections;

namespace Lab1Prog.Entities
{
    public delegate void WorkerAddedDelegate(string SecondName);
    public delegate void WorkDoneDelegate(string Title);
    public sealed class HRD
    {
        public event WorkerAddedDelegate WorkerAdded;
        public event WorkDoneDelegate WorkDone;
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

        MyCustomCollection<Worker> lstWorkers = new MyCustomCollection<Worker>();
        MyCustomCollection<Job> lstJobs = new MyCustomCollection<Job>();


        public void AddWorker(string secondName)
        {
            lstWorkers.Add(new Worker(secondName));
            WorkerAdded(secondName);
        }

        public void AddJobForWorker(string secondName, Job job)
        {
            foreach (Worker worker in lstWorkers)
            {
                if (worker.SecondName == secondName)
                    worker.AddJob(job);
            }
            lstJobs.Add(job);
            WorkDone(job.Title);
        }

        public void AddJobForWorker(string secondName, string title, int payment)
        {
            foreach (Worker worker in lstWorkers)
            {
                if (worker.SecondName == secondName)
                    worker.AddJob(title, payment);
            }
            lstJobs.Add(new Job(title, payment));
            WorkDone(title);
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
            foreach (Job j in lstJobs)
            {
                result += j.Title + " ";
            }
            return result;
        }

        public void GenerateIndexOutOfRangeException()
        {
            Worker temp = new Worker("SecondName");
            lstWorkers[lstWorkers.Count] = new Worker("SecondName");
            temp = lstWorkers[lstWorkers.Count];
        }

        public void ElementWasNotFoundException()
        {
            Worker temp = new Worker("SecondName");
            lstWorkers.Remove(temp);
        }
    }
}
