using System;
using System.Drawing;

namespace BusinessLib.Security.Error
{
    public class Captcha
    {
        private string text;
        private Bitmap puzzle;

        public Captcha(int Width, int Height, int maxValue)
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
            GenerateText(maxValue);
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

        public Bitmap Get() => puzzle;

        public bool Check(string answer) => text.Equals(answer);

        public void GenerateText(int maxValue)
        {
            Random random = new Random();
            string allChars = "1qwx2erc3tyv4uib5opn6asm7df8gh9jk0lz";
            text = "";
            for (int i = 0; i < maxValue; i++)
                text += allChars[random.Next(allChars.Length)];
        }
    }
}
