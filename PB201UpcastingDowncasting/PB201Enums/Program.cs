using PB201Enums.Models;

namespace PB201Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { Id = 1, Fullname = "Eli Eliyev", Position = Position.Employee};
            Person person2 = new Person { Id = 2, Fullname = "Veli Veliyev", Position = Position.Employee };
            Person person3 = new Person { Id = 3, Fullname = "Pirveli Velizade", Position = Position.Manager };
            Person person4 = new Person { Id = 4, Fullname = "Enver Zohrabov", Position = Position.CEO};

            Company pb201Company = new Company();
            pb201Company.Id = 1;
            pb201Company.Add(person1);
            pb201Company.Add(person2);
            pb201Company.Add(person3);
            pb201Company.Add(person4);

            Person[] wantedPeople = Array.Empty<Person>();

            try
            {
                wantedPeople = pb201Company.FilterByPosition("Employee");
            }
            catch (PersonNotFoundException salam)
            {
                Console.WriteLine("Xeta: " + salam.Message);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Her zaman ise dusur");
            }

            foreach (var ppl in wantedPeople)
            {
                Console.WriteLine("aaaa" + ppl.ToString());
            }
            Console.WriteLine("salam");
            Console.WriteLine("Sagol");



        }
    }
}
