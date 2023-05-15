using System;
using System.Drawing;

namespace BaseFormLibrary.Entering.Error
{
    /// <summary>
    /// Каптча
    /// </summary>
    public class Captcha
    {
        private string text;
        private Bitmap puzzle;
        private const string DIGITS = "1234567890";
        private const string ENG_LETTERS = "qwertyuiopasdfghjklzxcvbnm";
        private const string RUS_LETTERS = "йцукенгёшщзхъфывапролджэячсмитьбю";
        private const string DIG_RUS_LETTERS = "1йцук2енгё3шщз4хъфы5вап6рол7джэ8ячс9мить0бю";
        private const string DIG_ENG_LETTERS = "1qwe2rty3uio4pas5dfg6hjk7lzx8cvb9nm0";

        /// <summary>
        /// Каптча
        /// </summary>
        public Captcha(int Width, int Height, int maxValue, Chars chars)
        {
            puzzle = new Bitmap(Width, Height);
            Brush[] TextColors = {
                Brushes.Black,
                Brushes.White
            };
            Pen[] LineColors = {
                Pens.Red,
                Pens.Green
            };
            FontStyle[] TextFonts = {
                FontStyle.Bold,
                FontStyle.Italic,
                FontStyle.Strikeout
            };
            int[] TextRotates = {
                1, -1,
                2, -2,
                3, -3,
                4, -4,
                5, -5,
                6, -6
            };
            Random random = new Random();
            Graphics Canvas = Graphics.FromImage(puzzle);
            Canvas.Clear(Color.Gray);
            Canvas.RotateTransform(TextRotates[random.Next(TextRotates.Length)]);
            GenerateText(maxValue,chars);
            Canvas.DrawString(text,
                new Font(new FontFamily("Arial"),
                40,
                TextFonts[random.Next(TextFonts.Length)]),
                TextColors[random.Next(TextColors.Length)],
                new PointF(10, 10)
            );
            Canvas.DrawLine(
                LineColors[random.Next(LineColors.Length)],
                new Point(0, 0),
                new Point(Width - 1, Height - 1)
            );
            Canvas.DrawLine(
                LineColors[random.Next(LineColors.Length)],
                new Point(0, Height - 1),
                new Point(Width - 1, 0)
            );
            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                    if (random.Next() % 20 == 0)
                        puzzle.SetPixel(x, y, Color.Aqua);
        }
        /// <summary>
        /// Получить изображение каптчи
        /// </summary>
        /// <returns>Каптча</returns>
        public Bitmap Get() => puzzle;
        /// <summary>
        /// Проверка верности введенного кода с картинки
        /// </summary>
        /// <param name="answer">Ответ</param>
        /// <returns>Верно ли введена каптча</returns>
        public bool Check(string answer) => text.Equals(answer);

        private string SetChars(Chars chars)
        {
            if (chars == Chars.OnlyEnLetters)
                return ENG_LETTERS;
            if (chars == Chars.OnlyRusLetters)
                return RUS_LETTERS;
            if (chars == Chars.OnlyDigits)
                return DIGITS;
            if (chars == Chars.EnLettersDigits)
                return DIG_ENG_LETTERS;
            if (chars == Chars.RusLettersDigits)
                return DIG_RUS_LETTERS;
            return DIG_ENG_LETTERS;
        }
        /// <summary>
        /// Генерация текста на каптче
        /// </summary>
        /// <param name="maxValue">Максимальное количество символов</param>
        /// <param name="chars">Какие символы будут использоваться</param>
        public void GenerateText(int maxValue, Chars chars)
        {
            Random random = new Random();
            string allChars = SetChars(chars);
            text = "";
            for (int i = 0; i < maxValue; i++)
                text += allChars[random.Next(allChars.Length)];
        }
    }
}
