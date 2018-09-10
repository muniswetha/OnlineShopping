using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingDataAcessLayer
{
    public class GetAvailableItemsToDispaly
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int AvailableQuantity { get; set; }
        public int ProductPrice { get; set; }

        public int MaxQuantityPerOrder { get; set; }
        public int ProductCategoryName { get; set; }
        public int ProductSubCategoryName { get; set; }
    }
}
