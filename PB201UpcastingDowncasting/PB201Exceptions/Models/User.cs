namespace PB201Exceptions.Models;

public class User : IAccount
{
    private static int _counter;

    public int Id { get; private set; }
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    static User()
    {
        _counter = 0;
    }

    public User()
    {
        _counter++;
        Id = _counter;
    }

    public User(string email, string password) : this()
    {
        Email = email;
        Password = password;
    }

    public bool PasswordChecker(string password)
    {
        if (!string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
            if (password.Length >= 8)
                if (char.IsUpper(password[0]))
                    if (password.Any(char.IsDigit))
                        if (password.Any(char.IsPunctuation))
                            return true;

        return false;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Id} - {Fullname} - {Email}");
    }
}
