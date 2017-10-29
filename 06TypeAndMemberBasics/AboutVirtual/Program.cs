using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyB.BetterPhone phone = new CompanyB.BetterPhone();
            phone.Dial();

            Console.ReadKey();

        }

        static void Test1()
        {

            Employee.Lookup(string.Empty);
            Lvrh.Lookup(string.Empty);

            var e = new Employee();
            e.GetProgressReport();
            e.GetEmployedName();
            e.GetYearsEmployed();


            var lvrh = new Lvrh();
            lvrh.GetProgressReport();
            lvrh.GetEmployedName();
            lvrh.GetYearsEmployed();

            Employee emp = new Lvrh();
            emp.GetProgressReport();
            emp.GetEmployedName();
            ((Lvrh)emp).GetEmployedName();
            emp.GetYearsEmployed();

            Console.ReadKey();
        }
    }
}
