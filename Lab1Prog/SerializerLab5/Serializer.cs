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
        public IEnumerable<Bagage> DeSerializeByLINQ(string fileName)
        {
            var bagagesData = XElement.Load(fileName);
            var newCollection = new BagageSpace();
            var data = bagagesData.Descendants("Bagage");
            foreach(var b in data)
            {
                newCollection.Add(new Bagage() { Id = (int)b.Element("Id"), Weight = (int)b.Element("Weight") });
            }

            return newCollection;
        }

        public IEnumerable<Bagage> DeSerializeJSON(string fileName)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(BagageSpace));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var newColl = jsonFormatter.ReadObject(fs) as BagageSpace;
                return newColl;
            }
        }

        public IEnumerable<Bagage> DeSerializeXML(string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(BagageSpace));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var newColl = formatter.Deserialize(fs) as BagageSpace;
                return newColl;
            }
        }

        public void SerializeByLINQ(IEnumerable<Bagage> collection, string fileName)
        {
            var file = new FileInfo(fileName);
            if (file.Exists)
                file.Delete();
            var data = new List<string>();
            foreach (var b in collection)
            {
                data.Add(new XElement("Bagage",
                                new XElement("Id", b.Id.ToString()),
                                new XElement("Weight", b.Weight.ToString())
                                ).ToString());
            }
            data.Insert(0, "<BagageSpace>");
            data.Add("</BagageSpace>");
            File.WriteAllLines(fileName, data);
        }

        public void SerializeJSON(IEnumerable<Bagage> collection, string fileName)
        {
            var file = new FileInfo(fileName);
            if (file.Exists)
                file.Delete();
            var jsonFormatter = new DataContractJsonSerializer(typeof(BagageSpace));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, collection);
            }
        }

        public void SerializeXML(IEnumerable<Bagage> collection, string fileName)
        {
            var file = new FileInfo(fileName);
            if (file.Exists)
                file.Delete();
            XmlSerializer formatter = new XmlSerializer(typeof(BagageSpace));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, collection);
            }
        }
    }
}
