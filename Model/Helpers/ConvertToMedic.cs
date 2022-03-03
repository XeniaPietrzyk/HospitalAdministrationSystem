using Model.Model;
using System;

namespace Model.Helpers
{
    public class ConvertToMedic
    {
        public ConvertToMedic(Employee employee)
        {
            this.employee = employee;
        }
        public ConvertToMedic(Nurse nurse, Physician physician)
        {
            this.nurse = nurse;
            this.physician = physician;
        }

        public ConvertToMedic(Nurse nurse)
        {
            this.nurse = nurse;
        }

        public ConvertToMedic(Physician physician)
        {
            this.physician = physician;
        }

        private Nurse nurse { get; set; }
        private Physician physician { get; set; }
        private Employee employee { get; set; }

        public Medic ConvertEmployee()
        {
            Medic medic = new Medic();
            medic.Id = employee.Id;
            medic.Name = employee.Name;
            medic.Pesel = employee.Pesel;
            medic.Sex = employee.Sex;
            medic.Permission = employee.Permission;
            medic.EmployeeType = employee.EmployeeType;
            return medic;
        }
        public Medic ConvertNurse()
        {
            Medic medic = new Medic();
            medic.Id = nurse.Id;
            medic.Name = nurse.Name;
            medic.Pesel = nurse.Pesel;
            medic.Sex = nurse.Sex;
            medic.Permission = nurse.Permission;
            medic.EmployeeType = nurse.EmployeeType;
            return medic;
        }

        public Medic ConvertPhysician()
        {
            Medic medic = new Medic();
            medic.Id = physician.Id;
            medic.Name = physician.Name;
            medic.Pesel = physician.Pesel;
            medic.Sex = physician.Sex;
            medic.Permission = physician.Permission;
            medic.EmployeeType = physician.EmployeeType;
            return medic;
        }
    }
}
