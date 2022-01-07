using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.Service
{  
    public class NurseController
    {
        private readonly IEmployeeConfiguration<Nurse> _nurseConfiguration;
        private readonly Context _context;
        public NurseController(IEmployeeConfiguration<Nurse> employeeConfiguration, Context context)
        {
            _nurseConfiguration = employeeConfiguration;
            _context = context;
        }


        public List<Nurse> Add(Nurse nurse)
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
                var nurse = _nurseConfiguration.FindFirstByCondition(id, _context);
                _nurseConfiguration.Delete(id, _context);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Nurse> GetEmployees() => _nurseConfiguration.GetAll(_context);

        public Nurse Get(int id)
        {
            var result = new Nurse();
            return result;
        }

        public Nurse Update(int id)
        {
            var result = new Nurse();
            return result;
        }
    }
}
