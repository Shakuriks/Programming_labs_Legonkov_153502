using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7prog
{
    public class Vector
    {
        public Vector()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public Vector(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }


        private int b;

        public int B
        {
            get { return b; }
            set { b = value; }
        }


        private int c;

        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public static Vector operator +(Vector x, Vector y)
        {
            Vector z = new Vector();
            z.a = x.a + y.a;
            z.b = x.b + y.b;
            z.c = x.c + y.c;
            return z;
        }

        public static Vector operator -(Vector x, Vector y)
        {
            Vector z = new Vector();
            z.a = x.a - y.a;
            z.b = x.b - y.b;
            z.c = x.c - y.c;
            return z;
        }

        public static bool operator ==(Vector x, Vector y)
        {
            return x.a == y.a && x.b == y.b && x.c == y.c;
        }

        public static bool operator !=(Vector x, Vector y)
        {
            return x.a != y.a || x.b != y.b || x.c != y.c;
        }

        public static Vector operator ++(Vector x)
        {
            Vector newX = new Vector();
            newX.a = x.a + 1;
            newX.b = x.b + 1;
            newX.c = x.c + 1;
            return newX;
        }

        public static Vector operator --(Vector x)
        {
            Vector newX = new Vector();
            newX.a = x.a - 1;
            newX.b = x.b - 1;
            newX.c = x.c - 1;
            return newX;
        }

        public static Vector operator *(Vector x, Vector y)
        {
            Vector z = new Vector();
            z.a = x.a * y.a;
            z.b = x.b * y.b;
            z.c = x.c * y.c;
            return z;
        }

        public static Vector operator *(Vector x, int y)
        {
            Vector z = new Vector();
            z.a = x.a * y;
            z.b = x.b * y;
            z.c = x.c * y;
            return z;
        }

        public static Vector operator /(Vector x, int y)
        {
            Vector z = new Vector();
            z.a = x.a / y;
            z.b = x.b / y;
            z.c = x.c / y;
            return z;
        }

        public static bool operator true(Vector x)
        {
            return x.a != 0 || x.b != 0 || x.c != 0;
        }

        public static bool operator false(Vector x)
        {
            return x.a == 0 && x.b == 0 && x.c == 0;
        }

        public static explicit operator double(Vector x)
        {
            return Math.Sqrt(Math.Pow(x.a, 2) + Math.Pow(x.b, 2) + Math.Pow(x.c, 2));
        }

        public override string ToString()
        {
            return "a = " + a.ToString() + ", b = " + b.ToString() + ", c = " + c.ToString();
        }
    }
}
