using Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace Model.Services
{
    public class ShiftService : IShiftConfiguration<Medic>
    {
        public List<Shift> Add(Shift entity, Context context)
        {
            List<Shift> shifts = context.AllShifts;
            entity.Id = GenerateId(context);
            shifts.Add(entity);
            context.AllShifts = shifts;
            return shifts;
        }

        public IQueryable<Duty> GetAll(Context context)
        {
            return context.Duties.AsQueryable();
        }

        public Shift FindFirstByCondition(int id, Context context)
        {
            Shift duty = context.AllShifts.FirstOrDefault(x => x.Id == id);
            return duty;
        }

        public List<Shift> Update(Shift shift, Context context)
        {
            List<Shift> duties = context.AllShifts;
            duties.RemoveAt(shift.Id);
            duties.Add(shift);
            return duties;
        }

        public void Delete(int id, Context context)
        {
            List<Shift> duties = context.AllShifts;
            duties.RemoveAt(id - 1);
        }

        private int GenerateId(Context context)
        {
            var id = context.AllShifts.Count + 1;
            return id;
        }

        public List<Shift> UpdateMedic(List<Shift> shifts, Medic entity, Context context)
        {
            foreach (var item in shifts)
            {
                item.Medic = entity;
            }
            return shifts;
        }
    }
}
