using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4progsem3
{
    public interface IFileService<T>
    {
        IEnumerable<T> ReadFile(string fileName);
        void SaveData(IEnumerable<T> data, string fileName);
    }
}
