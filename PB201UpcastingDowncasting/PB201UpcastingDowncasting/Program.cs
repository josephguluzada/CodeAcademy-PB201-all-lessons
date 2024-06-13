using PB201UpcastingDowncasting.Models;

namespace PB201UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicit, Explicit
            //double a = -1.5;

            //double b = (int)a;

            //Console.WriteLine(b);
            #endregion

            #region Upcasting, Downcasting
            //Animal starFish = new StarFish();
            //Animal eagle = new Eagle();
            ////Eagle eagle2 = (Eagle)starFish; // Exception convert ede bilmeyende
            //Eagle? eagle2 = starFish as Eagle; // Exception vermir, Null set edir cevire bilmeyende


            ////Console.WriteLine(starFish);
            ////starFish.Eat();
            ////starFish.Swim();
            ////starFish.Sleep();

            //Animal[] animals = { starFish, eagle };

            //foreach (Animal animal in animals)
            //{
            //    if(animal is StarFish)
            //    {
            //        StarFish starFish1 = (StarFish)animal;

            //        starFish1.Swim();
            //    }
            //    else if(animal is Eagle eagle1)
            //    {
            //        eagle1.Hunt();
            //    }
            //}
            #endregion

            #region Boxing, UnBoxing
            //string name = "Abbas";
            //int age = 13;

            //bool isFalse = true;

            //Eagle eagle = new Eagle();

            //object[] objects = { name, age, isFalse, eagle };


            //object objectInt = age;

            //int abbasinYasi = (int)objectInt;
            #endregion



        }
    }
}
