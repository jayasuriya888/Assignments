using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInfo e1 = new EmployeeInfo { Name = "Deepak", Dept = "Training", Salary = 15000 };
            EmployeeInfo e2 = new EmployeeInfo { Name = "Martin", Dept = "Accouont", Salary = 18000 };
            CodeDBEntities db = new CodeDBEntities();
            db.EmployeeInfos.Add(e1);
            db.EmployeeInfos.Add(e2);
            var reult = db.SaveChanges();
            if (reult > 0)
                Console.WriteLine("Data Inserted.");
        }
    }
}
