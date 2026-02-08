using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class PointChargeCoop : PointCharge, IBalanceAction
    {
        public PointChargeCoop()
            : base("Point Charge CO-OP e-Money", PaymentMethod.COOP) { }
        public PointChargeCoop(string uid)
            : base(PaymentMethod.COOP, uid) { }
    }
}
