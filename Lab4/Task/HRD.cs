using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public sealed class HRD : ProdRate
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

        private static int numberOfWorkers;

        public static int NumberOfWorkers
        {
            get { return numberOfWorkers; }
            set { numberOfWorkers = value; }
        }

        private static string name;

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static double GetGeneralTax(ProdRate[] workers)
        {
            double generalTax = 0;

            for (int i = 0; i < workers.Length; i++)
            {
                generalTax += workers[i].Tax;
            }

            return generalTax;
        }


    }
}
