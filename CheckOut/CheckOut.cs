using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut
{
    public class CheckOut : ICheckOut
    {
        private List<Sku> skus = new List<Sku>();

        public void Scan(string item)
        {
            var sku = new Sku(item);

            if (item == "A")
            {
                sku.FullPrice = 50;
                sku.DiscountFrequency = 3;
                sku.DiscountPrice = 30;
                sku.ScanNumber = GetCountOfSkuTypeAlreadyScanned(item) + 1;
            }

            if (item == "B")
            {
                sku.FullPrice = 30;
                sku.DiscountFrequency = 2;
                sku.DiscountPrice = 15;
                sku.ScanNumber = GetCountOfSkuTypeAlreadyScanned(item) + 1;
            }

            if (item == "C")
            {
                sku.FullPrice = 20;
                sku.DiscountFrequency = 0;
                sku.DiscountPrice = 0;
                sku.ScanNumber = GetCountOfSkuTypeAlreadyScanned(item) + 1;
            }

            if (item == "D")
            {
                sku.FullPrice = 15;
                sku.DiscountFrequency = 0;
                sku.DiscountPrice = 0;
                sku.ScanNumber = GetCountOfSkuTypeAlreadyScanned(item) + 1;
            }

            skus.Add(sku);
        }

        public int GetTotalPrice()
        {
            return skus.Sum(x => x.GetUnitPrice());
        }

        private int GetCountOfSkuTypeAlreadyScanned(string skuType)
        {
            return skus.Count(x => x.SkuType == skuType);
        }
    }
}
