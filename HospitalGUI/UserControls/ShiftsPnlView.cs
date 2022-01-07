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
            // 
            // ShiftsGrid
            // 
            this.ShiftsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ShiftsGrid.BorderStyle = BorderStyle.None;
            this.ShiftsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ShiftsGrid.Location = new System.Drawing.Point(208, 12);
            this.ShiftsGrid.Name = "ShiftsGrid";
            this.ShiftsGrid.RowTemplate.Height = 25;
            this.ShiftsGrid.Size = new System.Drawing.Size(670, 600);
            this.ShiftsGrid.TabIndex = 1;
            //TODO: rozszerzyc source o pracownikow
            //powinno byc zbindowane pracownik + shift
            this.ShiftsGrid.DataSource = GetAllShifts();
        }

        public List<Shift> GetAllShifts()
        {
            _physicianConfiguration = new PhysicianService();
            List<Shift> allShifts = _physicianConfiguration.GetShift(_context);
            _nurseConfiguration = new NurseService();
            allShifts.AddRange(_nurseConfiguration.GetShift(_context));
            return allShifts.ToList();
        }

    }
}
