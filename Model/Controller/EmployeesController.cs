using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.Service
{        

    public class EmployeesController<T>
    {
        private readonly IEmployeeConfiguration<T> _employeeConfiguration;
        private readonly Context _context;
        public EmployeesController(IEmployeeConfiguration<T> employeeConfiguration, Context context)
        {
            _employeeConfiguration = employeeConfiguration;
            _context = context;
        }


        public List<T> Add(T entity)
        {
            try
            {
                return _employeeConfiguration.Add(entity, _context);
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
                var employee = _employeeConfiguration.FindFirstByCondition(id, _context);
                _employeeConfiguration.Delete(id, _context);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<T> GetEmployees() => _employeeConfiguration.GetAll(_context);

        public T Get(int id)
        {
            return _employeeConfiguration.FindFirstByCondition(id, _context);
        }

        public List<T> Update(T entity)
        {
            return _employeeConfiguration.Update(entity, _context);
        }
    }
}
