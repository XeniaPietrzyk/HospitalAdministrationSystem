using Model.Model;
using Model.Service;
using System.Collections.Generic;
using System.Linq;

namespace Model.Services
{
    class DutyService : IEmployeeConfiguration<Duty>
    {
        //NOTE: wlasciwie mozna by poprawic zwracanie List<Duty> na komunikat o udanej lub nieudanej akcji (?)
        public List<Duty> Add(Duty entity, Context context)
        {
            List<Duty> duties = context.Duties;
            entity.Id = GenerateId(context);
            entity.Shifts = new List<Shift>();
            duties.Add(entity);
            return duties;
        }

        public IQueryable<Duty> GetAll(Context context)
        {
            return context.Duties.AsQueryable();
        }

        public Duty FindFirstByCondition(int id, Context context)
        {
            Duty duty = context.Duties.FirstOrDefault(x => x.Id == id);
            return duty;
        }

        public List<Duty> Update(Duty entity, Context context)
        {
            List<Duty> duties = context.Duties;
            duties.RemoveAt(entity.Id);
            duties.Add(entity);
            return duties;
        }

        public void Delete(int id, Context context)
        {
            List<Duty> duties = context.Duties;
            duties.RemoveAt(id - 1);
        }

        private int GenerateId(Context context)
        {
            var id = context.Duties.Count + 1;
            return id;
        }

        public void AddShifts(List<Shift> shifts, Context context)
        {
            context.Shifts.Add(shifts);
        }

        public List<Shift> GetShift(Context context)
        {
            List<Shift> shifts = new List<Shift>();
            foreach (var item in context.Duties)
            {
                foreach (var singleShift in item.Shifts)
                {
                    shifts.Add(singleShift);
                }
            }
            return shifts;
        }

    }
}
