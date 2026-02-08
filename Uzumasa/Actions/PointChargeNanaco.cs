using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class PointChargeNanaco : PointCharge, IBalanceAction
    {
        public PointChargeNanaco()
            : base("nanaco Point Charge", PaymentMethod.nanaco) { }
        public PointChargeNanaco(string uid)
            : base(PaymentMethod.nanaco, uid) {}
    }
}
