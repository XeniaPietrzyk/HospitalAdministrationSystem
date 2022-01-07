using Model.Model;
using Model.Service;
using System.Collections.Generic;
using System.Linq;

namespace Model.Controller
{
    public class NurseService : IEmployeeConfiguration<Nurse>
    {
        public List<Nurse> Add(Nurse entity, Context context)
        {
            //Nurses = NurseService.Add(newNurse, context)
            List<Nurse> nurses = context.Nurses;
            nurses.Add(entity);
            AddShifts( entity.Shift, context);
            return nurses;
        }

        public void Delete(Nurse entity, Context context)
        {
            List<Nurse> nurse = context.Nurses;
            nurse.RemoveAt(entity.Id);
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

        public void AddShifts(List<Shift> shifts, Context context)
        {
            context.Shifts.Add(shifts);
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

    }
}
