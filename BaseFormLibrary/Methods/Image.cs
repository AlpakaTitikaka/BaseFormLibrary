using System.Drawing;
using System.IO;
using System.Linq;

namespace BaseFormLibrary.Methods
{
    /// <summary>
    /// Класс для работы с изображениями
    /// </summary>
    public static class Image
    {
        /// <summary>
        /// Создает файл в указанном пути
        /// </summary>
        /// <param name="filename">Путь к файлу (включая имя)</param>
        /// <param name="data">Массив байт, который будет записываться в файл</param>
        public static void Create(string filename, byte[] data)
        {
            File.WriteAllBytes(filename, data);
        }
        /// <summary>
        /// Выделяет массив байт из файла
        /// </summary>
        /// <param name="filename">Полное имя файла</param>
        /// <returns>Массив байт</returns>
        public static byte[] GetBytes(string filename)
        {
            if (File.Exists(filename))
                return File.ReadAllBytes(filename);
            return null;
        }
        /// <summary>
        /// Выделяет короткое имя файла (только имя и расширение)
        /// </summary>
        /// <param name="filename">Полный путь к файлу</param>
        /// <returns>Короткое имя файла</returns>
        public static string GetShortFileName(string filename)
        {
            if (filename.Contains("\\"))
                return string.Concat(filename.Skip(filename.LastIndexOf("\\") + 1));
            return filename;
        }
        /// <summary>
        /// Позволяет получить изображение из массива байт
        /// </summary>
        /// <param name="data">Массив байт</param>
        /// <returns>Изображение Bitmap</returns>
        public static Bitmap Get(byte[] data)
        {
            return new Bitmap(new MemoryStream(data));
        }
    }
}
