namespace PB201CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5 , Məs: 456, output: 3
            //Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5 , Məs: 456, output: 3

            //int number = 0;
            //int digitCount = 0;

            //while (number > 0)
            //{
            //    number /= 10;
            //    digitCount++;
            //}

            //Console.WriteLine(digitCount);
            #endregion

            #region Verilmiş ededler siyahisindaki en böyük ededi tapan alqoritm

            //Verilmiş ededler siyahisindaki en böyük ededi tapan alqoritm

            //int[] numbers = { 11, 12, 13, 14, 77, 55, 88, 33, 1 };

            //int maxNumber = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            #endregion
            #region Verilmiş Products arrayindəki Product objectlərinin Id'ləri tək olanlarının Price'larının ədədi ortasını tapan algorithm yazın.(Product objectinin propertyləri: Id(yeni reqem ve ya eded), Name, Price, StockCount)

            //Verilmiş Products arrayindəki Product objectlərinin Id'ləri tək olanlarının Price'larının ədədi ortasını tapan algorithm yazın.(Product objectinin propertyləri: Id(yeni reqem ve ya eded), Name, Price, StockCount)

            //var product1 = new { Id = 1, Name = "Macbook 13 Pro", Price = 1500, StockCount = 3 };
            //var product2 = new { Id = 2, Name = "Macbook 14 Pro Max", Price = 2500, StockCount = 311 };
            //var product3 = new { Id = 3, Name = "Macbook 15 Pro MaMax", Price = 6500, StockCount = 30000 };
            //var product4 = new { Id = 4, Name = "Macbook 16 Pro MaMax 2", Price = 16500, StockCount = 30000 };

            //var products = new[] { product1, product2, product3, product4 };
            //int sumOfPrices = 0;
            //int count = 0;

            //foreach (var prd in products)
            //{
            //    if(prd.Id % 2 == 1)
            //    {
            //        sumOfPrices += prd.Price;
            //        count++;
            //    }
            //}

            //Console.WriteLine(sumOfPrices/count);

            #endregion
            #region Linear
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //int targetNumber = 100;
            //int foundIndex = -1;
            //int counter = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    counter++;
            //    if (numbers[i] == targetNumber)
            //    {
            //        foundIndex = i;
            //        break;
            //    }
            //}

            //if(foundIndex == -1)
            //{
            //    Console.WriteLine("Axtardiginiz arrayde yoxdur " + counter);
            //}else
            //{
            //    Console.WriteLine("index: "  + foundIndex + " count: " + counter);
            //}
            #endregion

            #region Binary
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //int[] numbers = { 2, 1, 4, 5, 3, 15, 14, 12, 11, 13, 7, 6, 10, 9, 8,17,16 };
            //// Bubble sort
            //int temp;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers.Length - 1; j++)
            //    {
            //        if (numbers[j] > numbers[j + 1])
            //        {
            //            temp = numbers[j + 1];
            //            numbers[j + 1] = numbers[j];
            //            numbers[j] = temp;
            //        }
            //    }
            //}

            //int start = 0;
            //int end = numbers.Length - 1;
            //int target = 18;
            //int foundIndex = -1;
            //int mid;
            //int counter = 0;
            // binary search
            //while (start <= end)
            //{
            //    counter++;
            //    mid = (start + end) / 2;

            //    if (numbers[mid] == target)
            //    {
            //        foundIndex = mid;
            //        break;
            //    }
            //    else if (numbers[mid] < target)
            //    {
            //        start = mid + 1;
            //    }
            //    else
            //    {
            //        end = mid - 1;
            //    }
            //}

            //Console.WriteLine($"Found index: {foundIndex} -- Counter: {counter}");
            #endregion

            #region Bubble Sort
            //int[] numbers = { 2, 1, 4, 5, 3, 15, 14, 12, 11, 13, 7, 6, 10, 9, 8 };
            //int temp;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers.Length - 1; j++)
            //    {
            //        if (numbers[j] > numbers[j + 1])
            //        {
            //            temp = numbers[j + 1];
            //            numbers[j + 1] = numbers[j];
            //            numbers[j] = temp;
            //        }
            //    }
            //}

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(numbers.GetHashCode());
            #endregion

            //int number1 = 10;
            //int number2 = number1; // 10

            //number2 = 5;

            //Console.WriteLine(number1);
            //Console.WriteLine(number2);

            //int[] numbers1 = { 1, 2, 3 }; // 0x321
            //int[] numbers2 = numbers1; // 0x321
            //numbers2[0] = 10;

            //Console.WriteLine("numbers1");
            //foreach (var item in numbers1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("numbers2");
            //foreach (var item in numbers2)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
