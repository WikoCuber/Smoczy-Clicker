namespace SC_Data
{
    public static class DataProvider
    {
        private static Data _data = default!;
        public static Data Get() => _data;
        public static void Set(Data data) => _data = data;
    }
}
