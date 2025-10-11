namespace LinqExample2
{
    internal class Program
    {
        public class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
            public decimal Basic { get; set; }
            public int DeptNo { get; set; }
            public string Gender { get; set; }
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

        static Employee GetEmployee(Employee obj)
        {
            return obj;
        }
        static string GetEmployeeName(Employee obj)
        {
            return obj.Name;
        }
        static void Main1()
        {
            AddRecs();
            //var emps = from emp in lstEmp select emp;

            var emps = lstEmp.Select(GetEmployee);
            var emps2 = lstEmp.Select(delegate(Employee obj)
            {
                return obj;
            });
            var emps3 = lstEmp.Select(obj=>obj);
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }
        static void Main2()
        {
            AddRecs();
            //var emps = from emp in lstEmp select emp.EmpNo;

            var emps = lstEmp.Select(GetEmployeeName);
            var emps2 = lstEmp.Select(delegate (Employee obj)
            {
                return obj.Name;
            });
            var emps3 = lstEmp.Select(obj => obj.Name);

            //var emps = from emp in lstEmp select emp.Name;
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }
        static void Main3()
        {
            AddRecs();
            //var emps = from emp in lstEmp select new { emp.EmpNo, emp.Name };

            var emps = lstEmp.Select(delegate(Employee obj)
            {
                return new { obj.EmpNo, obj.Name };
            } );

            var emps2 = lstEmp.Select(obj => new { obj.EmpNo, obj.Name });

            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }

        static bool IsBasicGreaterThan10000(Employee obj)
        {
            return obj.Basic > 10000;
        }
        static void Main4()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       where emp.Basic > 10000
                       select emp;

            var emps1 = lstEmp.Where(IsBasicGreaterThan10000);
            var emps2 = lstEmp.Where(delegate(Employee obj)
            {
                return obj.Basic > 10000;
            });

            var emps3a = lstEmp.Where(obj => obj.Basic > 10000);
            var emps3b = lstEmp.Where(obj => obj.Basic > 10000).Select(obj=>obj);
            var emps3c = lstEmp.Select(obj => obj).Where(obj => obj.Basic > 10000);


            var emps4b = lstEmp.Where(obj => obj.Basic > 10000).Select(obj => obj.Name);
            //var emps4c = lstEmp.Select(obj => obj.Name).Where(obj => obj.Basic > 10000);

            var emps5b = lstEmp.Where(obj => obj.Basic > 10000).Select(obj => obj.Basic);
            //var emps5c = lstEmp.Select(obj => obj.Basic).Where(obj => obj.Basic > 10000);
            var emps5d = lstEmp.Select(obj => obj.Basic).Where(obj => obj > 10000);

            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
        }

        static void Main5()
        {
            AddRecs();
            var emps = from emp in lstEmp
                           //where emp.Basic > 10000
                       orderby emp.Name
                       select emp;

            var emps1 = lstEmp.OrderBy(obj => obj.Name);
            var emps2 = lstEmp.OrderByDescending(obj => obj.Name);
            var emps3 = lstEmp.OrderBy(obj => obj.DeptNo).ThenByDescending(obj=>obj.Name);

            //var emps = from emp in lstEmp
            //           orderby emp.Name descending
            //           select emp;

            //var emps = from emp in lstEmp
            //           orderby emp.DeptNo ascending, emp.Name descending
            //           select emp;
            foreach (var emp in emps)
            {
                Console.WriteLine(emp);
            }

            Console.ReadLine();
        }

        static void Main()
        {
            AddRecs();
            var emps = from emp in lstEmp
                       join dept in lstDept
                       on emp.DeptNo equals dept.DeptNo
                       select new { emp, dept };

            //var emps = from  in 
            //           join  in 
            //           on  equals 
            //           select ;
            var emps2a = lstEmp.Join(lstDept, emp => emp.DeptNo,
                dept => dept.DeptNo, (emp, dept) => new { emp, dept });

          

            foreach (var item in emps)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);

            }


            foreach (var item in emps)
            {
                Console.WriteLine(item.emp.Name);
                Console.WriteLine(item.dept.DeptName);
            }
            //var emps2 = from emp in lstEmp
            //            join dept in lstDept
            //            on emp.DeptNo equals dept.DeptNo
            //            select new { emp.Name, dept.DeptName };

            var emps2e = lstEmp.Join(lstDept, emp => emp.DeptNo, dept => dept.DeptNo, (emp, dept) => new { emp.Name, dept.DeptName });
            foreach (var item in emps2e)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DeptName);

            }





        }

        //deferred execution
        static void Main6()
        {
            AddRecs();
            var emps = from emp in lstEmp select emp;

            Console.WriteLine();
            lstEmp.RemoveAt(0);

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Name + "," + emp.EmpNo);
            }
            Console.ReadLine();


            Console.WriteLine();
            lstEmp.Add(new Employee { EmpNo = 9, Name = "New", Basic = 11000, DeptNo = 40, Gender = "F" });
            foreach (var emp in emps)
            {

                Console.WriteLine(emp.Name + "," + emp.EmpNo);
            }
            Console.ReadLine();
        }

        //immediate execution
        static void Main7()
        {
            AddRecs();
            //var emps
            //from emp in lstEmp select emp;
            var emps = (from emp in lstEmp select emp);

            //immediate execution
            //emps = emps.ToList();  //.ToArray .ToDictionary
            //Employee[] arrEsmp = emps.ToArray();
            Dictionary<int, Employee> d = emps.ToDictionary(e => e.EmpNo);

            Console.WriteLine();
            lstEmp.RemoveAt(0);
            foreach (var emp in d)
            {
                //Console.WriteLine(emp.Name + "," + emp.EmpNo);
                Console.WriteLine($"key : {emp.Key}, value: {emp.Value}");
            }
           
            Console.ReadLine();
            Console.WriteLine();
            lstEmp.Add(new Employee { EmpNo = 9, Name = "New", Basic = 11000, DeptNo = 40, Gender = "F" });
            Console.WriteLine("\nnew data inserted");

            Console.WriteLine();
            foreach (var emp in d)
            {
                //Console.WriteLine(emp.Name + "," + emp.EmpNo);
                Console.WriteLine($"key : {emp.Key}, value: {emp.Value}");
            }
            Console.ReadLine();
        }
    }
}
