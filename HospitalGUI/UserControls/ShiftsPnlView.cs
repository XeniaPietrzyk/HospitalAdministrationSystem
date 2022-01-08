﻿using Model;
using Model.Controller;
using Model.Model;
using Model.Service;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HospitalGUI.UserControls
{
    //TODO: komunikat o dodaniu/edytowaniu pracownika
    //TODO: generowanie id globalnego (nie może być tak, że lekarz id = 0 i pielegniarka id = 0)
    //TODO: sprawdzic dzialanie dodawania, usuwania, edytowania pracownikow
    //TODO: sprawdzic, czy mozna dodac Duty
    //TODO: zaprogramowac dodawanie Shift z poziomu admina
    //TODO: sprawdzic, czy dziala
    //TODO: zrobic wyswietlanie dla employee
    //TODO: zrobic dodawanie zmian dla employee
    //TODO: przetestowac
    public partial class ShiftsPnlView : UserControl
    {
        private IEmployeeConfiguration<Nurse> _nurseConfiguration;
        private IEmployeeConfiguration<Physician> _physicianConfiguration;
        private IEmployeeConfiguration<Duty> _dutyConfiguration;

        public ShiftsPnlView()
        {
            InitializeComponent();
        }
        public ShiftsPnlView(Context context)
        {
            _context = context;
            InitializeComponent();
        }

        private readonly Context _context;

        private void InitializeShiftsGrid()
        {
            
        }

        public List<Shift> GetAllShifts()
        {
            _physicianConfiguration = new PhysicianService();
            List<Shift> allShifts = _physicianConfiguration.GetShift(_context);
            _nurseConfiguration = new NurseService();
            allShifts.AddRange(_nurseConfiguration.GetShift(_context));
            return allShifts.ToList();
        }

        private void ShiftPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddDutyBtn_Click(object sender, System.EventArgs e)
        {
            Duty duty = new Duty();
            duty = setDutyTerm(duty);
            _dutyConfiguration = new DutyService();
            _dutyConfiguration.Add(duty, _context);
            DutyDataGrid.Refresh();
        }

        private Duty setDutyTerm(Duty duty)
        {            
            var day = Convert.ToInt32(DutyDayTbox.Text.ToString());
            var month = Convert.ToInt32(DutyDayTbox.Text.ToString());
            var year = Convert.ToInt32(DutyDayTbox.Text.ToString());
            DateTime dutyDate = new DateTime(year, month, day);
            duty.Term = dutyDate;
            return duty;
        }
    }
}
