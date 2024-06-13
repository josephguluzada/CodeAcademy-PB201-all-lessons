namespace PB201Generic.Helpers;

public static class Helper
{
    public static bool CheckFullname(string value) // "Eli Poladov"
    {
        value = value.Trim();
        string[] values = value.Split(" ");

        if (values.Length != 2)
        {
            return false;
        }

        foreach (var part in values)
        {
            if (!part.Any(char.IsLetter)) return false;
            if (!char.IsUpper(part[0])) return false;

            for (int i = 1; i < part.Length; i++)
            {
                if (!char.IsLower(part[i])) return false;
            }

        }
        return true;
    }
}
