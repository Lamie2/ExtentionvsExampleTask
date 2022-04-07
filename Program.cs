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


            var citiess = new Hashtable()
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

            #region ArrayList
            //1 
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


            //2
            ArrayList arlist1 = new ArrayList()
                {
                    150, 500, 620
                };

            ArrayList arrlist2 = new ArrayList()
                {
                    100, 700, 550
                };
            arlist1.InsertRange(2, arrlist2);

            foreach (var item in arlist1)
                Console.Write(item + ", "); 


            #endregion

            #region HashSet
            //1

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
            //1

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

            //2 update

            var city = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            cities["UK"] = "Liverpool, Bristol"; 
            cities["USA"] = "Los Angeles, Boston"; 

            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }
            #endregion

            #region SortedList

            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            sortedList.Add(4, null);
            sortedList.Add(10, "Ten");
            sortedList.Add(5, "Five");

            //2 
            SortedList<int, string> numNames = new SortedList<int, string>()
            {
                {3, "Three"},
                {1, "One"},
                {2, "Two"},
                {5, "Five"},
                {4, "Four"}
            };

            numNames.Remove(1);
            numNames.Remove(10);

            numNames.RemoveAt(0);

            foreach (var kvp in numNames)
            {
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            }
               

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



            //2
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Contains(2); 
            stack.Contains(10); 

            #endregion

            #region Queue<T>
            //1
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


            //2 

            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            callerIds.Contains(2);
            callerIds.Contains(10); 
            #endregion

            #region List < T >
            //1
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

            //2

            List<string> names = new List<string>();
            names.Add("Fuad");
            names.Add("Ehmed");
            names.Add("Leyla");
            names.Add("Nane");
            names.ForEach(name => Console.WriteLine(name));

            #endregion

        }
    }
}
