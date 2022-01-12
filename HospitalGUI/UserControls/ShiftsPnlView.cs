using Model;
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
    //TODO: zaprogramowac dodawanie Shift z poziomu admina
    //TODO: sprawdzic, czy dziala
    //TODO: zrobic wyswietlanie dla employee
    //TODO: zrobic dodawanie zmian dla employee
    //TODO: przetestowac
    public partial class ShiftsPnlView : UserControl
    {
        private IEmployeeConfiguration<Duty> _dutyConfiguration = new DutyService();
        private IShiftConfiguration<Medic> _shiftConfiguration = new ShiftService();
        private IEmployeeConfiguration<Admin> _adminConfiguration = new AdminService();
        private IEmployeeConfiguration<Physician> _physicianConfiguration = new PhysicianService();
        private IEmployeeConfiguration<Nurse> _nurseConfiguration = new NurseService();
        private Validate validator = new Validate();

        public ShiftsPnlView()
        {
            InitializeComponent();
        }
        public ShiftsPnlView(Context context)
        {
            _context = context;
            InitializeComponent();
            this.DutyDataGrid.DataSource = context.Duties;
            activeDuty = _dutyConfiguration.FindFirstByCondition(1, _context);
        }

        private readonly Context _context;
        private Duty activeDuty = new Duty();
        private void AddDutyBtn_Click(object sender, System.EventArgs e)
        {
            Duty duty = new Duty();
            duty = setDutyTerm(duty);
            _dutyConfiguration = new DutyService();
            _dutyConfiguration.Add(duty, _context);
            DutyDataGrid.DataSource = GetDuties();
            //wyswietl wszystkie zmiany (shifts) dla danego dyzuru(duty)
            ShiftsDataGrid.DataSource = GetShifts(duty);
            activeDuty = duty;
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
            //ustawia zmianie medyka
            shift = setShiftValues(shift);
            //dodaje zmiane do listy wszystkich zmian
            _shiftConfiguration.Add(shift, _context);
            //dodaje zmiane do dyzuru i aktualizuje liste wszystkich wdyzurow
            _dutyConfiguration.AddShift(activeDuty, shift, _context);
            //ustawia dane dla ShiftsGrid
            ShiftsDataGrid.DataSource = SetDataSource();
        }

        private Shift setShiftValues(Shift shift)
        {
            shift.ShiftDate = activeDuty.Term;
            shift.Medic = new Medic();
            var employeeId = Convert.ToInt32(EmpIdTbox.Text.ToString());
            shift.Medic = validator.FindMedic(employeeId, _context);
            //ustawia (dodaje) medykowi zmiane (shift)
            SetMedicShift(employeeId, shift);
            return shift;
        }

        private void SetMedicShift(int id, Shift shift)
        {
            var type = validator.FindEmployeeType(id, _context);
            if (type == 2)
            {
                var physician = _physicianConfiguration.FindFirstByCondition(id, _context);
                _physicianConfiguration.AddShift(physician, shift, _context);
            }
            if (type == 3)
            {
                var nurse = _nurseConfiguration.FindFirstByCondition(id, _context);
                _nurseConfiguration.AddShift(nurse, shift, _context);
            }
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
            activeDuty = _dutyConfiguration.FindFirstByCondition(dutyId, _context);
            ShiftsDataGrid.DataSource = SetDataSource();
        }

        public List<ShiftSource> SetDataSource()
        {
            //pobiera wszystkie zmiany z aktywnego dyzuru
            var shifts = GetShifts(activeDuty);
            //tworzy nowy obiekt danych dla ShiftGrid
            List<ShiftSource> shiftSource = new List<ShiftSource>();
            //szuka w liscie zmian aktywnego dyzuru
            int counter = 0;
            foreach (var item in shifts)
            {
                //szuka lekarza o podanym id
                var physician = _physicianConfiguration.FindFirstByCondition(item.Medic.Id, _context);
                //szuka pielegniarki o podanym id
                var nurse = _nurseConfiguration.FindFirstByCondition(item.Medic.Id, _context);
                //jesli znalazl lekarza, ustawia dane do wyswietlenia
                if (physician != null)
                {
                    shiftSource.Add(new ShiftSource { ShiftId = item.Id, MedicName = physician.Name, MedicId = physician.Id, Profession = "lekarz", Specialization = physician.Specialization.ToString() });
                    if (item.Medic.Sex == Model.Helpers.Sex.female)
                    {
                        shiftSource[counter].Profession = "lekarka";
                    }
                }
                //jesli znalazl pielegniarke ustawia dane do wyswietlenia
                if (nurse != null)
                {
                    shiftSource.Add(new ShiftSource { ShiftId = item.Id, MedicName = nurse.Name, MedicId = nurse.Id, Profession = "pielęgniarz", Specialization = "" });
                    if (item.Medic.Sex == Model.Helpers.Sex.female)
                    {
                        shiftSource[counter].Profession = "pielęgniarka";
                    }
                }
                counter++;
            }

            return shiftSource;
        }

        private void EmpIdTbox_TextChanged(object sender, EventArgs e)
        {
            MedicSpecTbox.Clear();
            if (EmpIdTbox.Text.ToString() != "")
            {
                var text = Convert.ToInt32(EmpIdTbox.Text.ToString());
                if (text.GetType().ToString() == "System.Int32")
                {
                    var type = validator.FindEmployeeType(text, _context);
                    if (type == 0)
                    {
                        string message = "Nie istnieje pracownik o podanym id";
                        string caption = "Error Detected in Input";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                    }
                    if (type == 1)
                    {
                        string message = "Szukany pracownik to admin.";
                        string caption = "Error Detected in Input";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);

                        var admin = _adminConfiguration.FindFirstByCondition(text, _context);
                        MedicNameTbox.Text = admin.Name;

                    }
                    if (type == 2)
                    {
                        var physician = _physicianConfiguration.FindFirstByCondition(text, _context);
                        MedicNameTbox.Text = physician.Name;
                        MedicSpecTbox.Text = physician.Specialization.ToString();
                        if (physician.Sex == Model.Helpers.Sex.female)
                        {
                            MedicTypeTbox.Text = "lekarka";
                        }
                        else MedicTypeTbox.Text = "lekarz";
                    }
                    if (type == 3)
                    {
                        var nurse = _nurseConfiguration.FindFirstByCondition(text, _context);
                        MedicNameTbox.Text = nurse.Name;
                        if (nurse.Sex == Model.Helpers.Sex.female)
                        {
                            MedicTypeTbox.Text = "pielęgniarka";
                        }
                        else MedicTypeTbox.Text = "pielęgniarz";
                    }
                }
                else
                {
                    string message = "Wprowadzono błędny typ danych. Wpisz numer.";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }
            }
        }
    }
}
