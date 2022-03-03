using Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class ShiftSource
    {
        public int ShiftId { get; set; }
        public int MedicId { get; set; }
        public string MedicName { get; set; }
        public string Profession { get; set; }
        public string Specialization { get; set; }
    }
}
