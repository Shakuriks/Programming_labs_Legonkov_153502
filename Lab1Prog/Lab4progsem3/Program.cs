using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4progsem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oldClients = new List<Client>();
            oldClients.Add(new Client("Stas", 100, false));
            oldClients.Add(new Client("Yaroslav", 200, false));
            oldClients.Add(new Client("Misha", 230, true));
            oldClients.Add(new Client("Vadim", 350, true));
            oldClients.Add(new Client("Alexandr", 400, true));
            oldClients.Add(new Client("Boris", 560, true));

            var fileService = new FileService();
            var oldFileName = @"C:\Музыка\Clients";
            var newFileName = @"C:\Музыка\Bank Clients";

            fileService.SaveData(oldClients, oldFileName);

            if(File.Exists(newFileName))
                File.Delete(newFileName);
            File.Move(oldFileName, newFileName);

            var newClients = fileService.ReadFile(newFileName).ToList();

            Console.WriteLine("Not sorted collection:");
            foreach(var cl in newClients)
            {
                Console.WriteLine($"Name: {cl.Name}; Deposit: {cl.Deposit}; Employed: {cl.Employed}");
            }

            var sortedByNameCollection = newClients.OrderBy(item => item, new MyCustomComparer<Client>()); ;

            Console.WriteLine();
            Console.WriteLine("Sorted by name collection:");
            foreach (var cl in sortedByNameCollection)
            {
                Console.WriteLine($"Name: {cl.Name}; Deposit: {cl.Deposit}; Employed: {cl.Employed}");
            }

            var sortedByDepositCollection = newClients.OrderBy(item => item.Deposit);

            Console.WriteLine();
            Console.WriteLine("Sorted by deposit collection:");
            foreach (var cl in sortedByDepositCollection)
            {
                Console.WriteLine($"Name: {cl.Name}; Deposit: {cl.Deposit}; Employed: {cl.Employed}");
            }

            Console.ReadLine();
        }
    }
}
