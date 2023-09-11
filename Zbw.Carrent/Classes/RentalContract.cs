using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.Carrent.Classes
{
    public class RentalContract
    {
        public int Id { get; set; }
        public uint DurationDays { get;set; }
        public Decimal TotalCoast { get;set; }
    }
}
