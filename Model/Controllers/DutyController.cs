using Model.Model;
using Model.Service;
using System.Collections.Generic;
using System.Linq;

namespace Model.Services
{
    //NOTE: do poprawki na przyszlosc - osobny interface dla Duty
    public class DutyController : IEmployeeController<Duty>
    {
        //NOTE: wlasciwie mozna by poprawic zwracanie List<Duty> na komunikat o udanej lub nieudanej akcji (?)
        public List<Duty> Add(Duty entity, Context context)
        {
            List<Duty> duties = context.Duties;
            entity.Id = GenerateId(context);
            entity.Shifts = new List<Shift>();
            duties.Add(entity);
            context.Duties = duties;
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
            var oldDuty = FindFirstByCondition(entity.Id, context);
            //szuka indeksu tej zmiany w AllShifts
            var index = duties.IndexOf(oldDuty);
            //nadpisuje shift w miejscu oldShift
            context.Duties[index] = entity;
            //zwraca zmiany
            return duties;
        }

        public void Delete(int id, Context context)
        {
            List<Duty> duties = context.Duties;
            duties.RemoveAt(id);
        }

        private int GenerateId(Context context)
        {
            var id = 1;
            if (context.Duties.Count != 0)
            {
                id = context.Duties.Max(x => x.Id) + 1;
            }
            return id;
        }

        public Shift GetShift(Duty duty, int shiftId, Context context)
        {
            var shift = duty.Shifts.FirstOrDefault(x => x.Id == shiftId);
            return shift;
        }

        public List<Shift> GetShifts(Duty duty, Context context)
        {
            List<Shift> dutyShifts = new List<Shift>();
            foreach (var item in duty.Shifts)
            {
                dutyShifts.Add(item);
            }
            return dutyShifts;
        }

        public Shift AddShift(Duty entity, Shift shift, Context context)
        {
            //znajduje dyzur po id z listy Duties
            var duty = FindFirstByCondition(entity.Id, context);
            //dodaje nowa zmiane do dyzuru
            duty.Shifts.Add(shift);
            //altualizuje dyzur
            Update(duty, context);
            return shift;
        }

        public List<Shift> DeleteShift(int id, Shift shift, Context context)
        {          
            //znajdz duty, ktore posiada shift
            var duty = FindFirstByCondition(id, context);
            var dutyShifts = duty.Shifts;
            //znajdz id shifta w duty
            shift = dutyShifts.FirstOrDefault(x => x.Id == shift.Id);
            var index = dutyShifts.IndexOf(shift);
            //usun shift z duty
            duty.Shifts.RemoveAt(index);
            //zaktualizuj Duties
            Update(duty, context);
            //zwroc aktualna liste duty.shift
            return duty.Shifts;
        }
    }
}
