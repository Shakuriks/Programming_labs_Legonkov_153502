using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8prog
{
    public class HRD
    {
        List<Job> lstJob = new List<Job>();

        public void AddNoPremiumJob(string name, double price)
        {
            Job newJob = new Job(name, new NoPremium(price));
            lstJob.Add(newJob);
        }
        public void AddPremiumJob(string name, double price, double premium)
        {
            Job newJob = new Job(name, new Premium(price, premium));
            lstJob.Add(newJob);
        }

        public double GetTotalSalary()
        {
            double result = 0;

            foreach (Job job in lstJob)
            {
                result += job.GetSalary();
            }

            return result;
        }
    }
}
