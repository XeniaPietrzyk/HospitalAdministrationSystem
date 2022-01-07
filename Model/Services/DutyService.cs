using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    class DutyService
    {
        public List<Duty> Add(Duty entity, Context context)
        {
            List<Duty> duties = context.Duties;
            entity.Id = GenerateId(context);
            duties.Add(entity);
            return duties;
        }

        public IQueryable<Duty> GetAll(Context context)
        {
            return context.Duties.AsQueryable();
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

        private int GenerateId( Context context)
        {
            var id = context.Duties.Count + 1;
            return id;
        }
}
}
