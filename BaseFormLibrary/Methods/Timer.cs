namespace BaseFormLibrary.Methods
{
    /// <summary>
    /// Класс для работы таймером (пользователя)
    /// </summary>
    public class Timer
    {
        /// <summary>
        /// Строка формата время
        /// </summary>
        public string TimeString { get; set; }
        /// <summary>
        /// Счетчик времени
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// Конструктор таймера
        /// </summary>
        public Timer()
        {
            Clear();
        }

        private string formatTime(int time)
           => time > 9 ? time.ToString() : $"0{time}";

        private void setTime()
        {
            TimeString = $"{formatTime(Time / 3600)}:{formatTime(Time / 60)}:{formatTime(Time % 60)}";
        }
        /// <summary>
        /// Добавление времени (по умолчанию 1)
        /// </summary>
        /// <returns>Строка времени</returns>
        public string AddTime()
        {
            Time++;
            setTime();
            return TimeString;
        }
        /// <summary>
        /// Добавление времени
        /// </summary>
        /// <param name="time">Количество времени</param>
        /// <returns>Строка времени</returns>
        public string AddTime(int time)
        {
            Time += time;
            setTime();
            return TimeString;
        }
        /// <summary>
        /// Очистка таймера
        /// </summary>
        public void Clear()
        {
            Time = 0;
            TimeString = "00:00:00";
        }
    }
}
