using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6prog
{
    public sealed class Rider : Swordman
    {
        public Rider(int attack, int health, int position) : base(attack, health, position)
        {
        }

        public override void ToAttack(Unit rival)
        {
            if (Math.Abs(position - rival.Position) <= range)
            {
                rival.Health -= attack;
                if (position > rival.Position)
                    rival.Move(-1);
                else
                    rival.Move(1);
            }    
        }

        public override void Move(int direction)
        {
            base.Move(direction);
            base.Move(direction);
        }
    }
}
