using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class ChargeIcocaByCash : ChargeByCash, IBalanceAction
    {
        public ChargeIcocaByCash()
            : base(PaymentMethod.ICOCA)
        {
            Title = "ICOCA charge by Cash";
        }

        public ChargeIcocaByCash(string uid)
            : base(PaymentMethod.ICOCA, uid)
            { }
    }
}
