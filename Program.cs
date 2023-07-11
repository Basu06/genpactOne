using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Emp
    {
        public string FullName(string fname, string lname)
        {
            return fname + "" + lname;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            Console.WriteLine(emp.FullName("Sam", "Dicosta"));
            Console.WriteLine(emp.FullName(lname : "Dicosta", fname : "Sam"));
            Console.WriteLine(emp.FullName(lname: "Sharma", fname: "Vivek"));
            Console.WriteLine(emp.FullName(lname: "Sharma", fname: "Vivek"));
            Console.ReadKey();
        }
    }
}
