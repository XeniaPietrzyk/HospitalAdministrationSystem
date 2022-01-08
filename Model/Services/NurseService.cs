using Model.Helpers;
using Model.Model;
using Model.Service;
using Model.Services;
using System.Collections.Generic;
using System.Linq;

namespace Model.Controller
{
    public class NurseService : Validate, IEmployeeConfiguration<Nurse>
    {
        public List<Nurse> Add(Nurse entity, Context context)
        {
            //pobiera wszystkich lekarzy z bazy (plku xml)
            List<Nurse> nurses = context.Nurses;
            //nadaje id nowemu lekarzowi
            entity.Id = GenerateId(context);
            entity.Shift = new List<Shift>();
            //dodaje lekarza do listy lekarzy
            nurses.Add(entity);

            //zwraca lekarza
            //do przyszlych testow integracyjnych
            return nurses;
        }

        public void Delete(int id, Context context)
        {
            List<Nurse> nurse = context.Nurses;
            var index = nurse.FindIndex(x => x.Id == id);
            nurse.RemoveAt(index);
        }


        public Nurse FindFirstByCondition(int id, Context context)
        {
            Nurse nurse = context.Nurses.FirstOrDefault(x => x.Id == id);
            return nurse;
        }

        public IQueryable<Nurse> GetAll(Context context)
        {
            return context.Nurses.AsQueryable();
        }


        public List<Nurse> Update(Nurse entity, Context context)
        {
            List<Nurse> nurse = context.Nurses;
            nurse.RemoveAt(entity.Id);
            nurse.Add(entity);
            return nurse;
        }

        public void AddShift(Nurse entity, Shift shift, Context context)
        {
            //dodaje zmiane do listy zmian pielegniarza
            entity.Shift.Add(shift);
            //przypisuje pielegniarza (skonwertowana do medyka) do zmiany
            ConvertToMedic converter = new ConvertToMedic(entity);
            Medic convertedMedic = converter.ConvertPhysician();
            shift.Medic = convertedMedic;
            //dodaje zmiane do listy wszystkich zmian
            context.AllShifts.Add(shift);
        }

        public List<Shift> GetShift(Context context)
        {
            List<Shift> shifts = new List<Shift>();
            foreach (var item in context.Nurses)
            {
                foreach (var singleShift in item.Shift)
                {
                    shifts.Add(singleShift);
                }                
            }
            return shifts;
        }

        public List<Shift> GetShifts(Nurse entity, Context context)
        {
            throw new System.NotImplementedException();
        }
    }
}
