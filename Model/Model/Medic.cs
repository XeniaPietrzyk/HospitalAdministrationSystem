using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Model.Model
{
    [DataContract]
    public class Medic : Employee
    {
        [DataMember]
        public List<Shift> Shift { get; set; }
    }
}
