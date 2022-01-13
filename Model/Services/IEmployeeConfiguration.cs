using Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace Model.Service
{
    public interface IEmployeeConfiguration<T>
    {
        IQueryable<T> GetAll(Context context);
        T FindFirstByCondition(int id, Context context);
        List<T> Add(T entity, Context context);
        List<T> Update(T entity, Context context);
        void Delete(int id, Context context);
        public Shift AddShift(T entity, Shift shift, Context context);
        public List<Shift> GetShifts(T entity, Context context);
        public Shift GetShift(T entitty, int shiftId, Context context);
        public List<Shift> DeleteShift(int id, Shift shift, Context context);
    }
}
