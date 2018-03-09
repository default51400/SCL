using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SingleCustomerList
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public string OrgName { get; set; }
        public string OrgShortName { get; set; }
        public string OrgStatus { get; set; }
        public string OrgCategory { get; set; }
        public string OrgCodeRc { get; set; }
        public string OrgRegion { get; set; }
        public string OrgAdress { get; set; }
        public string OrgPhone { get; set; }
        public string OrgEDRPOY { get; set; }
        public string OrgDetail { get; set; }

        //сменил муорг без му + ид так же



        //почитать про migration 

        /*навигационные свойства*/
        //public ICollection<MyCustomer> MYCustomersCl { get; set; }
        //public MyOrganization()
        //{
        //    MYCustomersCl = new List<MyCustomer>();
        //}
    }
}
