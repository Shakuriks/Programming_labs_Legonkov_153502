using Lab1Prog.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Prog.Entities
{
    public class Journal
    {
        MyCustomCollection<string> journal = new MyCustomCollection<string>();

        public void AddEvent(string secondName)
        {
            journal.Add($"Worker added: {secondName};");
        }

        public void Print()
        {
            string text = "";
            foreach(string s in journal)
            {
                text += s + '\n';
            }
            Console.WriteLine(text);
        }
    }
}
