using Model.Model;
using Model.Service;
using System.Collections.Generic;
using System.Linq;

namespace Model.Controller
{
    public class AdminService : IEmployeeConfiguration<Admin>
    {

        public IQueryable<Admin> GetAll(Context context)
        {
            return context.Admins.AsQueryable();
        }

        public Admin FindFirstByCondition(int id, Context context)
        {
            Admin admin = context.Admins.FirstOrDefault(x => x.Id == id);
            return admin;
        }

        public Admin Get(int id, Context context)
        {
            Admin admin = context.Admins.FirstOrDefault(x => x.Id == id);
            return admin;
        }

        public List<Admin> Add(Admin entity, Context context)
        {
            List<Admin> admin = context.Admins;
            admin.Add(entity);
            return admin;

        }

        public List<Admin> Update(Admin entity, Context context)
        {
            List<Admin> admin = context.Admins;
            admin.RemoveAt(entity.Id);
            admin.Add(entity);
            return admin;
        }

        public void Delete(Admin entity, Context context)
        {
            List<Admin> admin = context.Admins;
            admin.RemoveAt(entity.Id);
        }

        public void AddShift(List<Shift> shift, Context context)
        {
            throw new System.NotImplementedException();
        }

        public List<Shift> GetShift(Context context)
        {
            throw new System.NotImplementedException();
        }
    }
}
