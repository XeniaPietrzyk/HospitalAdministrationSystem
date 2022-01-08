using Model;
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
        private IEmployeeConfiguration<Duty> _dutyConfiguration = new DutyService();

        public ShiftsPnlView()
        {
            InitializeComponent();
        }
        public ShiftsPnlView(Context context)
        {
            _context = context;
            InitializeComponent();
            this.DutyDataGrid.DataSource = context.Duties;
        }

        private readonly Context _context;

        private void AddDutyBtn_Click(object sender, System.EventArgs e)
        {
            Duty duty = new Duty();
            duty = setDutyTerm(duty);
            _dutyConfiguration = new DutyService();
            _dutyConfiguration.Add(duty, _context);
            DutyDataGrid.DataSource = GetDuties();
            //wyswietl wszystkie zmiany (shifts) dla danego dyzuru(duty)
            ShiftsDataGrid.DataSource = GetShifts(duty);
        }

        private Duty setDutyTerm(Duty duty)
        {
            var day = Convert.ToInt32(DutyDayTbox.Text.ToString());
            var month = Convert.ToInt32(DutyMonthTbx.Text.ToString());
            var year = Convert.ToInt32(YearTbx.Text.ToString());
            DateTime dutyDate = new DateTime(year, month, day);
            duty.Term = dutyDate;
            return duty;
        }

        private void AddShiftBtn_Click(object sender, EventArgs e)
        {
            Shift shift = new Shift();
            shift = setShiftValues(shift);
            //TODO: add shift to duty
            //add shift to all shifts
        }

        private Shift setShiftValues(Shift shift)
        {
            var day = Convert.ToInt32(ShiftDayTbox.Text.ToString());
            var month = Convert.ToInt32(ShiftMonthTbox.Text.ToString());
            var year = Convert.ToInt32(ShiftYearTbox.Text.ToString());
            DateTime dutyDate = new DateTime(year, month, day);
            var employeeType = EmpTypeCbox.SelectedItem;
            var employeeEntity = Convert.ToInt32(EmpIdTbox.Text.ToString());

            return shift;
        }

        private List<Duty> GetDuties()
        {            
            IQueryable<Duty> duties = _dutyConfiguration.GetAll(_context);
            return duties.ToList();
        }

        private List<Shift> GetShifts(Duty duty)
        {
            return _dutyConfiguration.GetShifts(duty, _context);
        }

        private void DutyDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var dutyId = Convert.ToInt32(DutyDataGrid.Rows[row].Cells["Id"].Value.ToString());
            var duty = _dutyConfiguration.FindFirstByCondition(dutyId, _context);
            //ustaw list<shifts> od tego duty jako ShiftsDataGrid.DataSource
            ShiftsDataGrid.DataSource = GetShifts(duty);
            
        }
    }
}
