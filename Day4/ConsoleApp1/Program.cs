namespace ConsoleApp1
{
    internal class Program
    {
        static void Main1()
        {
            int[] arr= new int[5];
            //arr[0].....arr[4]
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine("Enter arr[__] : ");
                //Console.Write("Enter arr[" + i + "] : "); //string concatenation
                //Console.Write("Enter arr[{0}] : ", i); //placeholder
                Console.Write($"Enter arr[{i}] : "); //string interpolation
                arr[i] = int.Parse( Console.ReadLine() ); 
            }
            Console.WriteLine();
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main2()
        {
            int[] arr = new int[5] { 10, 20, 30, 40,50};
            //int[] arr2 = { 10, 20, 30 };
            //int[] arr3 = new int[] { 10, 20, 30, 40, 50,60 };
            int pos;
            pos = Array.IndexOf(arr, 30);//2
            pos = Array.IndexOf(arr, 35);//-1

            pos = Array.LastIndexOf(arr, 30);
            pos = Array.BinarySearch(arr, 30);// negative no if not found

            Array.Clear(arr);

            //Array.Copy(arr, 0, arr2, 1, arr.Length);
            //Array.Copy(arr,arr2, arr.Length);

            //Array.ConstrainedCopy(arr,0,arr2,1,arr.Length);

            int[] arr3 = (int[]) Array.CreateInstance(typeof(int), 5);
            Array.Sort(arr);
            Array.Reverse(arr);


            Console.WriteLine();
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main2()
        {
            int[,] arr = new int[5,3];
            //arr[0,0] arr[0,1] arr[0,2]
            //arr[1,0] arr[1,1] arr[1,2]
            //arr[2,0] arr[2,1] arr[2,2]
            //arr[3,0] arr[3,1] arr[3,2]
            //arr[4,0] arr[4,1] arr[4,2]

            //Console.WriteLine(arr.Length); //15
            //Console.WriteLine(arr.Rank); //dimensions - 2
            //Console.WriteLine(arr.GetLength(0)); //length of the first(0th) dimension -5
            //Console.WriteLine(arr.GetLength(1)); //length of the second(1st) dimension -3
            //Console.WriteLine(arr.GetUpperBound(0)); //upper bound of the first(0th) dimension -4

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Enter arr[{i},{j}] : "); //string interpolation
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"arr[{i},{j}] is {arr[i,j]} "); //string interpolation
                }
            }

        }
        static void Main4()
        {
            //jagged
            int[][] arr = new int[4][];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = new int[x]
            //}

            arr[0] = new int[3]; // arr[0][0] arr[0][1] arr[0][2]
            arr[1] = new int[4]; // arr[1][0] arr[1][1] arr[1][2] arr[1][3]
            arr[2] = new int[2];//  arr[2][0] - arr [2][1]
            arr[3] = new int[3];//  arr[3][0] arr[3][1] arr[3][2]

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("enter value for subscript [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("value for subscript {0},{1} is {2}  ", i, j, arr[i][j]);

                }
            }
            Console.ReadLine();
        }
        static void Main()
        {
            Employee[] arr = new Employee[4];
            //arr[0] = new Employee();
            //arr[1] = new Employee();
            //arr[2] = new Employee();
            //arr[3] = new Employee();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Employee();
            }
            arr[0].EmpNo = int.Parse(Console.ReadLine());
            arr[0].Name= Console.ReadLine();
            foreach (Employee item in arr)
            {
                //item = new Employee();  //error 
                //item.Name = Console.ReadLine(); //allowed
                Console.WriteLine(item.Name);
            }

        }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string? Name { get; set; }

    }
}
