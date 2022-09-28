using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5prog.Domain
{
    public interface ISerializer
    {
        IEnumerable<BagageSpace> DeSerializeByLINQ(string fileName);
        IEnumerable<BagageSpace> DeSerializeXML(string fileName);
        IEnumerable<BagageSpace> DeSerializeJSON(string fileName);
        void SerializeByLINQ(IEnumerable<BagageSpace> collection, string fileName);
        void SerializeXML(IEnumerable<BagageSpace> collection, string fileName);
        void SerializeJSON(IEnumerable<BagageSpace> collection, string fileName);
    }
}
