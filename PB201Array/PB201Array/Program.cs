namespace PB201Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ages = new int[5];
            //int[] ages2 = new int[5] {12,13,14,15,16};
            //int[] ages3 = new int[] {1,2,3,4,6,7};
            //int[] ages4 = {1,2,3,4,5,6,7};

            //int[] ages3 = new int[] {1,2,3,4,6,7,847,43,8,3,4,495,38,428,34,78,34,77};
            //Console.WriteLine(ages3[ages3.Length-1]); //ages3[^1]
            //Console.WriteLine(ages3[17]);

            //string[] names = { "Teymur", "Abbas", "Ziya", "ELi", "Raul" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i] == "ELi")
            //    {
            //        Console.WriteLine(names[i]);
            //        break;
            //    }
            //}

            //int[] numbers = {1,2,3,4,5,6,7,8,9,10,11,11};
            //int[,] twoDimensionalArr = new int[3, 3] 
            //{ 
            //                            { 11, 22, 36} ,
            //                            { 166, 28, 39 } ,
            //                            { 1, 2, 3 }
            //};
            //int[,,] threeDimensionalArr = new
            //int sum = 0;
            //int counter = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        sum += numbers[i];
            //        counter++;
            //    }
            //}
            //Console.WriteLine(sum/counter);

            //Console.WriteLine(twoDimensionalArr.Rank);


            //int num = 4;
            //bool flag = false;
            //int counter = 0;
            //if(num == 0 || num == 1)
            //{
            //    Console.WriteLine("Neither prime, nor composite");
            //}

            //for (int i = 2; i < Math.Sqrt(num); i++)
            //{
            //    counter++;
            //    if(num % i == 0)
            //    {
            //        flag = true;
            //        break;
            //    }
            //}



            //if(flag) // flag == true
            //{
            //    Console.WriteLine($"Composite - {counter}");
            //}
            //else
            //{
            //    Console.WriteLine($"Prime - {counter}");
            //}


            var student1 = new { Name = "Eli", Age = 17, Grade = 77 };
            var student2 = new { Name = "Veli", Age = 27, Grade = 70 };
            var student3 = new { Name = "Pirveli", Age = 37, Grade = 15 };
            var student4 = new { Name = "Awiq Eli", Age = 105, Grade = 100 };

            var students = new[] { student1, student2, student3, student4 };


            //for(int i = students.Length-1; i >= 0 ; i--)
            //{
            //    Console.WriteLine($"Name: {students[i].Name} - Age: {students[i].Age} - Grade: {students[i].Grade}");
            //}

            //Console.WriteLine("=========================================================");

            foreach (var student in students)
            {
                if(student.Age > 30 && student.Name == "Awiq Elesger")
                {
                    Console.WriteLine($"Name: {student.Name} - Age: {student.Age} - Grade: {student.Grade}");
                }
            }

           


        }
    }
}
