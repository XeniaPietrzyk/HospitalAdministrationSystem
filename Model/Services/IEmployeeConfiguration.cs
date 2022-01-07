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
        void Delete(T entity, Context context);
        public void AddShift(List<Shift> shift, Context context);
        public List<Shift> GetShift(Context context);
    }
}
