

namespace Lab6prog
{
    public class Employee
    {
        public int Salary { get; set; }
        public bool Premium { get; set; }
        public string Name { get; set; }

        public string Print()
        {
            return $"Name: {Name}, Salary: {Salary}, Premium: {Premium}\n";
        }
    }
}
