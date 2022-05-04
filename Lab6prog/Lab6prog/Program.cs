using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit first = new Archer(2, 7, 8);
            Unit second = new Swordman(2, 10, 1);
            Unit third = new Rider(3, 15, 4);
            first.ToAttack(second);
            second.ToAttack(first);
            third.ToAttack(first);
            third.ToAttack(second);
            first.ToAttack(third);
            Console.WriteLine(first.ShowHealth());
            Console.WriteLine(first.Position);
            Console.WriteLine(second.ShowHealth());
            Console.WriteLine(second.Position);
            Console.WriteLine(third.ShowHealth());
            Console.WriteLine(third.Position);
            Console.ReadKey();
        }
    }
}
