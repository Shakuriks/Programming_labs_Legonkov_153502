using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5prog.Domain
{
    [Serializable]
    public class BagageSpace:IEnumerable<Bagage>
    {
        List<Bagage> bagages = new List<Bagage>();
        public BagageSpace() { }
        public BagageSpace(List<Bagage> bagages)
        {
            this.bagages = bagages;
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
