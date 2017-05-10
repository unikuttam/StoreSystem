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

        public Product(string item, int price)
        { _price = price; _item = item; }
        public int Price
        {
            get { return _price;}
            set { _price = value; }
        }
            //=> throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Item { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string It { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
