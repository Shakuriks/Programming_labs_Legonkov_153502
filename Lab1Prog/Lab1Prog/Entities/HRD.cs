using System;
using System.Collections.Generic;
using System.Linq;
using Lab1Prog.Entities;
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

        public Journal journal = new Journal();
        
        private HRD()
        {
            WorkerAdded += journal.AddEvent;
            WorkDone += title => Console.WriteLine($"Competed work: {title};");
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
        Dictionary<string, int> Jobs = new Dictionary<string, int>();

        public string PrintWorkDone(string title)
        {
            return $"Competed work: {title};";
        }

        public void AddJob(string title, int payment)
        {
            Jobs.Add(title, payment);
        }


        public void AddWorker(string secondName)
        {
            lstWorkers.Add(new Worker(secondName));
            WorkerAdded(secondName);
        }

        //public void AddJobForWorker(string secondName, Job job)
        //{
        //    foreach (Worker worker in lstWorkers)
        //    {
        //        if (worker.SecondName == secondName)
        //            worker.AddJob(job);
        //    }
        //    lstJobs.Add(job);
        //    WorkDone?.Invoke(job.Title);
        //}

        public void AddJobForWorker(string secondName, string title)
        {
            if (Jobs.ContainsKey(title) && lstWorkers.FirstOrDefault(item => item.SecondName == secondName) != null)
            {
                var newJob = new Job(title, Jobs.First(item => item.Key == title).Value);
                lstWorkers.First(item => item.SecondName == secondName).AddJob(newJob);
                WorkDone?.Invoke(title);
            }
        }

        public int SearchForPayment(string secondName)
        {
            if (lstWorkers.FirstOrDefault(item => item.SecondName == secondName) != null)
                return lstWorkers.First(item => item.SecondName == secondName).Payment();
            else
                return -1;
        }

        public string SearchForTitles(string secondName)
        {
            if (lstWorkers.FirstOrDefault(item => item.SecondName == secondName) != null)
                return lstWorkers.First(item => item.SecondName == secondName).Titles();
            else
                return "";
        }

        public int TotalPayment()
        {
            return lstWorkers.Select(item => item.Payment()).Sum();
        }

        public string TotalTitles()
        {
            var orderByCollection = Jobs.OrderBy(item => item.Value)
                                        .Select(item => item.Key);
                                        
            var result = "";
            foreach (var item in orderByCollection)
            {
                result += item + "; ";
            }
            return result;
        }

        public string MaxPaymentWorker()
        {
            //return lstWorkers.OrderBy(item => item.Payment())
            //                 .FirstOrDefault().SecondName;
            if (lstWorkers.FirstOrDefault(item => item.Payment() == lstWorkers.Max(item2 => item2.Payment())) != null)
                return lstWorkers.First(item => item.Payment() == lstWorkers.Max(item2 => item2.Payment())).SecondName;
            else
                return "";
        }

        public int PaymentMore(int p)
        {
            return lstWorkers.Aggregate(0, (total, next) => next.Payment() > p ? total + 1 : total);
        }

        public string SalaryList(string secondName)
        {
            if (lstWorkers.FirstOrDefault(item => item.SecondName == secondName) != null)
            {
                return lstWorkers.First(item => item.SecondName == secondName).SalaryList();
            }
            else
                return "";
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
