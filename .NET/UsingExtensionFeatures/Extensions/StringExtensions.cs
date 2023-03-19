namespace StringExtensionFeatures
{
    public static class StringExtensions
    {
        public static int FindWordIndex(this string sentence, string wordToFind)
        {
            int indexFound = sentence.IndexOf(wordToFind);
            return indexFound;
        }
    }
}