using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_15_opgaver
{
    public interface IPersistable
    {
        void Save(string fileName);
        void Load(string fileName);
    }
}
