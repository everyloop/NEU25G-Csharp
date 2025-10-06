namespace L031_Library;

public static class StringExtensions
{
    public static int CountWords(this string text)
    {
        return text.Split(' ').Length;
    }
}
