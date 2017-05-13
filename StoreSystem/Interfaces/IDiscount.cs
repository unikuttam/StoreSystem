using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.Interfaces
{
    interface IDiscount
    {
        int Quantity { get; set; }
        string DiscountCode { get; set; }
        int DiscountPrice { get; set; }
    }
}
