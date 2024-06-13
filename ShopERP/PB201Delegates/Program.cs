namespace PB201Delegates
{
    internal class Program
    {

        delegate bool CheckNum(int number);
        delegate int SumOfNums(int num1,int num2);
        delegate bool Elnur(int number,int number2,int number3);

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            //CheckNum checkNum = CheckNumberIfEven;
            //checkNum = CheckNumberIfOdd;
            //checkNum = delegate (int number) { return number % 2 == 0; };
            //checkNum = (x) => x % 2 == 0;
            //TestMethod(Test);

            //Func<int, int, bool> func = Test;
            //Action<string, string> action = ShowFullName;
            //Predicate<int> predicate = CheckNumberIfOdd;
            //predicate = delegate (int number) { return number == 1; };

            //Console.WriteLine(SumOfNumbers(numbers, x=>x%2==0));
            //Console.WriteLine(SumOfNumbers(numbers, predicate));
            //Console.WriteLine(SumOfNumbers(numbers, predicate));


            var list = FindAll(numbers, x=>x%2 == 0);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list = FindAll(numbers, x => x % 2 == 1);

        }

        static int SumOfNumbers(List<int> numbers, Predicate<int> predicate) 
        {
            int sum = 0;    
            foreach (var item in numbers)
            {
                if (predicate(item))
                {
                    sum += item;
                }
            }

            return sum;
        }

        static void ShowFullName(string name,string surname)
        {
            Console.WriteLine(name + " " + surname);
        }

        //static int SumOfOdds(List<int> numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (item % 2 == 1)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}
        //static int SumOfDivideBy5(List<int> numbers)
        //{
        //    int sum = 0;
        //    foreach (var item in numbers)
        //    {
        //        if (item % 5 == 0)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        static bool TestMethod(SumOfNums sumOf)
        {
            return true;
        }

        static bool Test(int number1,int number2)
        {
            return number1>number2;
        }
        static bool CheckNumberIfEven(int number)
        {
            return number % 2 == 0;
        }

        static bool CheckNumberIfOdd(int number)
        {
            return number % 2 == 1;
        }

        static List<int> FindAll(List<int> numbers, Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach (var item in numbers)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

    }
}
