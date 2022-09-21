using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5progsem3.Domain
{
    public interface ISerializer<RailwayStation>
    {
        IEnumerable<RailwayStation> DeSerializeByLINQ(string fileName);
        IEnumerable<RailwayStation> DeSerializeXML(string fileName);
        IEnumerable<RailwayStation> DeSerializeJSON(string fileName);
        void SerializeByLINQ(IEnumerable<RailwayStation> collection, string fileName);
        void SerializeXML(IEnumerable<RailwayStation> collection, string fileName);
        void SerializeJSON(IEnumerable<RailwayStation> collection, string fileName);
    }
}
