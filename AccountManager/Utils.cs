namespace AccountManager
{
    public static class Utils
    {
        public static string ReadNotNullableLine(string text)
        {
            if (string.IsNullOrWhiteSpace(text) != true)
            {
                return text;
            }
            throw new InvalidOperationException("You have invalid date");
        }
    }
}
