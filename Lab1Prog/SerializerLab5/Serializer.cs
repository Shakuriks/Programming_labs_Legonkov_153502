using Lab5prog.Domain;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Linq;

namespace SerializerLab5
{
    public class Serializer : ISerializer
    {
        public IEnumerable<BagageSpace> DeSerializeByLINQ(string fileName)
        {
            var bagagesData = XElement.Load(fileName);
            var data = bagagesData.Descendants("BagageSpace");
            var bagageSpaces = new List<BagageSpace>();
            foreach(var b in data)
            {
                var bs = new BagageSpace();
                var info = b.Descendants("Bagage");
                foreach(var item in info)
                {
                    bs.Add(new Bagage() { Id = (int)item.Element("Id"), Weight = (int)item.Element("Weight") });
                }
                bagageSpaces.Add(bs);
            }

            return bagageSpaces;
        }

        public IEnumerable<BagageSpace> DeSerializeJSON(string fileName)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<BagageSpace>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var newColl = jsonFormatter.ReadObject(fs) as List<BagageSpace>;
                return newColl;
            }
        }

        public IEnumerable<BagageSpace> DeSerializeXML(string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<BagageSpace>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var newColl = formatter.Deserialize(fs) as List<BagageSpace>;
                return newColl;
            }
        }

        public void SerializeByLINQ(IEnumerable<BagageSpace> collection, string fileName)
        {
            var file = new FileInfo(fileName);
            if (file.Exists)
                file.Delete();
            var data = new List<string>();
            foreach (var b in collection)
            {
                data.Add("<BagageSpace>");
                foreach(var item in b.GetCollection())
                {
                    data.Add(new XElement("Bagage",
                            new XElement("Id", item.Id.ToString()),
                            new XElement("Weight", item.Weight.ToString())
                            ).ToString());
                }
                data.Add("</BagageSpace>");
            }
            data.Insert(0, "<BagageSpaces>");
            data.Add("</BagageSpaces>");
            File.WriteAllLines(fileName, data);
        }

        public void SerializeJSON(IEnumerable<BagageSpace> collection, string fileName)
        {
            var file = new FileInfo(fileName);
            if (file.Exists)
                file.Delete();
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<BagageSpace>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, collection);
            }
        }

        public void SerializeXML(IEnumerable<BagageSpace> collection, string fileName)
        {
            var file = new FileInfo(fileName);
            if (file.Exists)
                file.Delete();
            XmlSerializer formatter = new XmlSerializer(typeof(List<BagageSpace>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, collection);
            }
        }
    }
}
