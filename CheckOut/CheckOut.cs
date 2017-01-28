using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckOut
{
    public class CheckOut : ICheckOut
    {
        private List<Sku> skus = new List<Sku>();

        public void Scan(string item)
        {
            var sku = Sku.Parse(item);


            skus.Add(sku);
        }

        public int GetTotalPrice()
        {
            int total = 0;

            var groupedSkus = skus.GroupBy(x => x.Value);

            foreach (var group in groupedSkus)
            {
                int scanItemsForGroup = 0;

                foreach (var groupedItem in group)
                {
                    scanItemsForGroup++;
                    total += groupedItem.GetUnitPrice(scanItemsForGroup);
                }
            }

            return total;
        }

    }
}
