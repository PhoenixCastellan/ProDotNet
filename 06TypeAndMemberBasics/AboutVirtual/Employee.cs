using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutVirtual
{
    internal class Employee
    {
        // A nonvirtual instance method
        public void GetYearsEmployed()
        {
            Console.WriteLine(1);
        }
        // A nonvirtual instance method
        public void GetEmployedName()
        {
            Console.WriteLine("Employee");
        }
        // A virtual method (virtual implies instance)
        public virtual void GetProgressReport()
        {
            Console.WriteLine("Employee.GetProgressReport");
        }


        // A static method
        public static Employee Lookup(String name) {
            return new Employee();
        }
    }

    internal class Lvrh : Employee
    {
        // A nonvirtual instance method
        public new void GetYearsEmployed()
        {
            Console.WriteLine(1);
        }
        // A nonvirtual instance method
        public new void GetEmployedName(string name)
        {
            Console.WriteLine("Lvrh");
        }
        // A nonvirtual instance method
        public new void GetEmployedName()
        {
            Console.WriteLine("Lvrh");
        }
        // A virtual method (virtual implies instance)
        public override void GetProgressReport()
        {
            Console.WriteLine("Lvrh.GetProgressReport");
        }
    }
}
