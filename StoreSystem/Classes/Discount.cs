using StoreSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.Classes
{
    public class Discount : IDiscount
    {
        private int _quantity;
        private string _discountCode;
        private int _discountPrice;
        public Discount(string discountCode, int quantity, int discountPrice)
        { DiscountCode = discountCode; Quantity = quantity;DiscountPrice = discountPrice;}
        public int Quantity { get { return _quantity; } set { _quantity = value; } }
        public string DiscountCode { get { return _discountCode; } set { _discountCode = value; } }
        public int DiscountPrice { get { return _discountPrice; } set { _discountPrice = value; } }
    }
}
