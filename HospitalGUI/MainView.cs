//icons: <a href='https://www.freepik.com/vectors/icons'>Icons vector created by macrovector - www.freepik.com</a>

using Model;
using Model.Controller;
using Model.Model;
using Model.Service;
using Model.Services;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HospitalGUI
{    public partial class MainView : Form
    {
        private IEmployeeConfiguration<Admin> _adminConfiguration;
        private IEmployeeConfiguration<Nurse> _nurseConfiguration;
        private IEmployeeConfiguration<Physician> _physicianConfiguration;
        private IShiftConfiguration<Medic> _shiftConfiguration;

        public MainView(Context context, Employee employee)
        {
            _context = context;
            _employee = employee;
            InitializeComponent();
            if (GetEmployeeType(employee) == "Admin")
            {
                InitializeAdminComponent();
            }
            employeesPnlView1.Hide();
            SetPositionIcon(employee);

            NavMarkPnl.Height = NavShiftsBtn.Height;
            NavMarkPnl.Top = NavShiftsBtn.Top;
            NavMarkPnl.Left = NavShiftsBtn.Left;
            NavShiftsBtn.BackColor = Color.FromArgb(248, 252, 255);

            PositionLbl.Text = GetEmployeeType(employee);
            NameLbl.Text = employee.Name;
        }

        private Employee _employee { get; set; }
        private readonly Context _context;
        private IQueryable<Employee> employeeList { get; set; }

        public string GetEmployeeType(Employee employee)
        {
            var employeeRowType = employee.GetType().ToString();
            var employeeType = employeeRowType.Split(".");
            if (employeeType.Last() == "Nurse")
            {
                if (employee.Sex == Model.Helpers.Sex.female)
                {
                    return "Pielęgniarka";
                }
                else return "Pielęgniarz";
            }
            if (employeeType.Last() == "Physician")
            {
                if (employee.Sex == Model.Helpers.Sex.female)
                {
                    return "Lekarka";
                }
                else return "Lekarz";
            }
            return employeeType.Last();
        }

        public void SetPositionIcon(Employee employee)
        {
            var employeePosition = GetEmployeeType(employee);
            //wybór ikonki :
            if (employeePosition == "Admin")
            {
                pictureBox1.Image = global::HospitalGUI.Properties.Resources.Admin;
            }
            if (employeePosition == "Pielęgniarka" || employeePosition == "Pielęgniarz")
            {
                pictureBox1.Image = global::HospitalGUI.Properties.Resources.Nurse;
            }
            if (employeePosition == "Lekarz" || employeePosition == "Lekarka")
            {
                pictureBox1.Image = global::HospitalGUI.Properties.Resources.Physician;
            }
        }

        private void NavShiftsBtn_Click(object sender, System.EventArgs e)
        {
            NavMarkPnl.Height = NavShiftsBtn.Height;
            NavMarkPnl.Top = NavShiftsBtn.Top;
            NavMarkPnl.Left = NavShiftsBtn.Left;
            NavShiftsBtn.BackColor = Color.FromArgb(248, 252, 255);
            NavEmplBtn.BackColor = Color.FromArgb(235, 243, 250);
            if (GetEmployeeType(_employee) == "Admin")
            {

            }
            employeesPnlView1.Hide();
            shiftsPnlView1.Show();
        }

        private void NavEmplBtn_Click(object sender, System.EventArgs e)
        {
            NavMarkPnl.Height = NavEmplBtn.Height;
            NavMarkPnl.Top = NavEmplBtn.Top;
            NavMarkPnl.Left = NavEmplBtn.Left;
            NavEmplBtn.BackColor = Color.FromArgb(248, 252, 255);
            NavShiftsBtn.BackColor = Color.FromArgb(235, 243, 250);
            //GetAdminList();
            //GetPhysicianList();
            //GetNurseList();
            shiftsPnlView1.Hide();
            employeesPnlView1.Show();
        }

        private List<Employee> GetAdminList()
        {
            _adminConfiguration = new AdminService();
            employeeList = _adminConfiguration.GetAll(_context);
            return employeeList.ToList();
        }

        private List<Employee> GetPhysicianList()
        {
            _physicianConfiguration = new PhysicianService();
            employeeList = _physicianConfiguration.GetAll(_context);
            return employeeList.ToList();
        }

        private List<Employee> GetNurseList()
        {
            _nurseConfiguration = new NurseService();
            employeeList = _nurseConfiguration.GetAll(_context);
            return employeeList.ToList();
        }
        public List<Shift> GetAllShifts()
        {
            _shiftConfiguration = new ShiftService();
            var allShifts = _shiftConfiguration.GetAll(_context);
            return allShifts.ToList();
        }

        private void NavLogoutBtn_Click(object sender, System.EventArgs e)
        {
            NavMarkPnl.Height = NavLogoutBtn.Height;
            NavMarkPnl.Top = NavLogoutBtn.Top;
            NavMarkPnl.Left = NavLogoutBtn.Left;
            NavLogoutBtn.BackColor = Color.FromArgb(235, 243, 250);

            _context.SaveDataBase();
            LoginView loginView = new LoginView();
            loginView.Show();
            _employee = null;
            this.Close();
        }

        private void AdminGridViewBtn_Click(object sender, System.EventArgs e)
        {
            EmployeeGrid.DataSource = GetAdminList();
        }

        private void PhysGridViewBtn_Click(object sender, System.EventArgs e)
        {
            EmployeeGrid.DataSource = GetPhysicianList();
        }

        private void NurseGridViewBtn_Click(object sender, System.EventArgs e)
        {
            EmployeeGrid.DataSource = GetNurseList();
        }
    }
}
