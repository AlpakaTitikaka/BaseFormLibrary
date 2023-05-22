namespace BaseFormLibrary
{
    /// <summary>
    /// Помощь, кэп
    /// </summary>
    public static class Help
    {
        /// <summary>
        /// В Form_Load нужно записать:
        /// <code>
        ///     authorization1.SelectForm = SelectF;
        ///     authorization1.LoginPasswordCheck = Session.Start;
        /// </code>
        /// </summary>
        public static int Authorization { get; set; }
        /// <summary>
        /// Внутри класса Session:
        /// <code>
        ///     public static user User { get; set; }
        ///
        ///     public static bool Start(string login, string password)
        ///     {
        ///         using (ShoeShop db = new ShoeShop())
        ///             User = db.user.SingleOrDefault(u => u.login == login <![CDATA[&&]]> u.password == password);
        ///             return User != null;
        ///     }
        ///
        ///     public static void End()
        ///     {
        ///         User = null;
        ///     }
        /// </code>
        /// </summary>
        public static int Session { get; set; }
        /// <summary>
        /// Метод для открытия одной из нескольких форм, который пишется после public Form1() в Form1
        /// <code>
        ///     private Form SelectF()
        ///     {
        ///         if (Session.User.rang == 1)
        ///            return new Form2(this);
        ///         if (Session.User.rang == 2)
        ///             return new Form3(this);
        ///         return new Form4(this);
        ///     }
        /// </code>
        /// </summary>
        public static int SelectForm_Many { get; set; }
        /// <summary>
        /// Метод для открытия одной единственной формы, который пишется после public Form1() в Form1
        /// <code>
        ///     private Form SelectF()
        ///     {
        ///         return new Form2(this);
        ///     }
        /// </code>
        /// </summary>
        public static int SelectForm_One { get; set; }
        /// <summary>
        /// В Form2 нужно написать:
        /// <code>
        ///     Form1 auth;
        ///     public Form2(Form1 auth)
        ///     {
        ///         this.auth = auth;
        ///     }
        ///     
        ///     private void Form2_Closing(...)
        ///     {
        ///         auth.Show();
        ///         Session.End();
        ///     }
        /// </code>
        /// </summary>
        public static int NewForm { get; set; }
        /// <summary>
        /// Создание штрих-кода:
        /// <code>
        ///     Barcode b = new Barcode("12345");
        /// </code>
        /// Изменение содержания:
        /// <code>
        ///     b.Change("54321");
        /// </code>
        /// Вывод на форму с помощью PictureBox:
        /// <code>
        ///     pictureBox1.BackgroundImage = b.GetInImage();
        /// </code>
        /// Сохранение штрих-кода в PDF в папку bin\Debug:
        /// <code>
        ///     b.ImportInPdf(Directory.GetCurrentDirectory() + "\\1.pdf");
        /// </code>
        /// Получение текста из штрих-кода:
        /// <code>
        ///     string barcodeText = b.Text;
        /// </code>
        /// </summary>
        public static int Barcode { get; set; }
    }
}
