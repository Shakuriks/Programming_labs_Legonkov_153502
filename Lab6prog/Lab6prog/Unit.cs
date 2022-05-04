using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6prog
{
    public abstract class Unit
    {
        public Unit(int attack, int health,int position)
        {
            this.attack = attack;
            this.health = health;
            this.position = position;
        }
        public Unit()
        {
            attack = 0;
            health = 0;
            position = 0;
        }

        protected int attack;

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        protected int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        protected int position;

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        protected int range;

        public int Range
        {
            get { return range; }
            set { range = value; }
        }


        public abstract void ToAttack(Unit rival);

        public virtual void Move(int direction)
        {
            if (direction == 1)
                position++;
            else
                position--;
        }

        public string ShowHealth()
        {
            return Convert.ToString(health);
        }
    }
}
