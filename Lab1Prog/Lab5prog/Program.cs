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
            var bagages = new List<Bagage>();
            for (int i = 0; i < 5; i++)
            {
                bagages.Add(new Bagage() { Id = rnd.Next(0, 1000), Weight = rnd.Next(0, 70) });
            }
            var BS = new BagageSpace(bagages);
            Console.WriteLine("Old Bagage space:\n");
            Console.WriteLine(BS.Print());
            var serializer = new Serializer();

            serializer.SerializeXML(BS, @"C:\Музыка\BagageSpace.xml");
            var newXmlBS = (BagageSpace)serializer.DeSerializeXML(@"C:\Музыка\BagageSpace.xml");
            Console.WriteLine("New xml Bagage space:\n");
            Console.WriteLine(newXmlBS.Print());

            serializer.SerializeJSON(BS, @"C:\Музыка\BagageSpace.json");
            var newJsonBS = (BagageSpace)serializer.DeSerializeJSON(@"C:\Музыка\BagageSpace.json");
            Console.WriteLine("New json Bagage space:\n");
            Console.WriteLine(newJsonBS.Print());

            serializer.SerializeByLINQ(BS, @"C:\Музыка\BagageSpaceByLINQ.xml");
            var newLinqBS = (BagageSpace)serializer.DeSerializeByLINQ(@"C:\Музыка\BagageSpaceByLINQ.xml");
            Console.WriteLine("New linq Bagage space:\n");
            Console.WriteLine(newLinqBS.Print());

            Console.ReadLine();
        }
    }
}
