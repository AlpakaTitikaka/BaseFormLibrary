namespace BaseFormLibrary.Methods
{
    /// <summary>
    /// Класс для работы с ценой
    /// </summary>
    public static class Price
    {
        /// <summary>
        /// Посчитать цену со скидкой (скидка в промежутке от 0 до 1)
        /// </summary>
        /// <param name="price">Цена</param>
        /// <param name="discount">Скидка</param>
        /// <returns>Цена со скидкой</returns>
        public static double WithDiscount(double price, double discount)
        {
            return price * (1 - discount);
        }
        /// <summary>
        /// Посчитать цену со скидкой (скидка в промежутке от 0 до 100)
        /// </summary>
        /// <param name="price">Цена</param>
        /// <param name="discount">Скидка</param>
        /// <returns>Цена со скидкой</returns>
        public static double WithDiscount(double price, int discount)
        {
            return price * (1 - discount / 100);
        }
        /// <summary>
        /// Посчитать цену без скидки
        /// </summary>
        /// <param name="priceWithDiscount">Цена со скидкой</param>
        /// <param name="discount">Скидка (от 0 до 1)</param>
        /// <returns>Чистая цена без скидки</returns>
        public static double WithoutDiscount(double priceWithDiscount, double discount)
        {
            return priceWithDiscount / (1 - discount);
        }
        /// <summary>
        /// Посчитать цену без скидки
        /// </summary>
        /// <param name="priceWithDiscount">Цена со скидкой</param>
        /// <param name="discount">Скидка (от 0 до 100)</param>
        /// <returns>Чистая цена без скидки</returns>
        public static double WithoutDiscount(double priceWithDiscount, int discount)
        {
            return priceWithDiscount / (1 - discount / 100);
        }
        /// <summary>
        /// Посчитать скидку
        /// </summary>
        /// <param name="priceWithDiscount">Цена со скидкой</param>
        /// <param name="realPrice">Цена без скидки</param>
        /// <returns>Скидка</returns>
        public static double GetDiscount(double priceWithDiscount, double realPrice)
        {
            return (1 - priceWithDiscount / realPrice);
        }
    }
}
