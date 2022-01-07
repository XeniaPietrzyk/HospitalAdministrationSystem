using Model.Helpers;
using Model.Model;
using Model.XML;
using System;
using System.Collections.Generic;

namespace Model
{
    public class Context
    {
        public Context()
        {
            _xmlserializer = new XMLSerializer();
            Admins = new List<Admin>();
            Nurses = new List<Nurse>();
            Physicians = new List<Physician>();
            Duties = new List<Duty>();
            Shifts = new List<List<Shift>>();
            LoginPassword = new Dictionary<string, string>();
        }

        private readonly XMLSerializer _xmlserializer;
        public List<Admin> Admins { get; set; }
        public List<Nurse> Nurses { get; set; }
        public List<Physician> Physicians { get; set; }
        public List<Duty> Duties { get; set; }
        public List<List<Shift>> Shifts { get; set; }
        public Dictionary<string, string> LoginPassword { get; set; }

        public void Configure()
        {
            try
            {
                Admins.Add(new Admin { Id = 0, Name = "John Doe", Pesel = 12345678910, Permission = Helpers.Permission.admin, UserName = "admin", Password = "admin", Sex = Helpers.Sex.male });

                List<Shift> nurseShift = new List<Shift>();
                nurseShift.Add(new Shift() { Id = 1, ShiftDate = DateTime.Now });
                Shifts.Add(nurseShift);
                Nurses.Add(new Nurse { Id = 1, Name = "Misery Chastein", Pesel = 98765432198, Permission = Helpers.Permission.employee, UserName = "nurse", Password = "nurse", Sex = Helpers.Sex.female, Shift = nurseShift });

                List<Shift> nurse2Shifts = new List<Shift>();
                Shift florenceShift = new Shift() { Id = 1, ShiftDate = DateTime.Now };
                Nurse Florence = new Nurse { Id = 2, Name = "Florence Nightingale", Pesel = 98765432198, Permission = Helpers.Permission.employee, UserName = "nurse2", Password = "nurse2", Sex = Helpers.Sex.male, Shift = nurse2Shifts };
                Nurses.Add(Florence);
                nurse2Shifts.Add(florenceShift);
                Shifts.Add(nurse2Shifts);

                ReadDataBase();
                SetLoginDictionary();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ReadDataBase()
        {
            try
            {
                Admins = _xmlserializer.Xml2Object<Admin>(Admins, "admins");
                Nurses = _xmlserializer.Xml2Object<Nurse>(Nurses, "nurses");
                Physicians = _xmlserializer.Xml2Object<Physician>(Physicians, "physicians");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SaveDataBase()
        {
            try
            {
                var adminSave = _xmlserializer.Object2Xml<Admin>(Admins, "admins");
                var nurseSave = _xmlserializer.Object2Xml<Nurse>(Nurses, "nurses");
                var physiciansSave = _xmlserializer.Object2Xml<Physician>(Physicians, "physicians");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SetLoginDictionary()
        {
            foreach (var item in Admins)
            {
                LoginPassword.Add(item.UserName, item.Password);
            }
            foreach (var item in Nurses)
            {
                LoginPassword.Add(item.UserName, item.Password);
            }
            foreach (var item in Physicians)
            {
                LoginPassword.Add(item.UserName, item.Password);
            }
        }
    }
}
