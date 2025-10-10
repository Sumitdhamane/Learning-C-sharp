namespace FieldsAndProperties
{
    internal class Program
    {
        static void Main1()
        {
            //Class1 obj = new Class1();

            //obj.i = ++obj.i + obj.i++ - --obj.i - obj.i--;
            //obj.Seti(obj.Geti() + 1)


            //obj.Seti(70);
            //Console.WriteLine(obj.Geti());



        }
        static void Main()
        {
            Class1 obj = new Class1();
            obj.I = 10;  //assign - set
            Console.WriteLine(obj.I); //read - get
        }
    }
    //public class Class1
    //{
    //    private int i; //class level variable - field
    //    public void Seti(int VALUE)
    //    {
    //        if(VALUE <=100)
    //            i = VALUE;
    //        else
    //            Console.WriteLine("Invalid value");
    //    }
    //    public int Geti() 
    //    { 
    //        return i; 
    //    }
    //}
    public class Class1
    {
        private int i; //field
        public int I
        {
            set
            {
                if(value <= 100)
                    i = value;
                else
                    Console.WriteLine("Invalid value");
            }
            get
            {
                return i;
            }
        }
        private string prop1;
        public string Prop1
        {
            set { prop1 = value; }
            get { return prop1; }
        }
    }


}
