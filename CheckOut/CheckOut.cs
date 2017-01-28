using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut
{
    public class CheckOut : ICheckOut
    {
        private int total;

        public void Scan(string item)
        {
            if (item == "A")
            {
                total = 50;
            }

            if (item == "B")
            {
                total = 30;
            }
        }

        public int GetTotalPrice()
        {
            return total;
        }
    }
}
