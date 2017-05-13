using StoreSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int GetTotalPrice()
        {
            int total = 0;
            IDictionary<string, int> basket = new Dictionary<string, int>();            
            if (_scannedItems == null || _scannedItems.Count == 0)
                return 0;

            foreach (Product p in _productItems)
            {
                int count = _scannedItems.Count(s => s.Contains(p.Item));
                basket.Add(p.Item, count);
            }
            total = GetAppliedDiscountedTotal(basket);
            return total;
        }

        private int GetAppliedDiscountedTotal(IDictionary<string, int> basket)
        {
            foreach (Product p in _productItems)
            {
                if(p.Discount!=null)
                {

                }
            }
            return 0;
        }

        public void Scan(string item)
        {
            _scannedItems.Add(item);
        }
    }
}
