using Model.Helpers;
using Model.Model;
using Model.Service;
using System.Collections.Generic;
using System.Linq;

namespace Model.Controller
{
    public class PhysicianService : IEmployeeConfiguration<Physician>
    {
        public List<Physician> Add(Physician entity, Context context)
        {
            List<Physician> physicians = context.Physicians;
            physicians.Add(entity);
            List<Shift> physicianShift = entity.Shift;
            if (physicianShift != null)
            {
                ConvertToMedic converter = new ConvertToMedic(entity);
                Medic convertedMedic = converter.ConvertPhysician();
                foreach (var item in physicianShift)
                {
                    item.Medic = convertedMedic;
                }
            }
            entity.Shift = physicianShift;
            AddShifts(entity.Shift, context);
            return physicians;
        }

        public void Delete(Physician entity, Context context)
        {
            List<Physician> physicians = context.Physicians;
            physicians.RemoveAt(entity.Id);
        }

        public Physician FindFirstByCondition(int id, Context context)
        {
            Physician physicians = context.Physicians.FirstOrDefault(x => x.Id == id);
            return physicians;
        }

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
            List<Physician> physicians = context.Physicians;
            physicians.RemoveAt(entity.Id);
            physicians.Add(entity);
            return physicians;
        }

        public void AddShifts(List<Shift> shifts, Context context)
        {
            context.Shifts.Add(shifts);
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

    }
}
