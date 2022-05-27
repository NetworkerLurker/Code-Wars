using System;
public class Kata
{
    public static string FindNeedle(object[] haystack)
    {
        int needleIndex = Array.IndexOf(haystack, "needle");
        string successMessage = "found the needle at position " + needleIndex.ToString();
        return successMessage;
    }
}