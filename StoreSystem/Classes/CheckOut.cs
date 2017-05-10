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
            if (_productItems == null || _productItems.Count == 0)
                return 0;
            
            foreach(Product p in _productItems)
            {
                total = _productItems.Sum(x => x.Price);
            }
            return total;
        }

        public void Scan(string item)
        {
            _scannedItems.Add(item);
        }
    }
}
