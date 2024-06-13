namespace ClassTask.Helpers;

public static class Helper
{
    public static bool CheckPassword(string password)
    {
        if (!string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            if (password.Length >= 8)
                if (char.IsUpper(password[0]))
                    if (password.Any(char.IsDigit))
                        if (password.Any(char.IsPunctuation))
                            return true;

        return false;
    }
}
