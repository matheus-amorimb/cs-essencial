string name = "Matheus";

string reversedString = name.ReverseString();

Console.WriteLine(reversedString);

public static class StringExtensions
{
    public static string ReverseString(this string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}