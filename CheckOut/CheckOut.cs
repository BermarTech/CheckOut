using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut
{
    public class CheckOut : ICheckOut
    {
        private int total = 0;

        public void Scan(string item)
        {
            if (item == "A")
            {
                total += 50;
            }

            if (item == "B")
            {
                total += 30;
            }

            if (item == "C")
            {
                total += 20;
            }

            if (item == "D")
            {
                total += 15;
            }
        }

        public int GetTotalPrice()
        {
            return total;
        }
    }
}
