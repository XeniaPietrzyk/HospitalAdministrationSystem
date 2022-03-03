using Model.Model;
using Model.Service;
using Model.Services;
using System.Collections.Generic;
using System.Linq;

namespace Model.Controller
{
    public class AdminController : Validate, IEmployeeController<Admin>
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
            entity.Id = GenerateId(context);
            admin.Add(entity);
            return admin;

        }

        public List<Admin> Update(Admin entity, Context context)
        {
            List<Admin> admin = context.Admins;
            Delete(entity.Id, context);
            admin.Add(entity);
            return admin;
        }

        public void Delete(int id, Context context)
        {
            List<Admin> admin = context.Admins;
            var index = admin.FindIndex(x => x.Id == id);
            admin.RemoveAt(index);
        }

        //nie potrzebuje tych funkcji, ponbiewaz admin nie ma swoich Shift
        //NOTE: do rozwazenia stworzenie IAdminConfiguration
        public Shift AddShift(Admin entity, Shift shift, Context context)
        {
            throw new System.NotImplementedException();
        }

        public List<Shift> GetShifts(Admin entity, Context context)
        {
            throw new System.NotImplementedException();
        }

        public Shift GetShift(Admin entitty, int shiftId, Context context)
        {
            throw new System.NotImplementedException();
        }

        public List<Shift> DeleteShift(int id, Shift shift, Context context)
        {
            throw new System.NotImplementedException();
        }
    }
}
