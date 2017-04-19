using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueeFormApp
{
    class Customer
    {
        private int serial;
        private string name;
        private string complain;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Complain
        {
            get { return complain; }
            set { complain = value; }
        }

        public int Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        public Customer (int serial,string name, string complain)
        {
            this.Serial = serial;
            this.Name = name;
            this.Complain = complain;
        }
    }
}
