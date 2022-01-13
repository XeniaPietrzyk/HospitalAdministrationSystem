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
            //pobiera wszystkich pielegniarzy z bazy (plku xml)
            List<Nurse> nurses = context.Nurses;
            //nadaje id nowemu pielegniarzowi
            entity.Id = GenerateId(context);
            entity.Shift = new List<Shift>();
            //dodaje piel. do listy piel.
            nurses.Add(entity);
            //zwraca piel.
            return nurses;
        }

        public void Delete(int id, Context context)
        {
            List<Nurse> nurses = context.Nurses;
            var index = nurses.FindIndex(x => x.Id == id);
            nurses.RemoveAt(index);
            context.Nurses = nurses;
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
            //pobiera z bazy wszystkich piel.
            List<Nurse> nurses = context.Nurses;
            //znajduje piel. o entity.id         
            var oldNurse = FindFirstByCondition(entity.Id, context);
            //znajduje index tego piel. na liscie wszystkich lekarzy
            var index = nurses.IndexOf(oldNurse);
            //nadpisuje: entity w miejscu oldPhysician
            context.Nurses[index] = entity;
            //zwraca liste wszystkich physicians
            return nurses;
        }

        public Shift AddShift(Nurse entity, Shift shift, Context context)
        {
            //przypisuje pielegniarza (skonwertowana do medyka) do zmiany
            ConvertToMedic converter = new ConvertToMedic(entity);
            //Medic convertedMedic = converter.ConvertNurse();
            Medic converted = converter.ConvertNurse();
            shift.Medic = converted;
            //dodaje zmiane do listy zmian piel.
            entity.Shift.Add(shift);
            //aktualizacja piel.
            Update(entity, context);
            //zwraca zmiane
            return shift;
        }

        public List<Shift> GetShifts(Nurse entity, Context context)
        {
            List<Shift> shifts = new List<Shift>();
            foreach (var item in entity.Shift)
            {
                shifts.Add(item);
            }
            return shifts;
        }

        public List<Shift> DeleteShift(int id, Shift shift, Context context)
        {
            var entity = FindFirstByCondition(id, context);
            var entityShifts = entity.Shift;
            shift = entity.Shift.FirstOrDefault(x => x.Id == shift.Id);
            var index = entityShifts.IndexOf(shift);
            entity.Shift.RemoveAt(index);
            Update(entity, context);
            return entity.Shift;
        }

        public Shift GetShift(Nurse entitty, int shiftId, Context context)
        {
            throw new System.NotImplementedException();
        }
    }
}
