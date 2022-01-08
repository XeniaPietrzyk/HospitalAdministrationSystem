using Model.Helpers;
using Model.Model;
using Model.Service;
using Model.Services;
using System.Collections.Generic;
using System.Linq;

namespace Model.Controller
{
    public class PhysicianService : Validate, IEmployeeConfiguration<Physician>
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
            //do przyszlych testow integracyjnych
            return physicians;
        }

        public void Delete(int id, Context context)
        {
            List<Physician> physicians = context.Physicians;
            var index = physicians.FindIndex(x => x.Id == id);
            physicians.RemoveAt(index);
        }

        public Physician FindFirstByCondition(int id, Context context)
        {
            Physician physicians = context.Physicians.FirstOrDefault(x => x.Id == id);
            return physicians;
        }

        //TODO: powielenie, do usuniecia
        public Physician Get(int id, Context context)
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
            //usuwa lekarza o entity.id
            physicians.RemoveAt(entity.Id);
            //dodaje lekarza do listy wszystkich lekarzy
            physicians.Add(entity);
            return physicians;
        }

        public void AddShift(Physician entity, Shift shift, Context context)
        {
            //dodaje zmiane do listy zmian lekarza
            entity.Shift.Add(shift);
            //przypisuje lekarza (skonwertowanego do medyka) do zmiany
            ConvertToMedic converter = new ConvertToMedic(entity);
            Medic convertedMedic = converter.ConvertPhysician();
            shift.Medic = convertedMedic;
            //dodaje zmiane do listy wszystkich zmian
            context.AllShifts.Add(shift);
        }

        public List<Shift> GetShift(Context context)
        {
            List<Shift> shifts = new List<Shift>();
            foreach (var item in context.Physicians)
            {
                foreach (var singleShift in item.Shift)
                {
                    shifts.Add(singleShift);
                }
            }
            return shifts;
        }

        public List<Shift> GetShifts(Physician entity, Context context)
        {
            throw new System.NotImplementedException();
        }
    }
}
