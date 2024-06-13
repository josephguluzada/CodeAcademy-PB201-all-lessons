namespace PB201ClassMethod
{
    public class Teacher : Human
    {
        public double Salary;


        public void ShowFullData()
        {
            Console.WriteLine($"Fullname: {Name} {Surname} Age: {Age} Salary: {Salary} ");
        }

        public string GetFullData()
        {
            return $"Fullname: {Name} {Surname} Age: {Age} Salary: {Salary} ";
        }
    }
}
