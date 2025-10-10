using System;
using System.Collections;
using System.Reflection;

namespace CollectionsExample
{
    internal class Program
    {
        static void Main()
        {
            ArrayList objArrayList = new ArrayList();
            objArrayList.Add(10);
            objArrayList.Add("Vikram");
            objArrayList.Add(10.234);
            objArrayList.Add(true);

            //foreach (object item in objArrayList)
            //{
            //    Console.Write(item) ;
            //}

            ArrayList objArrayList2 = new ArrayList();
            objArrayList2.Add(123);
            objArrayList2.Add(456);

            objArrayList.AddRange(objArrayList2);
            foreach (object item in objArrayList)
            {
                Console.WriteLine(item);
            }

            //objArrayList.Add(objArrayList2);

            objArrayList.Insert(0, "inserted");
            //objArrayList.InsertRange(0, objArrayList2);

            //objArrayList.Remove(10); //object
            //objArrayList.RemoveAt(10);  //index - item no 11
            objArrayList.RemoveAt(1);
            //objArrayList.RemoveRange(index, count);

            //objArrayList.Clear(); //remove all

            //to do - read up on cloning in .net
            ArrayList o3 = (ArrayList)objArrayList.Clone();

            bool isPresent = objArrayList.Contains("Vikram");
            object[] arr = new object[objArrayList.Count];
            objArrayList.CopyTo(arr);

            object[] arr2 = objArrayList.ToArray();

            //o3 = objArrayList.GetRange(index, count);


            //objArrayList -- a, b, c, d, e
            //o3 -- x,y,z
            //objArrayList.SetRange(0, o3);
            //objArrayList -- x,y,z, d, e

            objArrayList[0] = "changed value";
            //objArrayList.this[0] = "changed value";  //concept of indexer


            Console.WriteLine(objArrayList.Count);
            Console.WriteLine();
            //foreach (object item in objArrayList)
            //{
            //    Console.WriteLine(item);
            //}

        }
        static void Main2()
        {
            ArrayList objArrayList = new ArrayList();
            Console.WriteLine($"Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");


            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");

            objArrayList.Add("a");
            Console.WriteLine($"Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");

            objArrayList.TrimToSize();
            Console.WriteLine($"after trim - Count={objArrayList.Count}, Capacity={objArrayList.Capacity}");

        }

        static void Main3()
        {
            //Hashtable objDictionary = new Hashtable();
            SortedList objDictionary = new SortedList();
            objDictionary.Add(6, "Himanshoooo");
            objDictionary.Add(5, "Manish");
            objDictionary.Add(1, "Anuj");
            objDictionary.Add(2, "Aabhas");
            objDictionary.Add(3, "Junaid");
            objDictionary.Add(4, "Safwan");
            //objDictionary.Add(6, "Himanshu");//error - key must be unique

            objDictionary[7] = "added"; //add if key not present
            objDictionary[6] = "Himanshu";//update if key present

            objDictionary.Remove(7); //key
            //objDictionary.RemoveAt(7); //index


            foreach (DictionaryEntry item in objDictionary)
            {
                Console.Write(item.Key + ":");
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(objDictionary.GetByIndex(0)); //gets value at index
            Console.WriteLine(objDictionary.GetKey(0));//gets key at index 
            IList keys = objDictionary.GetKeyList();
            IList values = objDictionary.GetValueList();


            Console.WriteLine(objDictionary.IndexOfKey(1));//gets index from key
            Console.WriteLine(objDictionary.IndexOfValue("Junaid"));//gets value at index 
            //objDictionary.SetByIndex(index,valuetoset);//
            //objDictionary.Keys;
            //objDictionary.Values;

        }
        static void Main4()
        {
            Stack s = new Stack();
            s.Push("aa");
            Console.WriteLine(s.Peek()); //read it but dont remove from stack
            Console.WriteLine(s.Pop());//get the value and remove from stack

            Queue q = new Queue();
            q.Enqueue("aa");
            Console.WriteLine(q.Peek()); //read it but dont remove from stack
            Console.WriteLine(q.Dequeue());//get the value and remove from stack

        }

        static void Main5()
        {
            List<int> o = new List<int>();
            o.Add(1);
            foreach (int item in o)
            {
                Console.WriteLine(item);
            }
            List<string> o2 = new List<string>();
            o2.Add("aa");

            List<Employee> o3 = new List<Employee>();
            o3.Add(new Employee { EmpNo = 1, Name = "Arslan" });
            o3.Add(new Employee { EmpNo = 2, Name = "Abdul" });

            foreach (Employee item in o3)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }
        }
        static void Main6()
        {
            SortedList<int, Employee> objDictionary = new SortedList<int, Employee>();
            objDictionary.Add(1, new Employee { EmpNo = 1, Name = "Arslan" });
            objDictionary.Add(2, new Employee { EmpNo = 2, Name = "Abdul" });

            foreach (KeyValuePair<int,Employee> item in objDictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.Name);
            }
        }
        static void Main7()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());

            Queue<int> q = new Queue<int>();
        }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string? Name { get; set; }
    }
}