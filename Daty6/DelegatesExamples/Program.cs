namespace DelegatesExamples
{
    public delegate int DelAdd(int a, int b);
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(CallArithmeticOperation(Add,2,3));
            Console.WriteLine(CallArithmeticOperation(Subtract,10,2));
            Console.WriteLine(CallArithmeticOperation(Multiply,5,4));

        }
        //func to be called is passed as a parameter using delegates
        static int CallArithmeticOperation(DelAdd objDel, int a, int b) //objDel = Add
        {
            //return objDel(10, 5);
            return objDel(a, b);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
