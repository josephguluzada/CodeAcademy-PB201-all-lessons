namespace PB201StaticExtensions;

public static class StringExtensions
{
    public static string Capitalize(this string str)
    {
        string newStr = string.Empty; // ""
        for (int i = 0; i < str.Length; i++)
        {
            if (i == 0)
            {
                newStr += char.ToUpper(str[i]);
            }
            else
            {
                newStr += char.ToLower(str[i]);
            }
        }

        return newStr;
    }

    public static int Sum(this int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Sum(this int number1, int number2, int number3)
    {
        return number1 + number2 + number3;
    }
}
