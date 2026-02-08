using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class CoopPayment : Payment
    {
        public CoopPayment()
            : base(PaymentMethod.COOP)
        {
            Title = "Payment by CO-OP e-Money";
        }

        public CoopPayment(string uid)
            : base(uid, PaymentMethod.COOP)
            { }
    }
}
