using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class ShiftService
    {
        public List<Shift> Add(Shift entity, Context context)
        {
            List<Shift> shifts = context.AllShifts;
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

        public List<Shift> Update(Shift entity, Context context)
        {
            List<Shift> duties = context.AllShifts;
            duties.RemoveAt(entity.Id);
            duties.Add(entity);
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

    }
}
