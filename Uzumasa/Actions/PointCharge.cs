using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class PointCharge : Charge, IBalanceAction
    {
        public PointCharge(string title, PaymentMethod charged)
            : base(title, charged, PaymentMethod.None) { }
        public PointCharge(PaymentMethod charged, string uid)
            : base(charged, PaymentMethod.None, uid) { }
    }
}
