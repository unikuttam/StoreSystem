using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem
{
    public class CheckOut : ICheckOut
    {
        private IList<string> _scannedItems = new List<string>();
       
        public int GetTotalPrice()
        {
            if (_scannedItems == null || _scannedItems.Count == 0)
                return 0;
            else
                return - 1;
        }

        public void Scan(string item)
        {
            _scannedItems.Add(item);
        }
    }
}
