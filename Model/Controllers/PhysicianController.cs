using Model.Helpers;
using Model.Model;
using Model.Service;
using Model.Services;
using System.Collections.Generic;
using System.Linq;

namespace Model.Controller
{
    public class PhysicianController : Validate, IEmployeeController<Physician>
    {
        public List<Physician> Add(Physician entity, Context context)
        {
            //pobiera wszystkich lekarzy z bazy (plku xml)
            List<Physician> physicians = context.Physicians;
            //nadaje id nowemu lekarzowi
            entity.Id = GenerateId(context);
            entity.Shift = new List<Shift>();
            //dodaje lekarza do listy lekarzy
            physicians.Add(entity);
            //zwraca lekarza
            return physicians;
        }

        public void Delete(int id, Context context)
        {
            List<Physician> physicians = context.Physicians;
            var index = physicians.FindIndex(x => x.Id == id);
            physicians.RemoveAt(index);
            context.Physicians = physicians;
        }

        public Physician FindFirstByCondition(int id, Context context)
        {
            Physician physicians = context.Physicians.FirstOrDefault(x => x.Id == id);
            return physicians;
        }

        public IQueryable<Physician> GetAll(Context context)
        {
            return context.Physicians.AsQueryable();
        }

        public List<Physician> Update(Physician entity, Context context)
        {
            //pobiera z bazy wszystkich lekarzy
            List<Physician> physicians = context.Physicians;
            //znajduje lekarza o entity.id         
            var oldPhysician = FindFirstByCondition(entity.Id, context);
            //znajduje index tego lekarza na liscie wszystkich lekarzy
            var index = physicians.IndexOf(oldPhysician);
            //nadpisuje: entity w miejscu oldPhysician
            context.Physicians[index] = entity;
            //zwraca liste wszystkich physicians
            return physicians;
        }

        public Shift AddShift(Physician entity, Shift shift, Context context)
        {
            //przypisuje lekarza (skonwertowanego do medyka) do zmiany
            ConvertToMedic converter = new ConvertToMedic(entity);
            //Medic convertedMedic = converter.ConvertNurse();
            Medic convertedMedic = converter.ConvertPhysician();
            shift.Medic = convertedMedic;
            //dodaje zmiane do listy zmian lekarza
            entity.Shift.Add(shift);
            //aktualizacja lekarzy
            Update(entity, context);
            //zwraca zmiane
            return shift;
        }
        public List<Shift> GetShifts(Physician entity, Context context)
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

        public Shift GetShift(Physician entitty, int shiftId, Context context)
        {
            throw new System.NotImplementedException();
        }
    }
}
