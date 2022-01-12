using Model.Model;
using Model.Service;
using System.Collections.Generic;
using System.Linq;

namespace Model.Services
{
    //NOTE: do poprawki na przyszlosc - osobny interface dla Duty
    public class DutyService : IEmployeeConfiguration<Duty>
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
            Delete(entity.Id, context);
            duties.Add(entity);
            return duties;
        }

        public void Delete(int id, Context context)
        {
            List<Duty> duties = context.Duties;
            var index = duties.FindIndex(x => x.Id == id);
            duties.RemoveAt(index);
        }

        private int GenerateId(Context context)
        {
            var id = context.Duties.Count + 1;
            return id;
        }
        //nie potrzebuje pobierania wszystkich list zmian ze wszystkich duties
        public List<Shift> GetShift(Context context)
        {
            throw new System.NotImplementedException();
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

        public void AddShift(Duty entity, Shift shift, Context context)
        {
            //znajduje dyzur po id z listy Duties
            var duty = FindFirstByCondition(entity.Id, context);
            //dodaje nowa zmiane do dyzuru
            duty.Shifts.Add(shift);
            //altualizuje dyzur
            Update(duty, context);           
        }
    }
}
