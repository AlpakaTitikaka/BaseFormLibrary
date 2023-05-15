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
    }
}
