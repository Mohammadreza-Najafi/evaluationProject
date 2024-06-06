using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Programmer :IDisposable ,Personnel
    {

        public string Name { get; set; }

        private string ManagerName;

        public void ShowName()
        {
            Console.WriteLine("Name : "+ this.Name);
        }

        public void ShowManagerName()
        {
            Console.WriteLine("Manager Name : " +this.ManagerName);
        }

        public void WritePosition()
        {
            Console.WriteLine("Position : Programmer");
        }

        public Programmer(string name)
        {
            this.Name = name;

            try
            {
                if (Manager.InstanceExists)
                {
                    Manager manager = Manager.GetInstance();
                    this.ManagerName = manager.Name;
                }
                else
                {
                    this.ManagerName = "We do not have a manager yet";
                }

            } catch (Exception e)
            {
                this.ManagerName = "We do not have a manager yet";
            }
            
        }

        public void Dispose()
        {
            Console.WriteLine("User Exit : ");
            Console.WriteLine(this.Name);
            WritePosition();

        }

      


    }
}
