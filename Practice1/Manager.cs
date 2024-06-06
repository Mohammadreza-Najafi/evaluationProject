using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Manager : IDisposable, Personnel
    {
        private static Manager instance;

        public static bool InstanceExists = false;

        private string m_name;
        public string Name {
            get {
                return m_name;
            }
            set {
                m_name=value;
            }

        }

        private int NumEmployee;

        public void ShowName()
        {
            Console.WriteLine("Name : " + this.Name);
        }

        public void ShowNumEmployee()
        {
            int EmployeeCount = Employee.GetCount();
            if (EmployeeCount > 0)
            {
                this.NumEmployee = Employee.GetCount();
                Console.WriteLine("Number Of Employee : " + this.NumEmployee);
            }
            else
            {
                Console.WriteLine("We do not have an office worker yet.");
            }
            
        }

        public void WritePosition()
        {
            Console.WriteLine("Position : Programmer");
        }

        private Manager(string name)
        {
            this.Name = name;
        }

        public static Manager GetInstance(string name = "")
        {
            if (instance == null)
            {
                instance = new Manager(name);
                InstanceExists = true;

            }
            return instance;
        }

        public void Dispose()
        {
            Console.WriteLine("User Exit : ");
            Console.WriteLine(this.Name);
            WritePosition();

        }
    }
}
