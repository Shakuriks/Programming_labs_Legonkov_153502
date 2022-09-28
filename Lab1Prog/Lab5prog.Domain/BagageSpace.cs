using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab5prog.Domain
{
    [Serializable]
    [DataContract]
    public class BagageSpace:IEnumerable<Bagage>
    {
        [DataMember]
        List<Bagage> bagages = new List<Bagage>();
        public BagageSpace() { }
        public BagageSpace(List<Bagage> bagages)
        {
            this.bagages = bagages;
        }

        public List<Bagage> GetCollection()
        {
            return bagages;
        }

        public void SetCollection(List<Bagage> coll)
        {
            bagages = coll;
        }

        public string Print()
        {
            var result = "";
            foreach(var b in bagages)
            {
                result += $"Id = {b.Id}, Weight = {b.Weight};\n";
            }
            return result;
        }

        public IEnumerator<Bagage> GetEnumerator()
        {
            return bagages.GetEnumerator();
        }

        public void Add(Bagage value)
        {
            bagages.Add(value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return bagages.GetEnumerator();
        }
    }
}
