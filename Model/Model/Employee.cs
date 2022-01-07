using Model.Helpers;
using System;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public long Pesel { get; set; }
        public Sex Sex { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public Permission Permission { get; set; }
    }
}
