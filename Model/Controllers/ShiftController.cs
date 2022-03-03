using Model.Model;
using Model.Service;
using System.Collections.Generic;
using System.Linq;

namespace Model.Services
{
    public class ShiftController : IShiftController<Medic>
    {
        public Shift Add(Shift entity, Context context)
        {
            List<Shift> shifts = context.AllShifts;
            entity.Id = GenerateId(context);
            shifts.Add(entity);
            context.AllShifts = shifts;
            return entity;
        }

        public IQueryable<Shift> GetAll(Context context)
        {
            return context.AllShifts.AsQueryable();
        }

        public Shift FindFirstByCondition(int id, Context context)
        {
            Shift shift = context.AllShifts.FirstOrDefault(x => x.Id == id);
            return shift;
        }

        public List<Shift> Update(Shift shift, Context context)
        {
            //pobiera z bazy wszystkie zmiany
            List<Shift> shifts = context.AllShifts;
            //znajduje zmiane o shift.Id
            var oldShift = FindFirstByCondition(shift.Id, context);
            //szuka indeksu tej zmiany w AllShifts
            var index = shifts.IndexOf(oldShift);
            //nadpisuje shift w miejscu oldShift
            context.AllShifts[index] = shift;
            //zwraca zmiany
            return shifts;
        }

        public void Delete(int id, Context context)
        {
            List<Shift> shifts = context.AllShifts;
            var shift = FindFirstByCondition(id, context);
            var index = shifts.IndexOf(shift);
            shifts.RemoveAt(index);
            context.AllShifts = shifts;
        }

        private int GenerateId(Context context)
        {
            var id = 1;
            if (context.AllShifts.Count!=0)
            {
                id = context.AllShifts.Max(x => x.Id) + 1;
            }
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
