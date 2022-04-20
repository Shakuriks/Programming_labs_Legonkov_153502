using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class ProdRate
    {
        public ProdRate()
        {

        }
        private static int hoursPerMonth;

        public int HoursPerMonth
        {
            get { return hoursPerMonth; }
            set { hoursPerMonth = value; }
        }


        private double payPerHour;

        public double PayPerHour
        {
            get { return payPerHour; }
            set { payPerHour = value; }
        }


        private double tax;

        public double Tax
        {
            get { return PayPerHour * HoursPerMonth * 0.48; }
        }

    }
}
