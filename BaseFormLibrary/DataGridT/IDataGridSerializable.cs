﻿namespace BaseFormLibrary.DataGridT
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDataGridSerializable
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
