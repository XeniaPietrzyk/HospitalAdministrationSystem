using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.Service
{  
    public class AdminController
    {
        private readonly IEmployeeConfiguration<Admin> _adminConfiguration;
        private readonly Context _context;
        public AdminController(IEmployeeConfiguration<Admin> employeeConfiguration, Context context)
        {
            _adminConfiguration = employeeConfiguration;
            _context = context;
        }


        public List<Admin> Add(Admin admin)
        {
            try
            {
                return _adminConfiguration.Add(admin, _context);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var admin = _adminConfiguration.FindFirstByCondition(id, _context);
                _adminConfiguration.Delete(id, _context);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Admin> GetEmployees() => _adminConfiguration.GetAll(_context);

        public Admin Get(int id)
        {
            var result = new Admin();
            return result;
        }

        public Admin Update(int id)
        {
            var result = new Admin();
            return result;
        }
    }
}
