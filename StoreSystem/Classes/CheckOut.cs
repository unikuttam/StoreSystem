using StoreSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks

namespace StoreSystem.Classes
{
    public class CheckOut : ICheckOut
    {
        public IList<Product> ProductItems
        {
            get { return _productItems; }
            set { _productItems = value; }
        }
        private IList<string> _scannedItems = new List<string>();
        private IList<Product> _productItems;
        private Dictionary<string, int> _basket = new Dictionary<string, int>();

        public int GetTotalPrice()
        {
            int total = 0;
            if (_scannedItems == null || _scannedItems.Count == 0)
                return 0;

            foreach (Product p in _productItems)
            {
                int count = _scannedItems.Count(s => s.Contains(p.Item));
                _basket.Add(p.Item, count);
            }
            total = GetAppliedDiscountedTotal(_basket);
            return total;
        }

        private int GetAppliedDiscountedTotal(Dictionary<string, int> basket)
        {
            int total = 0;
            foreach (string key in basket.Keys )
            {
                for(int i = 0; i!=_productItems.Count; i++)
                {
                    if(_productItems[i].Item==key)
                    {
                        if(_productItems[i].Discount==null)
                        {
                            total += basket[key] * _productItems[i].Price;
                        }
                        else
                        {
                            total+=basket[key] % _productItems[i].Discount.Quantity * _productItems[i].Price +
                                basket[key] / _productItems[i].Discount.Quantity * _productItems[i].Discount.DiscountPrice;
                        }
                    }
                }
            }
            return total;
        }

        public void Scan(string item)
        {
            _scannedItems.Add(item);
        }
    }
}
