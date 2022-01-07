using Model;
using Model.Controller;
using Model.Model;
using Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HospitalGUI.UserControls
{
    public partial class EmployeesPnlView : UserControl
    {
        private IEmployeeConfiguration<Admin> _adminConfiguration;
        private IEmployeeConfiguration<Nurse> _nurseConfiguration;
        private IEmployeeConfiguration<Physician> _physicianConfiguration;

        public EmployeesPnlView()
        {
            InitializeComponent();
        }

        public EmployeesPnlView(Context context, Employee employee)
        {
            _context = context;
            _employee = employee;
            InitializeComponent();
            this.EmployeeGrid.DataSource = GetAdminList();
            addPhysicianPanel1.Hide();
            addNursePanel1.Hide();
            addAdminPanel1.Show();
        }

        private Employee _employee { get; set; }
        private Context _context { get; set; }
        private IQueryable<Employee> employeeList { get; set; }

        private void InitializeEmployeeGrid()
        {
            // 
            // NurseGridViewBtn
            // 
            this.NurseGridViewBtn.Location = new System.Drawing.Point(500, 20);
            this.NurseGridViewBtn.Name = "NurseGridViewBtn";
            this.NurseGridViewBtn.Size = new System.Drawing.Size(100, 100);
            this.NurseGridViewBtn.TabIndex = 3;
            this.NurseGridViewBtn.Image = global::HospitalGUI.Properties.Resources.Nurse1;
            this.NurseGridViewBtn.UseVisualStyleBackColor = true;
            this.NurseGridViewBtn.UseVisualStyleBackColor = false;
            this.NurseGridViewBtn.FlatAppearance.BorderSize = 0;
            this.NurseGridViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NurseGridViewBtn.Click += new System.EventHandler(this.NurseGridViewBtn_Click);
            // 
            // PhysGridViewBtn
            // 
            this.PhysGridViewBtn.Location = new System.Drawing.Point(270, 20);
            this.PhysGridViewBtn.Name = "PhysGridViewBtn";
            this.PhysGridViewBtn.Size = new System.Drawing.Size(100, 100);
            this.PhysGridViewBtn.TabIndex = 2;
            this.PhysGridViewBtn.Image = global::HospitalGUI.Properties.Resources.Physician1;
            this.PhysGridViewBtn.UseVisualStyleBackColor = true;
            this.PhysGridViewBtn.UseVisualStyleBackColor = false;
            this.PhysGridViewBtn.FlatAppearance.BorderSize = 0;
            this.PhysGridViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhysGridViewBtn.Click += new System.EventHandler(this.PhysGridViewBtn_Click);

            // 
            // AdminGridViewBtn
            // 
            this.AdminGridViewBtn.Location = new System.Drawing.Point(40, 20);
            this.AdminGridViewBtn.Name = "AdminGridViewBtn";
            this.AdminGridViewBtn.Size = new System.Drawing.Size(100, 100);
            this.AdminGridViewBtn.TabIndex = 1;
            this.AdminGridViewBtn.Image = global::HospitalGUI.Properties.Resources.Admin1;
            this.AdminGridViewBtn.UseVisualStyleBackColor = true;
            this.AdminGridViewBtn.UseVisualStyleBackColor = false;
            this.AdminGridViewBtn.FlatAppearance.BorderSize = 0;
            this.AdminGridViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminGridViewBtn.Click += new System.EventHandler(this.AdminGridViewBtn_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.EmployeeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmployeeGrid.Location = new System.Drawing.Point(0, 300);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.RowTemplate.Height = 25;
            this.EmployeeGrid.Size = new System.Drawing.Size(620, 500);
            this.EmployeeGrid.TabIndex = 5;
            this.EmployeeGrid.DataSource = GetAdminList();
            this.EmployeeGrid.Columns[0].Width = 40;
            this.EmployeeGrid.Columns[1].Width = 120;
            this.EmployeeGrid.Columns[3].Width = 60;
            this.EmployeeGrid.Columns[5].Width = 120;
            this.EmployeeGrid.Columns[6].Width = 80;
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

        private void NurseGridViewBtn_Click(object sender, EventArgs e)
        {
            EmployeeGrid.DataSource = GetNurseList();
            addAdminPanel1.Hide();
            addPhysicianPanel1.Hide();
            addNursePanel1.Show();
        }

        private void PhysGridViewBtn_Click(object sender, EventArgs e)
        {
            EmployeeGrid.DataSource = GetPhysicianList();
            addAdminPanel1.Hide();
            addNursePanel1.Hide();
            addPhysicianPanel1.Show();
        }

        private void AdminGridViewBtn_Click(object sender, EventArgs e)
        {
            EmployeeGrid.DataSource = GetAdminList();
            addPhysicianPanel1.Hide();
            addNursePanel1.Hide();
            addAdminPanel1.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            var updateEmployee = EmployeeGrid.SelectedRows;

        }

    }
}
