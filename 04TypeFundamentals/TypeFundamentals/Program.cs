using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Employee();
            Employee e;
            if(p is Employee)
            {
                e = (Employee)p;
            }
        }
    }
    internal class Person
    {
    }
    internal class Employee : Person
    {
    }
    internal class Manager : Employee
    {
    }
}
