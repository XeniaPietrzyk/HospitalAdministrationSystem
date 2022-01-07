﻿using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model.Service
{  
    public class AdminController
    {
        private readonly IPhysicianConfiguration _adminConfiguration;
        private readonly Context _context;
        public AdminController(IPhysicianConfiguration employeeConfiguration, Context context)
        {
            _adminConfiguration = employeeConfiguration;
            _context = context;
        }


        public List<Physician> Add(Physician admin)
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

        public IQueryable<Physician> GetEmployees() => _adminConfiguration.GetAll(_context);

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
