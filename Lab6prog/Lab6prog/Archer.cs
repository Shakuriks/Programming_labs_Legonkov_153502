using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6prog
{
    public class Archer : Unit
    {
        public Archer(int attack, int health, int position) : base(attack, health, position)
        {
            range = 10;
        }

        public override void ToAttack(Unit rival)
        {
            if (Math.Abs(position - rival.Position) <= range)
                rival.Health -= attack;
        }
    }
}
