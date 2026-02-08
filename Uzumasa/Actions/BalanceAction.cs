using Microsoft.UI.Xaml;
using Microsoft.Windows.ApplicationModel.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzumasa.Models;

namespace Uzumasa.Actions
{
    public class BalanceAction : IBalanceAction
    {
        /// <summary>
        /// The title of action.
        /// </summary>
        public string Title { get; set; }

        public TriState CashState { get; init; }
        public TriState IcocaState { get; init; }
        public TriState NanacoState { get; init; }
        public TriState CoopState { get; init; }

        public BalanceAction(string title, TriState cashState, TriState icocaState, TriState nanacoState, TriState coopState)
        {
            Title = title;
            CashState = cashState;
            IcocaState = icocaState;
            NanacoState = nanacoState;
            CoopState = coopState;
        }

        public BalanceAction(TriState cashState, TriState icocaState, TriState nanacoState, TriState coopState, string uid)
        {
            CashState= cashState;
            IcocaState= icocaState;
            NanacoState= nanacoState;
            CoopState= coopState;
            Uid = uid;
        }

        public BalanceAction(string uid)
        {
            Uid = uid;
        }

        public BalanceAction() { }

        /// <summary>
        /// Localize the title.
        /// </summary>
        public string Uid
        {
            set
            {
                ResourceLoader loader = new("Actions");
                Title = loader.GetString(value);
            }
        }

        public bool Execute(ref Datumn datumn, double value)
        {
            try
            {
                datumn.Cash = (int)CashState * value;
                datumn.Icoca = (int)IcocaState * value;
                datumn.Nanaco = (int)NanacoState * value;
                datumn.Coop = (int)CoopState * value;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
