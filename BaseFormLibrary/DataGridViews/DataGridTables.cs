using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BaseFormLibrary.DataGridViews
{
    /// <summary>
    /// Класс, предоставляющий готовые методы для добавления, удаления и редактирования DataGridView данных.
    /// Класс модели базы данных, который используется в таблице, обязательно должен быть наследован от IDataGridSerializable.
    /// !!! ДЛЯ РАБОТЫ РЕДАКТИРОВАНИЯ названия полей классов и названия столбцов должны быть одинаковые !!!
    /// </summary>
    public class DataGridTables<T, K>
        where T : IDataGridSerializable 
        where K : DbContext
    {
        /// <summary>
        /// Метод для добавления новых строк. . Можете спокойно копировать код ниже
        /// <example>
        /// <code>
        ///     dtb.addRow(dataGridView1[0, e.Row.Index - 1]);
        /// </code>
        /// </example>
        /// </summary>
        public void AddRow(DataGridViewCell cell)  {
            using (K db = Activator.CreateInstance<K>())
            {
                var obj = Activator.CreateInstance<T>();
                db.Set(typeof(T)).Add(obj);
                db.SaveChanges();
                cell.Value = obj.GetId();
            }
        }
        /// <summary>
        /// Метод для добавления удаления строк. Можете спокойно копировать код ниже
        /// <example>
        /// <code>
        ///     dtb.deleteRow((int)e.Row.Cells[0].Value);
        /// </code>
        /// </example>
        /// </summary>
        public void DeleteRow(int id) {
            using (K db = Activator.CreateInstance<K>())
            {
                T obj = (T)db.Set(typeof(T)).Find(id);
                db.Set(typeof(T)).Remove(obj);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Метод для добавления редактирования строк. Можете спокойно копировать код ниже. 
        /// !!! ДЛЯ РАБОТЫ РЕДАКТИРОВАНИЯ названия полей классов и названия столбцов должны быть одинаковые !!!
        /// <example>
        /// <code>
        ///     dtb.editRow(ref dataGridView1, e.RowIndex);
        /// </code>
        /// </example>
        /// </summary>
        public void EditRow(ref DataGridView dataGridView, int row) {
            using (K db = Activator.CreateInstance<K>())
            {
                T obj = (T)db
                    .Set(typeof(T))
                    .Find((int)dataGridView[0, row].Value);
                object boxed = obj;
                var fieldsInfo = typeof(T).GetRuntimeFields();
                for (int i = 1; i <= obj.GetFieldCount(); i++)
                {
                    if (dataGridView[i, row].Value != null)
                    {
                        string name = dataGridView.Columns[i].HeaderText;
                        object value = dataGridView[i, row].Value.ToString();
                        if (dataGridView.Columns[i].GetType() == typeof(DataGridViewComboBoxColumn))
                        {
                            value = (dataGridView[i, row].Value as IDataGridSerializable).GetId();
                        }

                        fieldsInfo
                            .SingleOrDefault(field =>
                                field.Name
                                .Replace("_", "")
                                .ToLower()
                                .Contains(name.Replace(" ", "").ToLower()))
                            .SetValue(boxed, value);
                    }
                }
                T z = (T)boxed;
                db.SaveChanges();
            }
        }

        
    }
}
