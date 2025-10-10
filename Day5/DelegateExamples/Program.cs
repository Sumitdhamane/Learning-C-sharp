namespace DelegateExamples
{
    //step 1 : create a delegate class
    //having the same signature as the func to call
    public delegate void Del1();
    //Object
    //Delegate
    //MulticastDelegate
    //Del1

    public delegate int DelAdd(int a, int b);

    internal class Program
    {
        static void Main1()
        {
            //step 2 : declare a delegate reference
            // create a delegate object,
            // passing the func name as a parameter
        
            Del1 objDel = new Del1(Display);
            //step 3 : call the func indirectly using the delegate reference
            objDel();
        }
        static void Main2()
        {
            //Del1 objDel = new Del1(Display);
            Del1 objDel = Display;
            objDel();

            objDel = Show;
            objDel();
        }
        static void Main3()
        {
            //Del1 objDel = new Del1(Display);
            Del1 objDel = Display;
            objDel();

            Console.WriteLine();
            objDel += Show;
            objDel();

            Console.WriteLine();
            objDel += Display;
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();

            Console.WriteLine();
            objDel -= Show;
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();

        }
        static void Main4()
        {
            Del1 objDel = (Del1)Delegate.Combine(new Del1(Display), 
                                 new Del1(Show), new Del1(Display)) ;
            objDel();

            Console.WriteLine();
            //objDel = (Del1)Delegate.Remove(objDel, new Del1(Display));
            objDel = (Del1)Delegate.RemoveAll(objDel, new Del1(Display));
            objDel();

        }
        static void Main()
        {
            DelAdd objAdd = Add;

            //int ans = Add(10, 5);
            //Console.WriteLine(ans);
            //Console.WriteLine(Add(10, 5));
            Console.WriteLine(objAdd(10, 5));

            Console.WriteLine();
            objAdd += Subtract;
            Console.WriteLine(objAdd(10, 5));

        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static void Display()
        {
            Console.WriteLine("Display called");
        }
        static void Show()
        {
            Console.WriteLine("Show called");
        }

    }
}
