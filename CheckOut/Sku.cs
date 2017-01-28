using Headspring;

namespace CheckOut
{
    public class Sku : Enumeration<Sku>
    {
        public static readonly Sku A = new Sku(1, "A", 50, 3, 30);
        public static readonly Sku B = new Sku(2, "B", 30, 2, 15);
        public static readonly Sku C = new Sku(3, "C", 20, 0, 0);
        public static readonly Sku D = new Sku(4, "D", 15, 0, 0);

        public int FullPrice;

        public int DiscountFrequency;

        public int DiscountPrice;

        private Sku(int value, string displayName, int fullPrice, int discountFrequency, int discountPrice): base(value, displayName)
        {
            FullPrice = fullPrice;
            DiscountFrequency = discountFrequency;
            DiscountPrice = discountPrice;
        }

        public int GetUnitPrice(int scanNumber)
        {
            bool isDiscounted = DiscountFrequency > 0 && scanNumber % DiscountFrequency == 0;

            return isDiscounted ? DiscountPrice : FullPrice;
        }

    }
}
