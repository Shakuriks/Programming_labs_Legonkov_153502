using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab5prog.Domain
{
    [Serializable]
    [DataContract]
    public class Bagage
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Weight { get; set; }
    }
}
