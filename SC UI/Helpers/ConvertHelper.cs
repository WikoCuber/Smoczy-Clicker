namespace SC_UI.Helpers
{
    public static class ConvertHelper
    {
        //Convert Keys to string
        public static string KeysToString(Keys key)
        {
            string result = key.ToString();
            if (result.Length == 2 && result.Contains('D'))
                result = result[1].ToString();

            return result;
        }
    }
}
