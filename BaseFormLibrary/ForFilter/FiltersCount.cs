namespace BaseFormLibrary.ForFilter
{
    public enum FiltersCount
    {
        None,
        One,
        Two, 
        Three
    }

    public class Filters
    {
        public static int GetNumber (FiltersCount count)
        {
            if (count == FiltersCount.One)
                return 1;
            if (count == FiltersCount.Two)
                return 2;
            if (count  == FiltersCount.Three)
                return 3;
            return 0;
        }

        public static FiltersCount GetEnum (int count)
        {
            if (count == 1)
                return FiltersCount.One;
            if (count == 2)
                return FiltersCount.Two;
            if (count == 3)
                return FiltersCount.Three;
            return FiltersCount.None;
        }
    }
}
