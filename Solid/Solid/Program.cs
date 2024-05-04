using Solid.DIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 DIP
            /* SmsNotification smsNotification = new SmsNotification();
             NotificationServices smsNotificationServices = new NotificationServices(smsNotification);
             smsNotificationServices.notificaionSender("this is smsNotification");
             NotificationServices emailNotificationServices = new NotificationServices(smsNotification);
             emailNotificationServices.notificaionSender("this is emailNotification");
            */

            /*Computer obj = new Computer(new Wirelesskeboard(),new WiredMouse());
           */
            Singleton s= Singleton.getInstnce();
            s.Print();
            Singleton s1= Singleton.getInstnce();
            Console.ReadLine();
        }
    }
}
