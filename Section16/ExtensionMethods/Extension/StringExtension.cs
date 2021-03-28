namespace System
{
    static class StringExtension
    {
        public static string Cut(this String thisObj, int limit)
        {
            if (thisObj.Length <= limit)
                return thisObj.ToString();

            return thisObj.Substring(0, limit).TrimEnd() + "...";
        }
    }
}
