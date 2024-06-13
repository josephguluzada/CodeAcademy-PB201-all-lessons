using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generics
            // Non-generics

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("Salam");

            //arrayList.TrimToSize();
            //Console.WriteLine(arrayList.Capacity);
            //arrayList.Add("Salam");

            //Console.WriteLine(arrayList.Capacity);
            //ArrayList arrayList1 = (ArrayList)arrayList.Clone();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item.GetType());
            //}

            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1, "1");
            //hashtable.Add(2, "1");
            //hashtable.Add(3, "1");
            //hashtable.Add(14, 99);

            //Console.WriteLine(hashtable.Count);
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //SortedList sortedList = new SortedList();

            //sortedList.Add("b", "Salam");
            //sortedList.Add("a", 99);
            //sortedList.Add("c", "Salam");

            //sortedList.TrimToSize();

            //Console.WriteLine(sortedList.Capacity);

            //sortedList.SetByIndex(0, "bbbbbbb");
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //object[] array = new object[3];
            //Stack stack = new Stack(); // LIFO -> Last In First Out

            //stack.Push(1);
            //stack.Push("2");
            //stack.Push(true);

            //Console.WriteLine(stack.Peek());
            //stack.Pop();

            //stack.CopyTo(array, 0);


            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue queue = new Queue(); // FIFO -> First In First Out

            //queue.Enqueue(1);
            //queue.Enqueue("Salam");
            //queue.Enqueue(new DateTime());

            //Console.WriteLine(queue.Peek());
            //queue.Dequeue();

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //Dictionary<string,string> dictionary = new Dictionary<string,string>();

            //dictionary.Add("Yusif", "0505555555");
            //dictionary.Add("Vasif", "0505555556");
            //bool check = dictionary.TryAdd("Agasif", "Salam");

            //Console.WriteLine(check);

            //foreach (KeyValuePair<string,string> item in dictionary)
            //{
            //    Console.WriteLine(item.Key);
            //}

            //SortedList<int,int> sorterList = new SortedList<int,int>();

            //sorterList.Add(1, 2);
            //sorterList.Add(0, 3);
            //sorterList.Add(3, 3);
            //sorterList.Add(4, 3);
            //sorterList.Add(5, 3);
            //sorterList.Add(6, 3);
            //sorterList.Add(7, 3);
            //sorterList.Add(8, 3);
            //sorterList.Add(9, 3);
            //sorterList.Add(10, 3);
            //sorterList.Add(11, 3);
            //sorterList.Add(12, 3);
            //sorterList.Add(13, 3);


            //sorterList.TrimExcess();

            //Console.WriteLine(sorterList.FirstOrDefault());
            //Console.WriteLine(sorterList.Last());
            //Console.WriteLine(sorterList.Capacity);

            //Queue<int> ints = new Queue<int>(); // FIFO

            //ints.Enqueue(1);
            //ints.Enqueue(2);

            //Console.WriteLine("Peek: " + ints.Peek());
            //ints.Dequeue();


            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}


            Stack<int> ints = new Stack<int>();

            ints.Push(1);
            ints.Push(2);

            Console.WriteLine("Peek: " + ints.Peek());

            ints.Pop();
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

        }
    }
}
