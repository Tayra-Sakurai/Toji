using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class ChargeNanacoByCash : ChargeByCash, IBalanceAction
    {
        public ChargeNanacoByCash()
            : base(PaymentMethod.nanaco)
        {
            Title = "Charge nanaco by Cash";
        }

        public ChargeNanacoByCash(string uid)
            : base(PaymentMethod.nanaco, uid) { }
    }
}
