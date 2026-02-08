using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class IcocaPayment : Payment
    {
        public IcocaPayment()
            : base(PaymentMethod.ICOCA)
        {
            Title = "PaymentByICOCA";
        }

        public IcocaPayment(string uid)
            : base(uid, PaymentMethod.ICOCA)
            { }
    }
}
