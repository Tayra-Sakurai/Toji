using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class CashPayment : Payment, IBalanceAction
    {
        public CashPayment()
            : base(PaymentMethod.Cash)
        {
            Title = "PaymentByCash";
        }

        public CashPayment(string uid)
            : base(uid, PaymentMethod.Cash)
            { }
    }
}
