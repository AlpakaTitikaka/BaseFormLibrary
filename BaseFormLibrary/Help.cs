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
        public static int _4_Authorization { get; set; }
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
        public static int _1_Session { get; set; }
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
        public static int _3_SelectForm_Many { get; set; }
        /// <summary>
        /// Метод для открытия одной единственной формы, который пишется после public Form1() в Form1
        /// <code>
        ///     private Form SelectF()
        ///     {
        ///         return new Form2(this);
        ///     }
        /// </code>
        /// </summary>
        public static int _3_SelectForm_One { get; set; }
        /// <summary>
        /// В Form2 нужно написать:
        /// <code>
        ///     Form1 auth;
        ///     public Form2(Form1 auth)
        ///     {
        ///         InitializeComponent();
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
        public static int _2_NewForm { get; set; }
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
        /// <summary>
        /// Заполнение таблицы, делаем через метод
        /// <code>
        ///     private void Fill(List<![CDATA[<]]>product<![CDATA[>]]> data)
        ///     {
        ///         dataGridView1.Rows.Clear();
        ///         foreach (var item in data)
        ///             dataGridView1.Rows.Add(item.id, item.name, item.price);
        ///     }
        /// </code>
        /// </summary>
        public static int DataGridView_Fill { get; set; }
        ///<summary>
        /// Чтобы заполнить таблицу данными из базы данных, пишем в событии Form2_Load(...):
        /// <code>
        ///     using (Model1 db = new Model1())
        ///     {
        ///         Fill(db.product.ToList());
        ///     }
        /// </code>
        /// </summary>
        public static int DataGridView_FillFromDataBase { get; set; }
        /// <summary>
        /// На любое такое изменение можно добавлять метод Fill() после того, как были внесены изменения в БД
        /// <code>
        ///     using (Model1 db = new Model1())
        ///     {
        ///         Fill(db.product.ToList());
        ///     }
        /// </code>
        /// </summary>
        public static int DataGridView_Add_Edit_Delete_Data { get; set; }
        /// <summary>
        /// На любое такое изменение можно добавлять метод Fill() после того, как были внесены изменения в БД
        /// <code>
        ///     using (Model1 db = new Model1())
        ///     {
        ///         Fill(searchString1.Search(db.product, p => p.name).ToList());
        ///     }
        /// </code>
        /// ИЛИ
        /// <code>
        ///     using (Model1 db = new Model1())
        ///     {
        ///         Fill(filter1.Filtering(db.product, p => p.category.title, p => p.price).ToList());
        ///     }
        /// </code>
        /// </summary>
        public static int DataGridView_Search_Filtering_Data { get; set; }
        /// <summary>
        /// Изменение данных в таблице и передача их в БД через событие CellEndEdit
        /// <code>
        ///     int id = (int)dataGridView1[0, e.RowIndex].Value;
        ///     using (Model1 db = new Model1())
        ///     {
        ///         if (e.ColumnIndex == 1)
        ///             db.product.Find(id).name = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
        ///         if (e.ColumnIndex == 2)
        ///             db.product.Find(id).price = int.Parse(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
        ///         db.SaveChanges();
        ///     }
        /// </code>
        /// </summary>
        public static int DataGridView_Edit_Data_DB { get; set; }
        /// <summary>
        /// Открытие новой формы (можно написать в кнопке)
        /// <code>
        ///     new Form3().Show();
        /// </code>
        /// </summary>
        public static int OpenForm { get; set; }
        /// <summary>
        /// Открытие новой формы без возможности влияния на старую (подойдет для окон создания и редактирования товара, сотрудника и тд)
        /// <code>
        ///     using (SotrEdit se = new SotrEdit())
        ///     {
        ///         if (se.ShowDialog(this) == DialogResult.OK)
        ///         {
        ///             MessageBox.Show("Сотрудник добавлен");
        ///             using (Model1 db = new Model1())
        ///             {   
        ///                 Fill(db.product.ToList());
        ///             }
        ///         }
        ///         se.Dispose();
        ///     }
        /// </code>
        /// </summary>
        public static int OpenForm_Dialog { get; set; }
        /// <summary>
        /// Заполнение выпадающего списка (Добавление наименований категорий в список)
        /// <para>
        /// Через цикл:
        /// </para>
        /// <code>
        ///     foreach (var item in db.category)
        ///     {
        ///         comboBox1.Items.Add(item.title);
        ///     }
        /// </code>
        /// В одну строчку:
        /// <code>
        ///     comboBox1.Items.AddRange(db.category.Select(c => c.title).ToArray());
        /// </code>
        /// </summary>
        public static int ComboBoxAddition { get; set; }
        /// <summary>
        /// Организация вывода данных в TextBox при переключении по элементам в ComboBox (По выбору услуги происходит вывод ее стоимости).
        /// <para>
        /// Создайте событие SelectedIndexChanged, а внутри напишите, например:
        /// </para>
        /// <code>
        ///     using (Model1 db = new Model1())
        ///     {
        ///         textBox1.Text = db.uslugi
        ///         .Single(u => u.title.Equals
        ///         (comboBox1.Items.SelectedItem.ToString()))
        ///         .price.ToString();
        ///     }
        /// </code>
        /// </summary>
        public static int ComboBoxOutput { get; set; }
        /// <summary>
        /// Добавление нового сотрудника (товара и тд) в базу данных лучше всего делать через новую форму (иначе много заморочек и того, что вам сложно запомнить).
        /// <para>
        /// Создайте новую форму и поместите на нее все нужные элементы (если есть что-то вроде категорий или видов, добавьте выпадающие списки).
        /// </para>
        /// Затем откройте событие Click кнопки добавления нового элемента (можно установить ее свойство DialogResult на OK, у кнопки отмена на Cancel) и напишите что-то наподобие этого:
        /// <code>
        ///     using (Mode1 db = new Model1())
        ///     {
        ///         product p = new product()
        ///         {
        ///             id = int.Parse(textBox1.Text), //код вводится пользователем
        ///             name = textBox2.Text,
        ///             price = double.Parse(textBox3.Text),
        ///             category = comboBox1.Items.SelectedIndex + 1 //код категории
        ///         };
        ///         db.product.Add(p);
        ///         db.SaveChanges();
        ///     }
        /// </code>
        /// Если код должен устанавливаться автоматически, нужно сначала написать метод:
        /// <code>
        ///     private int GetNextId()
        ///     {
        ///         using (Model1 db = new Model1())
        ///         {
        ///             if (db.product.ToList().Count() > 0)
        ///             {
        ///                 return db.product.Max(p => p.id) + 1;
        ///             }
        ///         }
        ///         return 1;
        ///     }
        /// </code>
        /// А в добавлении товара в строчке с id:
        /// <code>
        ///     id = GetNextId(),
        /// </code>    
        /// </summary>
        public static int NewElementCreation_Form { get; set; }
        /// <summary>
        /// Переход к добавлению или удалению строк в таблице (через контекстное меню).
        /// <para>
        /// Сначала добавьте компонент ContextMenuStrip на форму, затем подсоедините его к DataGridView (в свойстве ContextMenu).
        /// </para>
        /// В контекстном меню добавьте два элемента и в свойсте Text подпишите их "Добавить" и "Удалить". После чего, выберете ваше меню на панели, ниже формы, и дважды кликните по каждой кнопке.
        /// <para>
        /// Чтобы реализовать добавление, используйте подсказдку OpenForm или OpenForm_Dialog, а для получения подробностей по форме добавления NewElementCreation_Form.
        /// </para>
        /// Чтобы реализовать удаление, используйте код ниже:
        /// <code>
        ///     if (MessageBox.Show("Удалить?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
        ///     {
        ///         int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
        ///         using (Model1 db = new Model1())
        ///         {
        ///             db.product.Remove(db.product.Find(id));
        ///             db.SaveChanges();
        ///             MessageBox.Show("Позиция удалена");
        ///         }
        ///     }
        /// </code>
        /// </summary>
        public static int AddDelete_FromDataGridView { get; set; }
    }
}
