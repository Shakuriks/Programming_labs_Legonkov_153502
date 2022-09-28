using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5prog.Domain
{
    public interface ISerializer
    {
        IEnumerable<Bagage> DeSerializeByLINQ(string fileName);
        IEnumerable<Bagage> DeSerializeXML(string fileName);
        IEnumerable<Bagage> DeSerializeJSON(string fileName);
        void SerializeByLINQ(IEnumerable<Bagage> collection, string fileName);
        void SerializeXML(IEnumerable<Bagage> collection, string fileName);
        void SerializeJSON(IEnumerable<Bagage> collection, string fileName);
    }
}
