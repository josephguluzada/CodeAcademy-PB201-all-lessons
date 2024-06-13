namespace PB201Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();

            //animal.MakeSound();

            Cat cat = new Cat();
            cat.Age = 10;
            cat.TailLength = 30;
            cat.ClassName = "Siam";
            //cat.MakeSound();
            //cat.Eat();

            Dog dog = new Dog();
            dog.Age = 10;
            dog.HasCollar = true;
            dog.ClassName = "Siam";
            //dog.MakeSound();
            //dog.Eat();


            Animal animalCat = cat;
            Animal animalDog = dog;

            Animal[] animals = { animalCat, animalDog };

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
                animal.Eat();
            }
        }
    }
}
