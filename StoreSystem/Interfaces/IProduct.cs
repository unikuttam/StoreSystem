using StoreSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.Interfaces
{
    public interface IProduct
    {
        string Item { get; set; }
        int Price { get; set; }

        Discount Discount { get; set; }
    }
}
