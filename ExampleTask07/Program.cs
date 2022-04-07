using System;
using System.Collections;
using System.Collections.Generic;

namespace ExampleTask07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hashtable

            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); 
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach (DictionaryEntry de in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            } 
           
            var cities = new Hashtable()
            {
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (DictionaryEntry de in cities)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }

            #endregion

            #region ArrayList

            var arrlist1 = new ArrayList();
            arrlist1.Add(1);
            arrlist1.Add("Bill");
            arrlist1.Add(" ");
            arrlist1.Add(true);
            arrlist1.Add(4.5);
            arrlist1.Add(null);
       
            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };

            #endregion

            #region HashSet

            HashSet<string> myhash = new HashSet<string>();

            myhash.Add("C");
            myhash.Add("C++");
            myhash.Add("C#");
            myhash.Add("Java");
            myhash.Add("Ruby");
            Console.WriteLine("Elements of myhash:");

            foreach (var val in myhash)
            {
                Console.WriteLine(val);
            }

            HashSet<int> myhash1 = new HashSet<int>() 
            {
                10, 100,1000,10000,100000
            };

            Console.WriteLine("Elements of myhash1:");
            foreach (var value in myhash1)
            {
                Console.WriteLine(value);
            }

            #endregion

            #region  Dictionary<TKey, TValue>

            Dictionary<string, string> citiess = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            cities.Remove("UK"); 

            if (cities.ContainsKey("France"))
            { 
                cities.Remove("France");
            }

            cities.Clear();


            #endregion

            #region SortedList

            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            sortedList.Add(4, null);
            sortedList.Add(10, "Ten");
            sortedList.Add(5, "Five");

            #endregion

            #region Stack<T>

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            while (myStack.Count > 0)
            {
                Console.Write(myStack.Pop() + ",");
            }  

            Console.Write("Number of elements in Stack: {0}", myStack.Count);

            #endregion

            #region Queue<T>

            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            Console.WriteLine("Total elements: {0}", strQ.Count);

            if (strQ.Count > 0)
            {
                Console.WriteLine(strQ.Peek()); 
                Console.WriteLine(strQ.Peek()); 
            }

            Console.WriteLine("Total elements: {0}", strQ.Count);

            #endregion

            #region List < T >

            List<int> numbers = new List<int>();
            for (int i = 1; i <= 49; i++)
            {
                numbers.Add(i);
            }
            for (int j = 1; j <= 6; j++)
            {
                System.Threading.Thread.Sleep(1000); 
                Random rnd = new Random();
                int index = rnd.Next(0, numbers.Count);
                Console.WriteLine(numbers[index]);
                numbers.RemoveAt(index);
            }
            Console.ReadLine();

            #endregion

        }
    }
}
