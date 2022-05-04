using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(3, 3, 3);
            Vector vector2 = new Vector(1, 1, 1);
            Vector vector3 = new Vector();
            Vector vector4 = new Vector(0, 0, 0);

            vector3 = vector1 + vector2;
            vector3 -= vector4;
            vector3--;
            vector3--;
            vector3++;
            vector3 = vector3 * vector1;
            vector3 *= 2;
            vector3 /= 9;
            Console.WriteLine(vector3);
            Console.WriteLine(vector3 == vector1);
            Console.WriteLine(vector3 != vector2);
            Console.WriteLine(((double)vector3));
            if (vector4)
                Console.WriteLine("Mistake");
            else
                Console.WriteLine("No mistakes");
            Console.ReadKey();
        }
    }
}
