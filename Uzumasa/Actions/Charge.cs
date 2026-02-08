using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Actions
{
    public class Charge : BalanceAction
    {
        public Charge(PaymentMethod charged, PaymentMethod chargeMethod)
            : base()
        {
            CashState = TriState.StateNeutral;
            IcocaState = TriState.StateNeutral;
            NanacoState = TriState.StateNeutral;
            CoopState = TriState.StateNeutral;
            switch (charged)
            {
                case PaymentMethod.ICOCA:
                    IcocaState = TriState.StateTrue;
                    break;
                case PaymentMethod.nanaco:
                    NanacoState= TriState.StateTrue;
                    break;
                case PaymentMethod.COOP:
                    CoopState= TriState.StateTrue;
                    break;
                default:
                    throw new ArgumentException($"{charged} cannot be charged.");
            }
            switch (chargeMethod)
            {
                case PaymentMethod.None:
                    break;
                case PaymentMethod.Cash:
                    CashState = TriState.StateFalse;
                    break;
                default:
                    throw new ArgumentException($"{chargeMethod} is not supported.");
            }
        }

        public Charge(string title, PaymentMethod charged, PaymentMethod chargeMethod)
            : this(charged, chargeMethod)
        {
            Title = title;
        }

        public Charge(PaymentMethod charged, PaymentMethod chargeMethod, string uid)
            : this(charged, chargeMethod)
        {
            Uid = uid;
        }
    }
}
