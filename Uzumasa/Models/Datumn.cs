using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzumasa.Models
{
    public class Datumn : IComparable<Datumn>
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public string Item { get; set; } = string.Empty;
        public double Cash { get; set; } = 0;
        public double Icoca { get; set; } = 0;
        public double Nanaco { get; set; } = 0;
        public double Coop { get; set; } = 0;

        public int CompareTo(Datumn other)
        {
            int result = DateTime.CompareTo(other.DateTime);
            if (result != 0) return result;
            return Id.CompareTo(other.Id);
        }
    }
}
