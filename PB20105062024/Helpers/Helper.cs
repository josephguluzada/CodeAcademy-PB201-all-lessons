namespace Helpers;

public class Helper
{
    public static string CreateBookCode(string name, int id)
    {
        string code  = name.ToUpper().Substring(0, 2) + id;

        return code;
    }
}
