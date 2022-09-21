using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4progsem3
{
    public class Client
    {
        public string Name { get; set; }

        public int Deposit { get; set; }

        public bool Employed { get; set; }

        public Client(){}

        public Client(string name, int deposit, bool employed)
        {
            Name = name;
            Deposit = deposit;
            Employed = employed;
        }
    }

    public class MyCustomComparer<T> : IComparer<T> where T : Client
    {
        public int Compare(T x, T y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
