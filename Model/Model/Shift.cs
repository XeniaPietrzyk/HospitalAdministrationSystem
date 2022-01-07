using System;
using System.Collections.Generic;

namespace Model.Model
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime ShiftDate { get; set; }
        public List<Medic> Medic { get; set; }
    }
}
