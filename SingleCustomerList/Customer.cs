using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SingleCustomerList
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserStatus { get; set; }
        public string UserIdINN { get; set; }
        public string WorkingPosition { get; set; }
        public string Phone { get; set; }
        public string Detail { get; set; }
        public string OrganizationName { get; set; }
        //public Organization Orgname { get; set; }

        public virtual ICollection<Login> Logins { get; set; }

        public Customer()
        {
            Logins = new List<Login>();
        }
    }

}
