using Model.Model;
using Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Controller
{
    class DutyController
    {
        private readonly IEmployeeConfiguration<Duty> _dutyConfiguration;
        private readonly Context _context;
        public DutyController(IEmployeeConfiguration<Duty> dutyConfiguration, Context context)
        {
            _dutyConfiguration = dutyConfiguration;
            _context = context;
        }

        public List<Duty> Add(Duty duty)
        {
            try
            {
                return _dutyConfiguration.Add(duty, _context);
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
                var admin = _dutyConfiguration.FindFirstByCondition(id, _context);
                _dutyConfiguration.Delete(id, _context);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Duty> GetEmployees() => _dutyConfiguration.GetAll(_context);

        public Duty Get(int id)
        {
            var result = new Duty();
            return result;
        }

        public Duty Update(int id)
        {
            var result = new Duty();
            return result;
        }
    }
}
