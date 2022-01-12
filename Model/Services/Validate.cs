using Model.Helpers;
using Model.Model;

namespace Model.Services
{
    public class Validate
    {
        public int GenerateId(Context context)
        {
            var id = context.Physicians.Count + context.Admins.Count + context.Nurses.Count + 1;
            return id;
        }

        public bool UserNameKeyValidate(string userName, Context context)
        {
            if (context.LoginPassword.ContainsKey(userName))
            {
                return false;
            }
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

    }
}
