using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzumasa.Models;

namespace Uzumasa.Actions
{
    public interface IBalanceAction
    {
        public string Title { get; set; }
        public TriState CashState { get; init; }
        public TriState IcocaState { get; init; }
        public TriState NanacoState { get; init; }
        public TriState CoopState { get; init; }
        public string Uid { set; }

        /// <summary>
        /// Sets the balance value as the action determines.
        /// </summary>
        /// <param name="datumn">The datumn to be set.</param>
        /// <param name="value">The amount.</param>
        /// <returns>Returns <see cref="true"/> if the function is executed successfully; otherwise, returns <see cref="false"/>.</returns>
        public bool Execute(ref Datumn datumn, double value); 
    }
}
