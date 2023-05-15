using IronBarCode;
using System.Drawing;

namespace BaseFormLibrary.BarCodes
{
    /// <summary>
    /// Класс для работы со штрих-кодом
    /// </summary>
    public class Barcode
    {
        private GeneratedBarcode barcode { get; set; }
        /// <summary>
        /// Текст в штрих-коде
        /// </summary>
        public string Text
        {
            get => barcode.ToString(); 
            set => barcode = BarcodeWriter.CreateBarcode(value, BarcodeEncoding.Codabar);
        }
        /// <summary>
        /// Конструктор штрих-кода
        /// </summary>
        /// <param name="text">Строка, которую нужно закодировать</param>
        public Barcode(string text)
        {
            Change(text);
        }
        /// <summary>
        /// Изменение текста в штрих-коде
        /// </summary>
        /// <param name="text"></param>
        public void Change(string text)
        {
            Text = text;
        }
        /// <summary>
        /// Перевести штрих-код в изображение
        /// </summary>
        /// <returns>Штрих-код в виде изображения Bitmap</returns>
        public Bitmap GetInImage()
        {
            return barcode.Image.ToBitmap<Bitmap>();
        }
        /// <summary>
        /// Импорт штрих-кода в PDF
        /// </summary>
        /// <param name="filepath">Полный путь к файлу</param>
        public void ImportInPdf(string filepath)
        {
            barcode.SaveAsPdf(filepath);
        }
    }
}
