using StoreSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.Classes
{
    public class Product : IProduct
    {
        private string _item;
        private int _price;
        private Discount _discount;
        public Product(string item, int price, Discount discount)
        { Price = price; Item = item; Discount = discount;}
        public int Price{get {return _price;}set {_price = value;}}
        public string Item {get{return _item;} set {_item=value;}}
        public Discount Discount { get {return _discount;} set {_discount=value;} }
    }
}
