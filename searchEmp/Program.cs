using System.Xml.Linq;

namespace searchEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of employees:");
            int n = int.Parse(Console.ReadLine()!);

            Employee[] employees = new Employee[n];

            for(int i=0; i<n; i++)
            {
                Console.WriteLine($"Enter Details of employee {i+1}");
                Console.Write("Enter EmpNo:");
                int empNo = int.Parse(Console.ReadLine()!);

                Console.Write("Enter name:");
                string name = (Console.ReadLine()!);

                Console.Write("Enter Basic:");
                decimal basic = int.Parse(Console.ReadLine()!);

                employees[i] = new Employee(empNo, name, basic);
            }

            Employee highestSal = employees[0];

            for (int i = 1; i < employees.Length; i++)
            {
                if (employees[i].Basic > highestSal.Basic)
                {
                    highestSal = employees[i];  
                }

            }
            Console.WriteLine();
            Console.WriteLine("\nEmployee with Highest Salary:");
            highestSal.Display();

            Console.WriteLine("Enter EmpNo to search: ");
            int searchNo = int.Parse(Console.ReadLine()!);
            bool found = false;

            foreach (Employee item in employees) 
            {
                if(item.EmpNo == searchNo)
                {
                    Console.WriteLine("\nEmployee Found:");
                    item.Display();
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("Employee not found.");

            Console.ReadLine();
        }

        class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
            public decimal Basic { get; set; }

            public Employee(int empNo, string name, decimal basic)
            {
                EmpNo = empNo;
                Name = name;
                Basic = basic;
            }
            public void Display()
            {
                Console.WriteLine($"EmpNo: {EmpNo} , Name : {Name}, Basic: {Basic}");
            }
        }
    }
}
