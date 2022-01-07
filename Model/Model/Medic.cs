using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Model.Model
{
    public class Medic : Employee
    {
        public List<Shift> Shift { get; set; }
    }
}
