namespace linqexample1
{
    internal class Program
    {
        public class Employee
        {
            public int EmpNo { get; set; }
            public string? Name { get; set; }
            public decimal Basic { get; set; }
            public int DeptNo { get; set; }
            public string? Gender { get; set; }
            public override string ToString()
            {
                string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
                return s;
            }
        }
        public class Department
        {
            public int DeptNo { get; set; }
            public string DeptName { get; set; }
        }
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();
        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }

        static void Main1()
        {
            AddRecs();

            var emps = from emp in lstEmp select emp;

            foreach (var items in emps)
            {
                Console.WriteLine(items);
            }

        }
        static void Main2()
        {
            AddRecs();

            var emps = from emp in lstEmp select new { emp.EmpNo, emp.Name, emp.Basic };

            foreach (var items in emps)
            {
                Console.WriteLine(items);
            }
        }
        static void Main3()
        {
            AddRecs();

            var emps = from emp in lstEmp where emp.Basic > 10000 select emp;

            foreach (var items in emps)
            {
                Console.WriteLine(items);
            }
        }
        static void Main4()
        {
            AddRecs();

            var emps = from emp in lstEmp where emp.Basic > 10000 && emp.Basic < 12000 select emp;

            foreach (var items in emps)
            {
                Console.WriteLine(items);
            }


        }
        static void Main5()
        {
            AddRecs();

            //var emps = from emp in lstEmp where emp.Basic > 10000 orderby emp.Name select emp;
            //var emps = from emp in lstEmp where emp.Basic > 10000 orderby emp.Name descending select emp;
            var emps = from emp in lstEmp where emp.Basic > 10000 orderby emp.EmpNo descending, emp.Name ascending select emp;

            foreach (var items in emps)
            {
                Console.WriteLine(items);
            }
        }
        static void Main6()
        {
            AddRecs();

            
            //var emps = from emp in lstEmp 
            //           join dept in lstDept
            //           on emp.DeptNo equals dept.DeptNo
            //           select new {emp ,dept};

            //var emps = from emp in lstEmp
            //           join dept in lstDept
            //           on emp.DeptNo equals dept.DeptNo
            //           select new { emp.Name, dept.DeptName };

            foreach (var items in emps)
            {
                Console.Write(items.Name + " ");
              
                Console.WriteLine(items.DeptName);
            }
        }
    }
}
