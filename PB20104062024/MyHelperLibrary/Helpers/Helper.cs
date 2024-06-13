namespace MyHelperLibrary.Helpers;

public static class Helper
{
    public static bool PasswordChecker(string password)
    {
        if (!string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            if (password.Length >= 8)
                if (char.IsUpper(password[0]))
                    if (password.Any(char.IsDigit))
                        if (password.Any(char.IsPunctuation))
                            return true;

        return false;
    }

    public static bool CheckGroupNo(string groupNo)
    {
        if (!string.IsNullOrEmpty(groupNo) && groupNo.Length == 5)
            if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                return true;
        return false;
    }

    public static void AddItemIntoArray<T>(ref T[] array, T item)
    {
        Array.Resize(ref array, array.Length + 1);
        array[^1] = item;
    }

    public static void SayHello()
    {
        Console.WriteLine("Hello");
    }
}
