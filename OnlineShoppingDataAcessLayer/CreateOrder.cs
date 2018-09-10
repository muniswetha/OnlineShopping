using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingDataAcessLayer
{
    class CreateOrder
    {
        public int BillAmount { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PinCode { get; set; }
        public string PhoneNo { get; set; }
        public int ProductId { get; set; }
        public int OrderedQuantity { get; set; }



    }
}
