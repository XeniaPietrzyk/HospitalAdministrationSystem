using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public interface IShiftConfiguration<T>
    {
        public Shift Add(Shift shift, Context context);
        public Shift FindFirstByCondition(int id, Context context);
        public IQueryable<Shift> GetAll(Context context);
        public List<Shift> Update(Shift shift, Context context);
        public List<Shift> UpdateMedic(List<Shift> shifts, T entity, Context context);
        public void Delete(int id, Context context);
    }
}
