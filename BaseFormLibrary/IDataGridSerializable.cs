using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFormLibrary
{
    
    internal interface IDataGridSerializable
    {
        /// <summary>
        ///  Метод, который возвращает ID 
        /// </summary>
        int GetId();
        /// <summary>
        ///  Метод, который возвращает количество свойств, которые должны изменятся в DataGridView, не считая ID
        /// </summary>
        int GetFieldCount();
    }
}
