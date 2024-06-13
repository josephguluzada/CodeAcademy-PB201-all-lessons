namespace PB201StringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintSumOfEvenNumbers(10);
            //int number = SumOfEvenNumbers(10);
            //Console.WriteLine(number);
            //string trimmedWord = CustomTrim("  Code  Acacemy  PB 201 ");
            //Console.WriteLine(trimmedWord);
            //PrintFirstLettersWithForeach("   Hello World  P B 2 0 1 ");

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(numbers.Equals(numbers2));
            //Console.WriteLine("Before method:");
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //ChangeArraysNumber(numbers, 3, 7);

            //Console.WriteLine("After method:");
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //int number = 0;
            //Console.WriteLine("Before method");
            //Console.WriteLine(number);
            //ChangeNumbersValue(ref number);
            //Console.WriteLine("After method");
            //Console.WriteLine(number);

            //string groupName = "PB201";
            //string groupName2 = "PB201";
            //string groupName3 = new string(new char[] { 'P', 'B', '2', '0', '1' });

            //groupName3 = string.Intern(groupName3);
            //Console.WriteLine(string.ReferenceEquals(groupName,groupName3));

            //Console.WriteLine(groupName[0]);
            //int a = 5;
            //int b = 5;
            //Console.WriteLine(object.ReferenceEquals(groupName,groupName2));

            #region String Methods

            //string word = "Hello World";

            ////Console.WriteLine(word.Length);

            ////Console.WriteLine(word.Contains("1"));
            ////Console.WriteLine(word.Trim());
            ////Console.Write(word.TrimStart());
            ////Console.Write(word.TrimEnd());
            ////Console.WriteLine(word.ToUpper()) ;
            ////Console.WriteLine(word.ToLower()) ;

            ////Console.WriteLine(word.Substring(6,5));
            ////Console.WriteLine(word.ToLower().StartsWith("he"));
            ////Console.WriteLine(word.IndexOf("o"));
            ////Console.WriteLine(word.LastIndexOf("o"));

            //int[] numbers = { 1, 2, 7,3, 4, 5,9,6 };

            ////Console.WriteLine(numbers.Length);

            ////Array.Sort(numbers);
            ////Array.Reverse(numbers);
            ////Array.Clear(numbers);
            //Console.WriteLine(numbers.Max()); 
            //Console.WriteLine(numbers.Min());
            //Console.WriteLine(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}





            //char a = 'a';
            //char b = '?';
            //Console.WriteLine(char.ToUpper(a));
            //Console.WriteLine(char.IsDigit(a));
            //Console.WriteLine(char.IsLetter(a));
            //Console.WriteLine(char.IsLetterOrDigit(b));
            //Console.WriteLine(char.IsUpper(a));

            string word2 = "New World";
            string[] words = word2.Split(" ");

            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}
            
            string test = string.Join('-', "Salam", "PB201" );
            Console.WriteLine(test);

            // Salam123@
            #endregion


        }

        static void ChangeArraysNumber(int[] numbers, int index, int number)
        {
            numbers[index] = number;
        }

        static int ChangeNumbersValue(ref int number2)
        {
            number2 = 10;
            Console.WriteLine("Inside method {0}", number2);
            return number2;
        }





















        //Bir int parametr qəbul edən və o ədədə qədər bütün cüt ədədlərin cəmini ekrana yazdıran, həm return type-ı olan bir method, həm də void bir method yazırsız
        //static void PrintSumOfEvenNumbers(int number)
        //{
        //    int sum = 0;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        if(i % 2 == 0)
        //        {
        //            sum += i;
        //        }
        //    }

        //    Console.WriteLine(sum);
        //}

        //static int SumOfEvenNumbers(int number)
        //{
        //    int sum = 0;

        //    for (int i = 1; i <= number; i++)
        //    {
        //        if(i % 2 == 0)
        //        {
        //            sum += i;
        //        }
        //    }

        //    return sum;
        //}

        // Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.Misal olaraq, name = "  Code  Acacemy   " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "CodeAcademy" olmalıdır.

        //static string CustomTrim(string word)
        //{
        //    string newWord = String.Empty; // ""
        //    foreach (var ch in word)
        //    {
        //        if(ch == ' ')
        //        {
        //            continue;
        //        }
        //        newWord += ch;
        //    }

        //    return newWord; // CodeAcademy
        //}

        //static string CustomTrim(string word)
        //{
        //    string newWord = String.Empty; // ""
        //    foreach (var ch in word)
        //    {
        //        if (ch != ' ')
        //        {
        //            newWord += ch;
        //        }
        //    }

        //    return newWord; // CodeAcademy
        //}


        // İstənilən verilən cümlədə sözlərin baş hərflərini ekrana yazdıran method yazın  məs .("Hello World --> "H" "W" )

        //static void PrintFirstLettersWithFor(string text)
        //{
        //    bool newWord = true;
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] == ' ')
        //        {
        //            newWord = true;
        //        }
        //        else
        //        {
        //            if(newWord == true)
        //            {
        //                Console.WriteLine(text[i]);
        //                newWord = false;
        //            }
        //        }
        //    }
        //}

        //static void PrintFirstLettersWithForeach(string text)
        //{
        //    bool newWord = true;
        //    foreach (var item in text)
        //    {
        //        if (item == ' ')
        //        {
        //            newWord = true;
        //        }
        //        else
        //        {
        //            if (newWord == true)
        //            {
        //                Console.WriteLine(item);
        //                newWord = false;
        //            }
        //        }
        //    }
        //}


    }
}
