using Model;
using Model.Controller;
using Model.Model;
using Model.Service;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HospitalGUI.UserControls
{
    public partial class ShiftsPnlView : UserControl
    {
        private IEmployeeConfiguration<Nurse> _nurseConfiguration;
        private IEmployeeConfiguration<Physician> _physicianConfiguration;

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
    }
}
