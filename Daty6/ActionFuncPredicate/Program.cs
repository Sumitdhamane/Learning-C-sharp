namespace ActionFuncPredicate
{
    internal class Program
    {
        static void Main1()
        {
            Action o1 = Display;
            o1();
            o1 = Class1.Display;
            o1();
            Class1 obj = new Class1();
            o1 = obj.Show;
            o1();

            Action<string> o2 = Display;
            o2("aaa");

            Action<string, int> o3 = Display;
            o3("aaa", 10);
        }
        static void Display()
        {
            Console.WriteLine("Display called");
        }
        static void Display(string s)
        {
            Console.WriteLine("Display called" + s);
        }
        static void Display(string s,int i)
        {
            Console.WriteLine("Display called" + s+ i);
        }


        static void Main()
        {
            Func<string> o1 = GetTime;
            Console.WriteLine(o1());

            Func<int, int> o2 = GetDouble;
            Console.WriteLine(o2(10));

            Func<int,int,int> o3 = Add;
            Console.WriteLine(o3(1,2));

            Func<int, bool> o4 = IsEven;
            Console.WriteLine(o4(10));

            Predicate<int> o5 = IsEven;
            Console.WriteLine(o5(10));

            Employee obj = new Employee { EmpNo=1, Name="a", Basic = 20000, DeptNo=10 };
            Func<Employee, bool> o6 = IsBasicGreaterThan10000;
            Console.WriteLine(o6(obj));

            Predicate<Employee> o7 = IsBasicGreaterThan10000;
            Console.WriteLine(o7(obj));


        }
        static bool IsBasicGreaterThan10000(Employee obj)
        {
            if (obj.Basic > 10000)
                return true;
            else
                return false;
        }
        static string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static bool IsEven2(int a)
        {
            return a % 2 == 0;
        }
        static int GetDouble(int a)
        {
            return a * 2;
        }

        
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
    public class Class1
    {
        public static void Display()
        {
            Console.WriteLine("Display called");
        }
        public void Show()
        {
            Console.WriteLine("Display called");
        }
    }
}
