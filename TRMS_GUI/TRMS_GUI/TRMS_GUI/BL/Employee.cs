using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMS.BL
{
    class Employee : User
    {
        // A T T R I B U T E S
        protected string gmail;
        protected string phoneNo;
        protected string address;
        protected string city;

        // G E T T E R   S E T T E R
        public string Gmail { get => gmail; set => gmail = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }

        // O V E R R I D E
        public override string getRole()
        {
            return this.role;
        }

        // C O N S T R U C T O R
        public Employee() { }
        public Employee(string username, string password, string role, string gmail, string phoneNo, string address, string city) : base(username, password, role)
        {
            this.gmail = gmail;
            this.phoneNo = phoneNo;
            this.address = address;
            this.city = city;
        }

    }
}
