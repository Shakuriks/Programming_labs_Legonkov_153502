using Lab5progsem3.Domain;
using System.Xml.Serialization;

namespace Serializer
{
    public class Serializer : ISerializer
    {
        public IEnumerable<Bagage?> DeSerializeByLINQ(string fileName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bagage?> DeSerializeJSON(string fileName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bagage?> DeSerializeXML(string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(IEnumerable<RailwayStation>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                yield return formatter.Deserialize(fs) as Bagage;
            }
        }

        public void SerializeByLINQ(IEnumerable<Bagage> collection, string fileName)
        {
            throw new NotImplementedException();
        }

        public void SerializeJSON(IEnumerable<Bagage> collection, string fileName)
        {
            throw new NotImplementedException();
        }

        public void SerializeXML(IEnumerable<Bagage> collection, string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(IEnumerable<Bagage>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, collection);
            }
        }
    }
}