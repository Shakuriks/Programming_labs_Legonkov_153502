using Lab5progsem3.Domain;
using System.Xml.Serialization;

namespace Serializer
{
    public class Serializer : ISerializer<RailwayStation>
    {
        public IEnumerable<RailwayStation> DeSerializeByLINQ(string fileName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RailwayStation> DeSerializeJSON(string fileName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RailwayStation> DeSerializeXML(string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(IEnumerable<RailwayStation>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                yield return formatter.Deserialize(fs) as Bagage;
            }
        }

        public void SerializeByLINQ(IEnumerable<RailwayStation> collection, string fileName)
        {
            throw new NotImplementedException();
        }

        public void SerializeJSON(IEnumerable<RailwayStation> collection, string fileName)
        {
            throw new NotImplementedException();
        }

        public void SerializeXML(IEnumerable<RailwayStation> collection, string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(IEnumerable<RailwayStation>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, collection);
            }
        }
    }
}