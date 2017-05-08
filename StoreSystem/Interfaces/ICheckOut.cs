namespace StoreSystem
{
    public interface ICheckOut
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}