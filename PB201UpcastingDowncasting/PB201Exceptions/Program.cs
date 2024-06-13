using PB201Exceptions.Models;

namespace PB201Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = null;
            Console.WriteLine("Enter fullname");
            string fullName = Console.ReadLine();
            string password = null;
            bool isValid = true;
            do
            {
                if (isValid)
                {
                    Console.WriteLine("Enter your password");
                    password = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter valid password");
                    password = Console.ReadLine();
                }
                isValid = false;
            } while (!PasswordChecker(password));

            User user = new User();
            user.Fullname = fullName;
            user.Password = password;
            user.Email = "test@gmail.com";

            while (true)
            {
                Console.WriteLine("Operations:" +
                "\n1.Show Info" +
                "\n2.Create a group");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        user.ShowInfo();
                        break;
                    case 2:
                        string groupNo = null;
                        int minLimit = 0;
                        int maxLimit = 0;
                        do
                        {
                            Console.WriteLine("Enter group no");
                            groupNo = Console.ReadLine();

                        } while (!CheckGroupNo(groupNo));

                        do
                        {
                            Console.WriteLine("Enter min limit");
                            minLimit = int.Parse(Console.ReadLine());

                        } while (minLimit < 5);

                        do
                        {
                            Console.WriteLine("Enter max limit");
                            maxLimit = int.Parse(Console.ReadLine());

                        } while (maxLimit > 18);

                        group = CreateGroup(groupNo, maxLimit);


                        while (choice != 0)
                        {
                            Console.WriteLine("Operations:" +
                            "\n1.Show all students" +
                            "\n2.Get student by id" +
                            "\n3.Add student" +
                            "\n0.Quit");
                            choice = int.Parse(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    group.ShowAllStudents();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter student Id");
                                    int id = int.Parse(Console.ReadLine());

                                    Console.WriteLine(group.GetStudent(id));
                                    break;
                                case 3:
                                    string studentFullName = null;
                                    double point = 0;
                                    if (group.GetAllStudent().Length >= minLimit)
                                    {
                                        Console.WriteLine("Student fullname");
                                        studentFullName = Console.ReadLine();
                                        Console.WriteLine("Student point");
                                        point = double.Parse(Console.ReadLine());
                                        group.AddStudent(new Student(studentFullName, point));
                                    }
                                    else
                                    {
                                        for (int i = 0; i < minLimit; i++)
                                        {
                                            Console.WriteLine("Student fullname");
                                            studentFullName = Console.ReadLine();
                                            Console.WriteLine("Student point");
                                            point = double.Parse(Console.ReadLine());
                                            group.AddStudent(new Student(studentFullName, point));
                                        }
                                    }

                                   
                                    break;
                                default:
                                    break;
                            }
                        }

                        break;
                }
            }
        }

        public static Group CreateGroup(string groupNo, int maxLimit)
        {
            Group group = new Group();

            group.GroupNo = groupNo;
            group.StudentLimit = maxLimit;

            Console.WriteLine($"Group successfully created: {group.GroupNo} - {group.StudentLimit}");
            return group;
        }
        public static bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrEmpty(groupNo) && groupNo.Length == 5)
                if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                    return true;
            return false;
        }
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
    }
}
