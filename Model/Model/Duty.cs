using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Duty
    {
        public int Id { get; set; }
        public DateTime Term { get; set; }
        public List<Shift> Shifts { get; set; }
    }
}
