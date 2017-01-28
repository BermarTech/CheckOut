using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut
{
    public class CheckOut : ICheckOut
    {
        public void Scan(string item)
        {
            
        }

        public int GetTotalPrice()
        {
            return 50;
        }
    }
}
