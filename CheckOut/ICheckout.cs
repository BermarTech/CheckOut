
namespace CheckOut
{
    interface ICheckOut
    {
        void Scan(string item);

        int GetTotalPrice();
    }
}
