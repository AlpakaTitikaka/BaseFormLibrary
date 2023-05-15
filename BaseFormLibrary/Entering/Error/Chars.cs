namespace BaseFormLibrary.Entering.Error
{
    /// <summary>
    /// Символы в каптче
    /// </summary>
    public enum Chars
    {
        /// <summary>
        /// Любые
        /// </summary>
        Any,
        /// <summary>
        /// Только цифры
        /// </summary>
        OnlyDigits,
        /// <summary>
        /// Только английские буквы
        /// </summary>
        OnlyEnLetters,
        /// <summary>
        /// Только русские буквы
        /// </summary>
        OnlyRusLetters,
        /// <summary>
        /// Русские буквы и цифры
        /// </summary>
        RusLettersDigits,
        /// <summary>
        /// Английские буквы и цифры
        /// </summary>
        EnLettersDigits
    }
}
