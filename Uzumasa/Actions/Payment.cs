using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class Payment : BalanceAction
    {
        public Payment(PaymentMethod paymentMethod)
            : base()
        {
            Title = "Payment";
            CashState = TriState.StateNeutral;
            IcocaState = TriState.StateNeutral;
            NanacoState = TriState.StateNeutral;
            CoopState = TriState.StateNeutral;
            switch (paymentMethod)
            {
                case PaymentMethod.Cash:
                    CashState = TriState.StateFalse;
                    break;
                case PaymentMethod.ICOCA:
                    IcocaState = TriState.StateFalse;
                    break;
                case PaymentMethod.nanaco:
                    NanacoState = TriState.StateFalse;
                    break;
                case PaymentMethod.COOP:
                    CoopState = TriState.StateFalse;
                    break;
                default:
                    throw new ArgumentException($"{paymentMethod} is not supported.");
            }
        }

        public Payment(string uid, PaymentMethod paymentMethod)
            : this(paymentMethod)
        {
            Uid = uid;
        }
    }
}
