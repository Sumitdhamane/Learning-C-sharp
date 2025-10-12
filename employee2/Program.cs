using System;

namespace EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects of derived classes
            Manager m1 = new Manager("Project Manager", "Sumit", 35000, 20);
            m1.Insert();
            Console.WriteLine($"Manager Net Salary: {m1.CalcNetSalary()}");

            GeneralManager gm1 = new GeneralManager("Car, House", "HR Head", "Rohit", 45000, 30);
            gm1.Update();
            Console.WriteLine($"General Manager Net Salary: {gm1.CalcNetSalary()}");

            CEO c1 = new CEO("Rahul", 75000, 40);
            c1.Delete();
            Console.WriteLine($"CEO Net Salary: {c1.CalcNetSalary()}");

            Console.ReadLine();
        }
    }

    // ---------- INTERFACE -------------
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    // ---------- ABSTRACT BASE CLASS -------------
    public abstract class Employee : IDbFunctions
    {
        private string name;
        private int empNo;
        private static int lastEmpNo = 0;
        private decimal basic;
        private short deptNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be null or empty");
                name = value;
            }
        }

        public int EmpNo => empNo;

        public virtual decimal Basic
        {
            get { return basic; }
            set
            {
                if (value < 10000)
                    throw new Exception("Basic must be >= 10000");
                basic = value;
            }
        }

        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value <= 0)
                    throw new Exception("DeptNo must be greater than 0");
                deptNo = value;
            }
        }

        // Base constructor
        public Employee(string name = "Default", decimal basic = 20000, short deptNo = 10)
        {
            this.empNo = ++lastEmpNo;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }

        // Abstract method (must be implemented in derived classes)
        public abstract decimal CalcNetSalary();

        // Interface methods with default implementation
        public void Insert() => Console.WriteLine($"{GetType().Name} record inserted in DB.");
        public void Update() => Console.WriteLine($"{GetType().Name} record updated in DB.");
        public void Delete() => Console.WriteLine($"{GetType().Name} record deleted from DB.");
    }

    // ---------- MANAGER CLASS -------------
    public class Manager : Employee
    {
        private string designation;

        public string Designation
        {
            get { return designation; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Designation cannot be empty");
                designation = value;
            }
        }

        // Override Basic validation
        public override decimal Basic
        {
            get { return base.Basic; }
            set
            {
                if (value < 25000 || value > 60000)
                    throw new Exception("Manager basic must be between 25000 and 60000");
                base.Basic = value;
            }
        }

        // Constructor
        public Manager(string designation, string name, decimal basic, short deptNo)
            : base(name, basic, deptNo)
        {
            this.Designation = designation;
        }

        // Implement abstract method
        public override decimal CalcNetSalary()
        {
            return Basic * 2.0M; // Example formula for manager
        }
    }

    // ---------- GENERAL MANAGER CLASS -------------
    public class GeneralManager : Manager
    {
        private string perks;

        public string Perks
        {
            get { return perks; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Perks cannot be empty");
                perks = value;
            }
        }

        // Override Basic validation differently
        public override decimal Basic
        {
            get { return base.Basic; }
            set
            {
                if (value < 40000 || value > 90000)
                    throw new Exception("General Manager basic must be between 40000 and 90000");
                base.Basic = value;
            }
        }

        // Constructor
        public GeneralManager(string perks, string designation, string name, decimal basic, short deptNo)
            : base(designation, name, basic, deptNo)
        {
            this.Perks = perks;
        }

        // Override salary calculation
        public override decimal CalcNetSalary()
        {
            return Basic * 2.5M + 5000; // Includes perks bonus
        }
    }

    // ---------- CEO CLASS -------------
    public class CEO : Employee
    {
        // Override Basic validation differently
        public override decimal Basic
        {
            get { return base.Basic; }
            set
            {
                if (value < 60000)
                    throw new Exception("CEO basic must be >= 60000");
                base.Basic = value;
            }
        }

        // Constructor
        public CEO(string name, decimal basic, short deptNo)
            : base(name, basic, deptNo)
        {
        }

        // Override and seal so no further override possible
        public sealed override decimal CalcNetSalary()
        {
            return Basic * 3.5M;
        }
    }
}
