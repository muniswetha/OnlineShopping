using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingDataAcessLayer.Views
{
    public class UserDetailsViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PinCode { get; set; }
        public string PhoneNo { get; set; }
        public string AlternatePhoneNo { get; set; }
        public int Fax { get; set; }
        public int FirstSQId { get; set; }
        public string FirstSQAnswer { get; set; }
        public int SecondSQId { get; set; }
        public string SecondSQAnswer { get; set; }
        public int ThirdSQId { get; set; }
        public string ThirdSQAnswer { get; set; }

    }
}
