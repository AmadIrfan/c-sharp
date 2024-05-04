using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalper.BL
{
    abstract class person
    {
      public string firstName;
        protected string lastName;
        public person()
        {
        }
        public person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public abstract void printDetail();
    }
}
