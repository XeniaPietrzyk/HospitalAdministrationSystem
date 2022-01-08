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
            List<Nurse> nurses = context.Nurses;
            entity.Id = GenerateId(context);            
            List<Shift> nurseShift = entity.Shift;
            if (nurseShift != null)
            {
                ConvertToMedic converter = new ConvertToMedic(entity);
                Medic convertedMedic = converter.ConvertPhysician();
                foreach (var item in nurseShift)
                {
                    item.Medic = convertedMedic;
                }
                entity.Shift = nurseShift;
            }
            else entity.Shift = new List<Shift>();            
            AddShifts(entity.Shift, context);
            nurses.Add(entity);
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
