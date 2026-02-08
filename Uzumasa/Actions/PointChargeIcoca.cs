using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class PointChargeIcoca : PointCharge, IBalanceAction
    {
        public PointChargeIcoca()
            : base("ICOCA Point Charge", PaymentMethod.ICOCA) { }
        public PointChargeIcoca(string uid)
            : base(PaymentMethod.ICOCA, uid) { }
    }
}
