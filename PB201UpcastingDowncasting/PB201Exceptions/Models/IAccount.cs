namespace PB201Exceptions.Models;

public interface IAccount
{
    bool PasswordChecker(string password);
    void ShowInfo();
}
