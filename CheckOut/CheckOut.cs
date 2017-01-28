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
                sku.UnitPice = 50;
            }

            if (item == "B")
            {
                sku.UnitPice = 30;
            }

            if (item == "C")
            {
                sku.UnitPice = 20;
            }

            if (item == "D")
            {
                sku.UnitPice = 15;
            }

            skus.Add(sku);
        }

        public int GetTotalPrice()
        {
            return skus.Sum(x => x.UnitPice);
        }
    }
}
