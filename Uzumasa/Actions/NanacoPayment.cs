using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class NanacoPayment : Payment, IBalanceAction
    {
        public NanacoPayment()
            : base(PaymentMethod.nanaco)
        {
            Title = "PaymentByNanaco";
        }

        public NanacoPayment(string uid)
            : base(uid, PaymentMethod.nanaco) { }
    }
}
