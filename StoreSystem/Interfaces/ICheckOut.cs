using StoreSystem.Classes;
using System.Collections.Generic;

namespace StoreSystem.Interfaces
{
    public interface ICheckOut
    {
        void Scan(string item);
        int GetTotalPrice();
        IList<Product> ProductItems { get; set; }
    }
}