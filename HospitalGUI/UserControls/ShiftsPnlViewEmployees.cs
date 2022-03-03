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
    public partial class ShiftsPnlViewEmployees : UserControl
    {
        private IEmployeeController<Duty> _dutyConfiguration = new DutyController();
        private IShiftController<Medic> _shiftConfiguration = new ShiftController();
        private IEmployeeController<Physician> _physicianConfiguration = new PhysicianController();
        private IEmployeeController<Nurse> _nurseConfiguration = new NurseController();
        private Validate validator = new Validate();

        public ShiftsPnlViewEmployees()
        {
            InitializeComponent();
        }
        public ShiftsPnlViewEmployees(Medic medic, Context context)
        {
            _context = context;
            activeMedic = medic;
            InitializeComponent();
            this.DutyDataGrid.DataSource = context.Duties;
            activeDuty = _dutyConfiguration.FindFirstByCondition(1, _context);
            if (activeDuty != null)
            {
                if (activeDuty.Shifts.Count != 0)
                {
                    activeShift = activeDuty.Shifts[0];
                    ShiftsDataGrid.DataSource = SetDataSource();
                }
            }
        }

        private readonly Context _context;
        private Duty activeDuty = new Duty();
        private Shift activeShift = new Shift();
        private Medic activeMedic;
        private void AddShiftBtn_Click(object sender, EventArgs e)
        {
            activeShift = new Shift();
            if (activeDuty != null)
            {
                //ustawia zmianie parametry
                activeShift = SetShiftValues(activeShift);
                //dodaje zmiane do dyzuru i aktualizuje liste wszystkich dyzurow
                AddShiftToDuty(activeDuty, activeShift);
                //ustawia dane dla ShiftsGrid
                ShiftsDataGrid.DataSource = SetDataSource();
            }
            else
            {
                string message = "Nie można dodać zmiany bez dyżuru. Dodaj nowy dyżur";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }
        }

        private void EditShiftBtn_Click(object sender, EventArgs e)
        {
            if (activeShift!=null)
            {
                _shiftConfiguration.Update(activeShift, _context);
            }
        }

        //po kliknieciu elementu w DutyGrid
        private void DutyDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //znajduje index wiersza w gridzie
            var row = e.RowIndex;
            //znajduje wartosc w kolumnie o nazwie "Id" w wierszu row
            var dutyId = Convert.ToInt32(DutyDataGrid.Rows[row].Cells["Id"].Value.ToString());
            //ustawia zmiennej activeDuty znalezione w liscie Duties duty (dyzur)
            activeDuty = _dutyConfiguration.FindFirstByCondition(dutyId, _context);
            //ustawia widok zmian w ShiftGrid 
            ShiftsDataGrid.DataSource = SetDataSource();
        }

        //po kliknieciu elementu w ShiftGrid
        private void ShiftsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var shiftId = Convert.ToInt32(ShiftsDataGrid.Rows[row].Cells["ShiftId"].Value.ToString());
            activeShift = _shiftConfiguration.FindFirstByCondition(shiftId, _context);
        }

        private Shift SetShiftValues(Shift shift)
        {
            //jesli taki shift nie istnieje, tworzy shift
            var existingShift = _shiftConfiguration.FindFirstByCondition(shift.Id, _context);
            if (existingShift == null)
            {
                //tworzy nowy shift i dodaje do AllShifts
                //dzieki temu shift ma poprawne id
                shift = _shiftConfiguration.Add(shift, _context);
                //ustawia date i medyka dla shift
                shift.ShiftDate = activeDuty.Term;
                //ustawia zmianie medyka i
                //ustawia (dodaje) medykowi zmiane (shift)
                shift.Medic = activeMedic;
                SetMedicShift(activeMedic.Id, shift);
            }
            //jesli shift istnieje
            else
            {
                string message = "Medyk posiada już zmianę w tym dużurze.";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }
            return shift;
        }

        private void SetMedicShift(int id, Shift shift)
        {
            var type = validator.FindEmployeeType(id, _context);
            if (type == 2)
            {
                var physician = _physicianConfiguration.FindFirstByCondition(id, _context);
                //sprawdza, czy istnieje juz taka zmiana
                var exist = physician.Shift.Contains(shift);
                //sprawdza, czy medyk nie ma zmiany poprzedniego dnia
                var shiftBreakExist = validator.hasShiftBreak(physician, shift);
                //jesli istnieje juz taka zmiana
                if (exist)
                {
                    string message = "Medyk posiada już zmianę w tym dużurze.";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, caption, buttons);
                }
                else if (shiftBreakExist)
                {
                    shift = _physicianConfiguration.AddShift(physician, shift, _context);
                    //aktualizuje liste wszystkich zmian
                    _shiftConfiguration.Update(shift, _context);
                }
                else
                {
                    string message = "Medyk powinien mieć co najmniej 1 dzień przerwy pomiędzy zmianami.";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, caption, buttons);
                }
            }
            //analogicznie do powyzszego
            if (type == 3)
            {
                var nurse = _nurseConfiguration.FindFirstByCondition(id, _context);
                //sprawdza, czy istnieje juz taka zmiana
                var exist = nurse.Shift.Contains(shift);
                //sprawdza, czy medyk nie ma zmiany poprzedniego dnia
                var shiftBreakExist = validator.hasShiftBreak(nurse, shift);
                //jesli istnieje juz taka zmiana
                if (exist)
                {
                    string message = "Medyk posiada już zmianę w tym dużurze.";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, caption, buttons);
                }
                else if (shiftBreakExist)
                {
                    shift = _nurseConfiguration.AddShift(nurse, shift, _context);
                    //aktualizuje liste wszystkich zmian
                    _shiftConfiguration.Update(shift, _context);
                }
                else
                {
                    string message = "Medyk powinien mieć co najmniej 24 godziny przerwy pomiędzy zmianami.";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, caption, buttons);
                }
            }
        }
        private void AddShiftToDuty(Duty duty, Shift shift)
        {
            //czy istnieje juz taka zmiana
            var existingShift = _dutyConfiguration.GetShift(duty, shift.Id, _context);
            if (existingShift == null)
            {
                _dutyConfiguration.AddShift(activeDuty, activeShift, _context);
            }
        }

        //private List<Duty> GetDuties()
        //{
        //    IQueryable<Duty> duties = _dutyConfiguration.GetAll(_context);
        //    return duties.ToList();
        //}

        private List<Shift> GetShifts(Duty duty)
        {
            return _dutyConfiguration.GetShifts(duty, _context);
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

        private void DeleteShiftBtn_Click(object sender, EventArgs e)
        {
            //get id shifta
            //znajdz shift w allShifts
            var shift = _shiftConfiguration.FindFirstByCondition(activeShift.Id, _context);
            //znajdz typ pracownika: pielegniarz czy lekarz
            var employeeType = validator.FindEmployeeType(shift.Medic.Id, _context);
            if (employeeType == 2)
            {
                //var employee = _physicianConfiguration.FindFirstByCondition(shift.Medic.Id, _context);
                //usun shifta z pracownika
                _physicianConfiguration.DeleteShift(shift.Medic.Id, shift, _context);
            }
            if (employeeType == 1)
            {
                //var employee = _nurseConfiguration.FindFirstByCondition(shift.Medic.Id, _context);
                //usun shifta z pracownika
                _nurseConfiguration.DeleteShift(shift.Medic.Id, shift, _context);
            }
            //usun shifta z all shifts
            _shiftConfiguration.Delete(shift.Id, _context);
            //usun shifta z Duty (?)
            _dutyConfiguration.DeleteShift(activeDuty.Id, shift, _context);
            //ustaw widok ShiftsGrid
            ShiftsDataGrid.DataSource = SetDataSource();
        }       
    }
}
