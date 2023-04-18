using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFormLibrary
{
    internal interface IDataGridSerializable
    {
        int GetId();
        int GetFieldCount();
    }
}
