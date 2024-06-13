using ClassTask.Helpers;
using ClassTask.Models;
namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = null;

            Console.WriteLine("Enter username");
            string userName = Console.ReadLine();
            string? password = null;
            do
            {
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
            } while (!Helper.CheckPassword(password)); // Salam123@


            password = "Salam"; // Salam
            user1 = new User(userName,password);
            
            Console.WriteLine(user1.Password);
        }
    }
}
