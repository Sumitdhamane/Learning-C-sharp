namespace Var
{
    internal class Program
    {
        static void Main1(string[] args)
        
            
            {
                int i = 10;
                var j = "sumit";

                Console.WriteLine(j.GetType());
            }

        static void Main()
        {
            var obj = new { a = 1, b = "sumit", c = 1.263, d = true };
            var obj2 = new { a = 1, b = "sumit", c = 1.263, d = true };

            Console.WriteLine(obj2.GetType());
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj2.GetType() == obj.GetType());


        }
        
    }
}
