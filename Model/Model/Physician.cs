using Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [DataContract]
    public class Physician : Medic
    {
        [DataMember]
        public Specialization Specialization { get; set; }
        [DataMember]
        public int PWZNumber { get; set; }
    }
}
