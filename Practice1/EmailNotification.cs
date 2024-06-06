using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class EmailNotification:Notification
    {
        public void inform()
        {
            Console.WriteLine("Email : Notification is done via Email");
        }
    }
}
