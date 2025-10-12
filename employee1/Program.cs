using System.Dynamic;

namespace employee1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee emp = new Employee();
            emp.name = "Test";
            emp.deptNo = 10;
            emp.empNo = 55;
            emp.basic = 25000;
            Console.WriteLine($"Name : {emp.name}, Emp number: {emp.empNo} , Basic: {emp.basic}, deptNo: {emp.deptNo}, Net Salary: {emp.GetEmpSalary()}"); 
        }

        class Employee
        {
            private string? Name;
            private int EmpNo;
            private decimal Basic;
            private short DeptNo;

            public string? name
            {
                get { return Name; }
                set
                {
                    if (value == null || value == "")
                    {
                        throw new Exception("Name cannot be null or empty");
                    }
                    else
                    {
                        Name = value;
                    }
                }
            }

            public int empNo
            {
                get { return EmpNo; }
                set
                {
                    if (value<0 && value>100)
                    {
                        throw new Exception("number in between 0 to 100");
                    }
                    else
                    {
                        EmpNo = value;
                    }
                }
            }

            public decimal basic
            {
                get { return Basic; }
                set
                {
                    if (value < 10000 )
                    {
                        throw new Exception("basic is greater than 10000");
                    }
                    else
                    {
                        Basic = value;
                    }
                }
            }

            public short deptNo
            {
                get { return DeptNo; }
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("number should not less than 0");
                    }
                    else
                    {
                        DeptNo = value;
                    }
                }
            }

            public  decimal GetEmpSalary()
            {
                return Basic * 2.35M; 
            }

        }
    }
}
