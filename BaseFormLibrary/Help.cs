namespace BaseFormLibrary
{
    /// <summary>
    /// Помощь, кэп
    /// </summary>
    public static class Help
    {
        /// <summary>
        /// Авторизация пользователя
        /// При неудачной попытке появляется каптча
        /// <para>ВНИМАНИЕ!!!</para>
        /// 1. Не работает, если не введены параметры следующей формы и проверки подлинности логина и пароля
        /// <para>
        /// 2. После авторизации форма на которой был контрол скрывается (Hide()), а новая форма открывается (Show())
        /// </para>
        /// Советую в UserForm передавать форму, на которой находится контрол (Например: new ManagerForm(this)), затем при закрытии UserForm открывать форму с контролом (AuthForm.Show())
        /// </summary>
        public static int Authorization { get; set; }
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
        ///     }
        /// </code>
        /// </summary>
        public static int NewForm { get; set; }

    }
}
