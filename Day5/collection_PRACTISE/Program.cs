using System.Collections;

namespace collection_PRACTISE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList objArray = new ArrayList();
            objArray.Add(10);
            objArray.Add(20);
            objArray.Add("Sumit");

            ArrayList objArray2 = new ArrayList();
            objArray2.Add(120);
            objArray2.Add(250);



            //objArray.AddRange(objArray2);
            //objArray.Add(objArray2);

            //foreach (object item in objArray)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine();

            //objArray.Insert(0, "Shreyas");
            //objArray.InsertRange(1,objArray2);
            //foreach (object item in objArray)
            //{
            //    Console.WriteLine(item);
            //}

            //objArray.Remove("Sumit");
            //objArray.RemoveAt(2);
            //objArray.RemoveRange(1,2);
            //foreach (object item in objArray)
            //{
            //    Console.WriteLine(item);
            //}

            
            foreach (object item in objArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
