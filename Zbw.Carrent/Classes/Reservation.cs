using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.Carrent.Classes
{
    public class Reservation
    {
        public int Id { get; set; }
        public uint DurationInDays { get; set; }
        public decimal TotalCoast { get; set; }

    }
}
