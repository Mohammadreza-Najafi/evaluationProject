using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class SMSNotification : Notification
    {
        public void inform()
        {
            Console.WriteLine("SMS : Notification is done via SMS");
        }
    }
}
