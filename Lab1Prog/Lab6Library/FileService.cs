using Lab6prog;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;


namespace Lab6Library
{
    public class FileService<T> : IFileService<T> where T : class
    {
        public IEnumerable<T> ReadFile(string fileName)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                return jsonFormatter.ReadObject(fs) as List<T>;
            }
        }

        public void SaveData(IEnumerable<T> data, string fileName)
        {
            var file = new FileInfo(fileName);
            if (file.Exists)
                file.Delete();
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, data);
            }
        }
    }
}
