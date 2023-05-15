using System.Data.Entity;
using System.Linq;

namespace BaseFormLibrary.Methods
{
    /// <summary>
    /// Класс для работы с кодом
    /// </summary>
    public static class Id
    {
        /// <summary>
        /// Получает следующий код для новой строки
        /// </summary>
        /// <param name="db">База данных</param>
        /// <param name="tableName">Имя таблицы</param>
        /// <returns>Код для следующей строки</returns>
        public static int GetNext(DbContext db, string tableName)
        {
            return db.Database.SqlQuery<int>($"select max(0) from {tableName}").SingleOrDefault() + 1;            
        }
        /// <summary>
        /// Получает слудующий код из составного номера
        /// </summary>
        /// <param name="db">База данных</param>
        /// <param name="tableName">Имя таблицы</param>
        /// <param name="subNumSplit">Разделитель номера</param>
        /// <returns>Код следующей строки</returns>
        public static string GetNextNum(DbContext db, string tableName, string subNumSplit)
        {
            string result = db.Database.SqlQuery<string>($"select max(0) from {tableName}").SingleOrDefault();
            result = result.Substring(0, result.IndexOf(subNumSplit));
            return (int.Parse(result) + 1).ToString();
        }
    }
}
