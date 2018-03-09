using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SingleCustomerList
{
    public class Login
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Region Region { get; set; }
        public City City { get; set; }
        public Category Category { get; set; }
        public string Number { get; set; }
        public string FormatLogin { get; set; }
        public bool IsActive { get; set; }
        public void BuildLogin()
        {
            FormatLogin = $"{Region.LoginRegion}{City.LoginCode}{Category.LoginCategory}{Number}";
        }

        public Customer Customer { get; set; }
    }
}