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
            AllShifts = new List<Shift>();
            LoginPassword = new Dictionary<string, string>();
        }

        private readonly XMLSerializer _xmlserializer;
        public List<Admin> Admins { get; set; }
        public List<Nurse> Nurses { get; set; }
        public List<Physician> Physicians { get; set; }
        //lista dyzurowm ktora posiada liste zmian (List<Shift>) pracownikow
        public List<Duty> Duties { get; set; }
        //lista wszystkich istniejacych zmian wszystkich pracownikow
        public List<Shift> AllShifts { get; set; }
        public Dictionary<string, string> LoginPassword { get; set; }

        public void Configure()
        {
            try
            {
                //domyslny admin programu
                Admins.Add(new Admin { Id = 0, Name = "John Doe", Pesel = 12345678910, Permission = Helpers.Permission.admin, UserName = "admin", Password = "admin", Sex = Helpers.Sex.male, EmployeeType = Helpers.EmployeeType.admin });
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
                Duties = _xmlserializer.Xml2Object<Duty>(Duties, "duties");
                AllShifts = _xmlserializer.Xml2Object<Shift>(AllShifts, "shifts");
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
                var dutySave = _xmlserializer.Object2Xml<Duty>(Duties, "duties");
                var shiftSave = _xmlserializer.Object2Xml<Shift>(AllShifts, "shifts");
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
