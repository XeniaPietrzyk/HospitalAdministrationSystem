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
        private IEmployeeController<Admin> _adminConfiguration;
        private IEmployeeController<Nurse> _nurseConfiguration;
        private IEmployeeController<Physician> _physicianConfiguration;
        //private IEmployeeConfiguration<Shift> _shiftConfiguration;

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
        private IQueryable<Admin> adminsList { get; set; }
        private IQueryable<Nurse> nurseList { get; set; }
        private IQueryable<Physician> physicianList { get; set; }

        private string ActiveEmployee = "admin";
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

        private List<Admin> GetAdminList()
        {
            _adminConfiguration = new AdminController();
            adminsList = _adminConfiguration.GetAll(_context);
            return adminsList.ToList();
        }

        private List<Physician> GetPhysicianList()
        {
            _physicianConfiguration = new PhysicianController();
            physicianList = _physicianConfiguration.GetAll(_context);
            return physicianList.ToList();
        }

        private List<Nurse> GetNurseList()
        {
            _nurseConfiguration = new NurseController();
            nurseList = _nurseConfiguration.GetAll(_context);
            return nurseList.ToList();
        }

        private void NurseGridViewBtn_Click(object sender, EventArgs e)
        {
            ActiveEmployee = "nurse";
            EmployeeGrid.DataSource = GetNurseList();
            addAdminPanel1.Hide();
            addPhysicianPanel1.Hide();
            addNursePanel1.Show();
        }

        private void PhysGridViewBtn_Click(object sender, EventArgs e)
        {
            ActiveEmployee = "physician";
            EmployeeGrid.DataSource = GetPhysicianList();
            addAdminPanel1.Hide();
            addNursePanel1.Hide();
            addPhysicianPanel1.Show();
        }

        private void AdminGridViewBtn_Click(object sender, EventArgs e)
        {
            ActiveEmployee = "admin";
            EmployeeGrid.DataSource = GetAdminList();
            addPhysicianPanel1.Hide();
            addNursePanel1.Hide();
            addAdminPanel1.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (EmployeeGrid.SelectedRows.Count == 1)
            {
                var rowindex = EmployeeGrid.CurrentCell.RowIndex;
                var idRow = Convert.ToInt32(EmployeeGrid.Rows[rowindex].Cells[1].Value.ToString());
                var nameRow = EmployeeGrid.Rows[rowindex].Cells[2].Value.ToString();
                var peselRow = long.Parse(EmployeeGrid.Rows[rowindex].Cells[3].Value.ToString());
                var sexRow = EmployeeGrid.Rows[rowindex].Cells[4].Value.ToString();
                var userNameRow = EmployeeGrid.Rows[rowindex].Cells[5].Value.ToString();
                var passwordRow = EmployeeGrid.Rows[rowindex].Cells[6].Value.ToString();
                var permissionRow = EmployeeGrid.Rows[rowindex].Cells[7].Value.ToString();

                if (ActiveEmployee == "Admin")
                {
                    Admin newAdmin = new Admin()
                    {
                        Id = idRow,
                        Name = nameRow,
                        Pesel = peselRow,
                        UserName = userNameRow,
                        Password = passwordRow,
                    };
                    if (sexRow == "female")
                    {
                        newAdmin.Sex = Model.Helpers.Sex.female;
                    }
                    else newAdmin.Sex = Model.Helpers.Sex.male;

                    if (permissionRow == "admin")
                    {
                        newAdmin.Permission = Model.Helpers.Permission.admin;
                    }
                    else newAdmin.Permission = Model.Helpers.Permission.employee;

                    _adminConfiguration.Update(newAdmin, _context);
                }

                if (ActiveEmployee == "Nurse")
                {
                    Nurse newNurse = new Nurse() 
                    {
                        Id = idRow,
                        Name = nameRow,
                        Pesel = peselRow,
                        UserName = userNameRow,
                        Password = passwordRow,
                    };
                    if (sexRow == "female")
                    {
                        newNurse.Sex = Model.Helpers.Sex.female;
                    }
                    else newNurse.Sex = Model.Helpers.Sex.male;

                    if (permissionRow == "admin")
                    {
                        newNurse.Permission = Model.Helpers.Permission.admin;
                    }
                    else newNurse.Permission = Model.Helpers.Permission.employee;

                    _nurseConfiguration.Update(newNurse, _context);
                    newNurse.Shift = _nurseConfiguration.FindFirstByCondition(newNurse.Id, _context).Shift;
                }
                if (ActiveEmployee == "Physician")
                {
                    var spec = EmployeeGrid.Rows[rowindex].Cells[8].Value.ToString();
                    var pwzNumber = Convert.ToInt32(EmployeeGrid.Rows[rowindex].Cells[9].Value.ToString());

                    Physician newPhysician = new Physician()
                    {
                        Id = idRow,
                        Name = nameRow,
                        Pesel = peselRow,
                        UserName = userNameRow,
                        Password = passwordRow,
                        PWZNumber = pwzNumber
                    };
                    if (sexRow == "female")
                    {
                        newPhysician.Sex = Model.Helpers.Sex.female;
                    }
                    else newPhysician.Sex = Model.Helpers.Sex.male;

                    if (permissionRow == "admin")
                    {
                        newPhysician.Permission = Model.Helpers.Permission.admin;
                    }
                    else newPhysician.Permission = Model.Helpers.Permission.employee;
                    
                    if (spec == "cardiology")
                    {
                        newPhysician.Specialization = Model.Helpers.Specialization.cardiology;
                    }
                    else if (spec == "urology")
                    {
                        newPhysician.Specialization = Model.Helpers.Specialization.urology;
                    }
                    else if (spec == "neurology")
                    {
                        newPhysician.Specialization = Model.Helpers.Specialization.neurology;
                    }
                    else newPhysician.Specialization = Model.Helpers.Specialization.laryngology;

                    _physicianConfiguration.Update(newPhysician, _context);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var rowindex = EmployeeGrid.CurrentCell.RowIndex;
            var idRow = EmployeeGrid.Rows[rowindex].Cells["Id"].Value.ToString();
            int id = Convert.ToInt32(idRow);
            if (id != 0)
            {
                if (ActiveEmployee == "admin")
                {
                    _adminConfiguration.Delete(id, _context);
                }
                if (ActiveEmployee == "physician")
                {
                    _physicianConfiguration.Delete(id, _context);
                }
                if (ActiveEmployee == "nurse")
                {
                    _nurseConfiguration.Delete(id, _context);
                }
            }
            else
            {
                string message = "Nie można usunąć użytkownika o id = 0";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            
        }

        private void EmployeeGrid_ParentChanged(object sender, EventArgs e)
        {
            EmployeeGrid.Refresh();
        }
    }
}
