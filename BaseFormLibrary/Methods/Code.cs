using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseFormLibrary.Methods
{
    /// <summary>
    /// Класс для работы с кодами для получения заказа
    /// </summary>
    public static class Code
    {
        /// <summary>
        /// Генерировать код
        /// </summary>
        /// <param name="numCount">Количество чисел в коде</param>
        /// <param name="codes">Список существующих кодов</param>
        /// <returns>Код, не существующий с списке</returns>
        public static string Generate(int numCount, List<string> codes)
        {
            Random random = new Random();
            int code = random.Next(0, 10 * numCount);
            if (codes.Count > 0)
            {
                while (codes.Any(c => c.Equals(code.ToString())))
                {
                    code = random.Next(0, 10 * numCount);
                }
            }
            return code.ToString();
        }
    }
}
