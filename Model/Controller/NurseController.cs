using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.Service
{  
    public class NurseController
    {
        private readonly INurseConfiguration _nurseConfiguration;
        private readonly Context _context;
        public NurseController(INurseConfiguration employeeConfiguration, Context context)
        {
            _nurseConfiguration = employeeConfiguration;
            _context = context;
        }


        public List<Physician> Add(Physician nurse)
        {
            try
            {
                return _nurseConfiguration.Add(nurse, _context);
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
                var admin = _nurseConfiguration.FindFirstByCondition(id, _context);
                _nurseConfiguration.Delete(admin, _context);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Physician> GetEmployees() => _nurseConfiguration.GetAll(_context);

        public Physician Get(int id)
        {
            var result = new Physician();
            return result;
        }

        public Physician Update(int id)
        {
            var result = new Physician();
            return result;
        }
    }
}
