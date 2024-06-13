namespace PB201Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //PrintName("Sagol!");

            //int sumOfNumbers = Sum(45, 57); // 45+57 geriye qaytarir

            //Console.WriteLine(sumOfNumbers);


            //Console.WriteLine(Divide(5,2));

            //int[] nums = { 1, 4, 6, 7, 895, 435, 45335, 4354, 34, 2332 };
            //int[] nums2 = { 1, 4, 6, 7, 895, 435, 45335, 4354, 34, 2332 };

            //PrintAllNumbers(1, 2, 3, 4, 5, 6, 7, 8);

            //PrintAllCharsInName("Code Academy");

            //char[] chars = ReturnChars("Code Academy");

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}


            //Console.WriteLine(Sum(1.7,2));
            double result = Divide(5);

            if(result == -1)
            {
                Console.WriteLine("0 a bolmek olmur ay insan!");
            }
            else
            {
                Console.WriteLine(result);
            }



        }
        // Geriye deyer return etmeyen, parameteri olmayan 
        static void Print()
        {
            Console.WriteLine("Salam PB201!");
        }
        // Geriye deyer return etmeyen, parameteri olan 
        static void PrintName(string name)
        {
            Print();
            Console.WriteLine(name);
        }

        static void PrintAllNumbers(int number, int number2, params int[] numbers)
        {
            Console.WriteLine($"My Argument1: {number} - My Argument2: {number2}");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void PrintAllCharsInName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
        //static void PrintAllNumbers(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}

        // Geriye deyer return eden, paramateri olan
        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        static double Sum(double number1, double number2)
        {
            return (number1 + number2);
        }

        static double Sum(double number1, int number2)
        {
            return (number1 + number2);
        }

        static double Sum(int number1, double number2)
        {
            return (number1 + number2);
        }

        static int Sum(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        static int Sum(int number1, int number2, int number3, int number4)
        {
            return number1 + number2 + number3 + number4;
        }
       

        static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }


        static double Divide(double number1, double number2 = 1)
        {
            if(number2 != 0)
            {
                return number1 / number2;
            }

            return -1;
        }



        static char[] ReturnChars(string name) // Ilahe
        {
            char[] chars = new char[name.Length];//{ I,l ,a ,h ,e }

            for (int i = 0; i < name.Length; i++)
            {
                chars[i] = name[i];
            }

            return chars;
        }

        // Geriye deyer return eden, paramateri olmayan

        static int NotInCollection()
        {
            return -1;
        }

    }
}
