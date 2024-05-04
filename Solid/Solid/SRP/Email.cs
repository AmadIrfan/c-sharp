using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.BL
{
    internal class Email
    {
        String id;
        String mail;
        String body;
        String subject;
        public Email(String id, String mail,String body,String subject) {
            this.subject = subject;
            this.id = id;
            this.mail = mail;
            this.body = body;
        }

        public String Id { get => id; set => id = value; }
        public String Mail { get => mail; set => mail = value; }
        public String Body { get => body; set => body = value; }
        public String Subject { get => subject; set => subject = value; }
    }
}
