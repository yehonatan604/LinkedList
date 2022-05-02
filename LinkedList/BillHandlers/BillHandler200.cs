using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class BillHandler200 : BillHandler
    {
        public BillHandler200()
        {
            data = 200;
        }
        public override void HandleRequest(int amount)
        {
            int newAmount = amount / data;
            if (amount >= data)
            {
                Console.WriteLine($"Giving {data} * {newAmount}");
            }
            if (amount % data > 0)
            {
                if (next != null)
                {
                    amount -= newAmount * data;
                    next.HandleRequest(amount);
                }
            }
        }
    }
}
