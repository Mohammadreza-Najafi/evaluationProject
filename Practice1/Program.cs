using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            new EmailNotification().inform();
            Console.WriteLine("==========================");

            Manager manager = Manager.GetInstance("Jaki");

            Programmer programmer1 = new Programmer("programmer1");
            Programmer programmer2 = new Programmer("programmer2");

            Employee employee1 = new Employee("employee1");
            Employee employee2 = new Employee("employee2");



            programmer1.ShowName();
            Console.WriteLine("==========================");
            programmer1.WritePosition();
            Console.WriteLine("==========================");
            programmer1.Dispose();
            Console.WriteLine("==========================");
            programmer2.ShowName();
            Console.WriteLine("==========================");
            programmer2.WritePosition();
            Console.WriteLine("==========================");
            programmer2.Dispose();
            Console.WriteLine("==========================");

            employee1.ShowManagerName();
            Console.WriteLine("==========================");
            employee1.ShowName();
            Console.WriteLine("==========================");


            manager.ShowNumEmployee();
          

            Console.ReadKey();
        }
    }
}
