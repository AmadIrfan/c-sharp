using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DIP
{
    internal class NotificationServices
    {
        INotification iNotification;
        public NotificationServices(INotification iNotification) {
            this.iNotification = iNotification;
        }
       public void notificaionSender(String message) {
            iNotification.sendNotification(message);
        }
    }
}
