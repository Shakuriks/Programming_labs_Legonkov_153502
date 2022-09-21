using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4progsem3
{
    public class FileService : IFileService<Client>
    {
        public IEnumerable<Client> ReadFile(string fileName)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                // пока не достигнут конец файла
                // считываем каждое значение из файла
                while (reader.PeekChar() > -1)
                {
                    string name;
                    int deposit;
                    bool employed;
                    try
                    {
                        name = reader.ReadString();
                        deposit = reader.ReadInt32();
                        employed = reader.ReadBoolean();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        yield break;
                    }
                    yield return new Client(name, deposit, employed);
                }
            }
        }

        public void SaveData(IEnumerable<Client> data, string fileName)
        {
            if (File.Exists(fileName))
                File.Delete(fileName);
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
            {
                // записываем в файл значение каждого свойства объекта
                try
                {
                    foreach (var d in data)
                    {
                        writer.Write(d.Name);
                        writer.Write(d.Deposit);
                        writer.Write(d.Employed);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
