using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class ChargeByCash : Charge, IBalanceAction
    {
        public ChargeByCash(PaymentMethod paymentMethod)
            : base(paymentMethod, PaymentMethod.Cash)
        {
            Title = "Charge by Cash";
        }

        public ChargeByCash(PaymentMethod paymentMethod, string uid)
            : base(paymentMethod, PaymentMethod.Cash, uid)
            { }
    }
}
