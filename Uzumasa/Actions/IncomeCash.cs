using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uzumasa.Models;

namespace Uzumasa.Actions
{
    public class IncomeCash : BalanceAction, IBalanceAction
    {
        public IncomeCash()
            : base("IncomeCash", TriState.StateTrue, TriState.StateNeutral, TriState.StateNeutral, TriState.StateNeutral)
        {
        }

        public IncomeCash(string uid)
            : base(uid)
        {
            CashState = TriState.StateTrue;
            IcocaState = TriState.StateNeutral;
            NanacoState = TriState.StateNeutral;
            CoopState = TriState.StateNeutral;
        }
    }
}
