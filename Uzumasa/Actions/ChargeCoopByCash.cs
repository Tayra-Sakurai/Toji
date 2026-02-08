using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class ChargeCoopByCash : ChargeByCash, IBalanceAction
    {
        public ChargeCoopByCash()
            : base(PaymentMethod.COOP)
        {
            Title = "Charge CO-OP e-Money by Cash";
        }

        public ChargeCoopByCash(string uid)
            : base(PaymentMethod.COOP, uid)
        { }
    }
}
