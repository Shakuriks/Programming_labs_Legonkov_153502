using Lab5prog.Domain;
using SerializerLab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var bagageSpaces = new List<BagageSpace>();
            for(var i = 0; i < 5; i++)
            {
                var bagages = new List<Bagage>();
                for (var j = 0; j < 5; j++)
                {
                    bagages.Add(new Bagage() { Id = rnd.Next(0, 1000), Weight = rnd.Next(0, 70) });
                }
                bagageSpaces.Add(new BagageSpace(bagages));
            }
            Console.WriteLine("Old Bagage space:\n");
            foreach(var item in bagageSpaces)
            {
                Console.WriteLine(item.Print());
                Console.WriteLine("\n\n\n");
            }
            var serializer = new Serializer();

            serializer.SerializeXML(bagageSpaces, @"C:\Музыка\BagageSpace.xml");
            var newXmlBS = (List<BagageSpace>)serializer.DeSerializeXML(@"C:\Музыка\BagageSpace.xml");
            Console.WriteLine("New xml Bagage space:\n");
            foreach (var item in newXmlBS)
            {
                Console.WriteLine(item.Print());
                Console.WriteLine("\n\n\n");
            }

            serializer.SerializeJSON(bagageSpaces, @"C:\Музыка\BagageSpace.json");
            var newJsonBS = (List<BagageSpace>)serializer.DeSerializeJSON(@"C:\Музыка\BagageSpace.json");
            Console.WriteLine("New json Bagage space:\n");
            foreach (var item in newJsonBS)
            {
                Console.WriteLine(item.Print());
                Console.WriteLine("\n\n\n");
            }

            serializer.SerializeByLINQ(bagageSpaces, @"C:\Музыка\BagageSpaceByLINQ.xml");
            var newLinqBS = (List<BagageSpace>)serializer.DeSerializeByLINQ(@"C:\Музыка\BagageSpaceByLINQ.xml");
            Console.WriteLine("New linq Bagage space:\n");
            foreach (var item in newLinqBS)
            {
                Console.WriteLine(item.Print());
                Console.WriteLine("\n\n\n");
            }

            Console.ReadLine();
        }
    }
}
