using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Money
    {
        private decimal amount = 0;
        private string msg = "Money...pshhhh";
        public string GetMoney()
        {
            return msg + amount.ToString();
        }
        public Money(decimal amount)
        {
            this.amount = amount;
        }
    }
}
