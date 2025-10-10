namespace LocalFunctions
{
    internal class Program
    {
        static void Main()
        {
            
        }
    }

    public class Class1
    {
        public void Display()
        {
            int i = 100;
            DoSomething();

            //local func - func declared inside a func
            //local func is only available in the outer func
            //implicitly private
            //cannot be overloaded
            void DoSomething()
            {
                //local func can access local variables declared
                //            in the outer function
                i++;
            }
        }
        public void Show()
        {

        }

    }
}
