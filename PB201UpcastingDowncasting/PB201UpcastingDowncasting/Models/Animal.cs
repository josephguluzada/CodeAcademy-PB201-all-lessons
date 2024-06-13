using System.Threading.Channels;

namespace PB201UpcastingDowncasting.Models;

public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eat as animal");
    }
}

public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine("Fly as a bird");
    }
}

public class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine("Swim like a Fish");
    }
}

public class StarFish : Fish
{
    public void Sleep()
    {
        Console.WriteLine("Oyatmayin yatiram!");
    }
}

public class Eagle : Bird
{
    public void Hunt()
    {
        Console.WriteLine("Vehsi qus kimi ovlayir!");
    }
}
