
namespace CheckOut
{
    public class Sku
    {
        public string SkuType;

        public int FullPrice;

        public int DiscountFrequency;

        public int DiscountPrice;

        public int ScanNumber;

        public Sku(string skuType)
        {
            SkuType = skuType;
        }

        public int GetUnitPrice()
        {
            bool isDiscounted = DiscountFrequency > 0 && ScanNumber % DiscountFrequency == 0;

            return isDiscounted ? DiscountPrice : FullPrice;
        }
    }
}
