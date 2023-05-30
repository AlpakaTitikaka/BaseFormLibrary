using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BaseFormLibrary.DataGridT
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
        ///     dtb.AddRow(dataGridView1[0, e.Row.Index - 1]);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="cell">Нулевая ячейка таблицы</param>
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
        ///     dtb.DeleteRow((int)e.Row.Cells[0].Value);ы
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="id">ID элемента</param>
        public void DeleteRow(int id) {
            using (K db = Activator.CreateInstance<K>())
            {
                T obj = (T)db.Set(typeof(T)).Find(id);
                db.Set(typeof(T)).Remove(obj);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Редактирование строки через таблицу.Можете спокойно копировать код ниже. 
        /// !!! ДЛЯ РАБОТЫ РЕДАКТИРОВАНИЯ названия полей классов и названия столбцов (Name) должны быть одинаковые !!!
        /// <code>
        ///     dtb.EditRow(ref dataGridView1, e.RowIndex);
        /// </code>
        /// </summary>
        /// <param name="dataGridView">Таблица</param>
        /// <param name="row">Номер строки</param>
        public void EditRow(ref DataGridView dataGridView, int row)
        {
            using (K db = Activator.CreateInstance<K>())
            {
                T obj = (T)db
                    .Set(typeof(T))
                    .Find((int)dataGridView[0, row].Value);
                object boxed = obj;
                var fieldsInfo = typeof(T).GetRuntimeFields();
                for(int i = 1; i <= obj.GetFieldCount(); i++)
                {
                    if (dataGridView[i, row].Value != null)
                    {
                        string name = dataGridView.Columns[i].Name;
                        object value = dataGridView[i, row].Value;
                        if (dataGridView.Columns[i].GetType() == typeof(DataGridViewComboBoxColumn))
                        {
                            value = (dataGridView.Columns[i] as DataGridViewComboBoxColumn)
                                .Items.IndexOf(value) + 1;
                        }

                        var fieldInfo = fieldsInfo
                            .SingleOrDefault(f =>
                                f.Name
                                .Replace("_", "")
                                .ToLower()
                                .Contains(name.Replace(" ", "").ToLower()));

                        if (fieldInfo.FieldType.Equals(typeof(int)))
                        {
                            fieldInfo.SetValue(boxed, value);
                        }
                        if (fieldInfo.FieldType.Equals(typeof(double)))
                        {
                            fieldInfo.SetValue(boxed, double.Parse((string)value));
                        }
                        if (fieldInfo.FieldType.Equals(typeof(string)))
                        {
                            fieldInfo.SetValue(boxed, value);
                        }
                        if (fieldInfo.FieldType.Equals(typeof(DateTime)))
                        {
                            fieldInfo.SetValue(boxed, (DateTime)value);
                        }
                    }
                    db.SaveChanges();
                }
            }
        }
    }
}
