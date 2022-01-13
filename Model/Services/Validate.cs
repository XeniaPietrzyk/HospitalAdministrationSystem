using Model.Helpers;
using Model.Model;
using System.Linq;

namespace Model.Services
{
    public class Validate
    {
        public int GenerateId(Context context)
        {
            var physicianMaxId = 0;
            var nurseMaxId = 0;
            var adminMaxId = 0;
            var id = 1;
            //wyszukuje najwiekszego id na liscie Physicians
            if (context.Physicians.Count != 0)
            {
                physicianMaxId = context.Physicians.Max(x => x.Id);
            }
            //wyszukuje najwiekszego id na liscie Nurses
            if (context.Nurses.Count != 0)
            {
                nurseMaxId = context.Nurses.Max(x => x.Id);
            }
            //wyszukuje najwiekszego id na liscie Admins
            if (context.Admins.Count != 0)
            {
                adminMaxId = context.Admins.Max(x => x.Id);
            }
            //ustawia dla zmiennej id najwieksza ze znalezionych wartosci 
            id = (physicianMaxId > nurseMaxId) ? physicianMaxId : nurseMaxId;
            id = (id > adminMaxId) ? id : adminMaxId;
            //powieksza wartosc o 1 i zwraca
            return id+1;
        }

        public bool UserNameKeyValidate(string userName, string password, Context context)
        {
            if (context.LoginPassword.ContainsKey(userName))
            {
                return false;
            }context.LoginPassword.Add(userName, password);
            return true;
        }

        public int FindEmployeeType(int id, Context context)
        {
            var type = 0;
            var adminContains = context.Admins.Find(x => x.Id == id);
            var physicianContains = context.Physicians.Find(x => x.Id == id);
            var nurseContains = context.Nurses.Find(x => x.Id == id);
            if (adminContains != null)
            {
                type = 1;
            }
            else if (physicianContains != null)
            {
                type = 2;
            }
            else if (nurseContains != null)
            {
                type = 3;
            }
            return type;
        }

        public Medic FindMedic(int id, Context context)
        {
            Medic medic = new Medic();
            var physicianContains = context.Physicians.Find(x => x.Id == id);
            var nurseContains = context.Nurses.Find(x => x.Id == id);
            ConvertToMedic converter = new ConvertToMedic(nurseContains, physicianContains);
            if (physicianContains != null)
            {
                medic = converter.ConvertPhysician();
            }
            else if (nurseContains != null)
            {
                medic = converter.ConvertNurse();
            }
            return medic;
        }

        public bool hasShiftBreak(Medic medic, Shift shift)
        {
            bool hasBreak = false;
            var newShiftDate = shift.ShiftDate;
            //iteruje po wszystkich zmianach medyka
            if (medic.Shift.Count == 0)
            {
                hasBreak = true;
            }
            for (int i = 0; i < medic.Shift.Count; i++)
            {
                //dzien po sprawdzanej zmianie
                var nextDay = medic.Shift[i].ShiftDate.AddDays(1);
                //dzien przed sprawdzana zmiana
                var dayBefore = medic.Shift[i].ShiftDate.AddDays(-1);
                //jesli nowa zmiana ma inna date niz powyzsze
                if (newShiftDate!=nextDay && newShiftDate != dayBefore)
                {
                    //medyk ma wymagana zmiane pomiedzy zmianami
                    hasBreak = true;
                }
            }
            return hasBreak;
        }
    }
}
