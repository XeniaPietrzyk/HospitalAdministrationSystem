
namespace HospitalGUI.UserControls
{
    partial class EmployeesPnlView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeesPnl = new System.Windows.Forms.Panel();
            this.addNursePanel1 = new HospitalGUI.UserControls.AddNursePanel(_context);
            this.addAdminPanel1 = new HospitalGUI.UserControls.AddAdminPanel(_context);
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.AdminGridViewBtn = new System.Windows.Forms.Button();
            this.PhysGridViewBtn = new System.Windows.Forms.Button();
            this.NurseGridViewBtn = new System.Windows.Forms.Button();
            this.addPhysicianPanel1 = new HospitalGUI.UserControls.AddPhysicianPanel(_context);
            this.EmployeesPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesPnl
            // 
            this.EmployeesPnl.Controls.Add(this.addPhysicianPanel1);
            this.EmployeesPnl.Controls.Add(this.addNursePanel1);
            this.EmployeesPnl.Controls.Add(this.addAdminPanel1);
            this.EmployeesPnl.Controls.Add(this.EmployeeGrid);
            this.EmployeesPnl.Controls.Add(this.AdminGridViewBtn);
            this.EmployeesPnl.Controls.Add(this.PhysGridViewBtn);
            this.EmployeesPnl.Controls.Add(this.NurseGridViewBtn);
            this.EmployeesPnl.Location = new System.Drawing.Point(15, 15);
            this.EmployeesPnl.Name = "EmployeesPnl";
            this.EmployeesPnl.Size = new System.Drawing.Size(615, 570);
            this.EmployeesPnl.TabIndex = 1;
            // 
            // addNursePanel1
            // 
            this.addNursePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.addNursePanel1.Location = new System.Drawing.Point(8, 135);
            this.addNursePanel1.Name = "addNursePanel1";
            this.addNursePanel1.Size = new System.Drawing.Size(600, 155);
            this.addNursePanel1.TabIndex = 5;
            // 
            // addAdminPanel1
            // 
            this.addAdminPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.addAdminPanel1.Location = new System.Drawing.Point(8, 135);
            this.addAdminPanel1.Name = "addAdminPanel1";
            this.addAdminPanel1.Size = new System.Drawing.Size(600, 155);
            this.addAdminPanel1.TabIndex = 4;
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmployeeGrid.Location = new System.Drawing.Point(0, 297);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.RowTemplate.Height = 25;
            this.EmployeeGrid.Size = new System.Drawing.Size(615, 273);
            this.EmployeeGrid.TabIndex = 3;
            // 
            // AdminGridViewBtn
            // 
            this.AdminGridViewBtn.FlatAppearance.BorderSize = 0;
            this.AdminGridViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminGridViewBtn.Image = global::HospitalGUI.Properties.Resources.Admin;
            this.AdminGridViewBtn.Location = new System.Drawing.Point(30, 3);
            this.AdminGridViewBtn.Name = "AdminGridViewBtn";
            this.AdminGridViewBtn.Size = new System.Drawing.Size(125, 125);
            this.AdminGridViewBtn.TabIndex = 2;
            this.AdminGridViewBtn.UseVisualStyleBackColor = true;
            this.AdminGridViewBtn.Click += new System.EventHandler(this.AdminGridViewBtn_Click);
            // 
            // PhysGridViewBtn
            // 
            this.PhysGridViewBtn.FlatAppearance.BorderSize = 0;
            this.PhysGridViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhysGridViewBtn.Image = global::HospitalGUI.Properties.Resources.Physician1;
            this.PhysGridViewBtn.Location = new System.Drawing.Point(250, 3);
            this.PhysGridViewBtn.Name = "PhysGridViewBtn";
            this.PhysGridViewBtn.Size = new System.Drawing.Size(125, 125);
            this.PhysGridViewBtn.TabIndex = 1;
            this.PhysGridViewBtn.UseVisualStyleBackColor = true;
            this.PhysGridViewBtn.Click += new System.EventHandler(this.PhysGridViewBtn_Click);
            // 
            // NurseGridViewBtn
            // 
            this.NurseGridViewBtn.FlatAppearance.BorderSize = 0;
            this.NurseGridViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NurseGridViewBtn.Image = global::HospitalGUI.Properties.Resources.Nurse1;
            this.NurseGridViewBtn.Location = new System.Drawing.Point(460, 2);
            this.NurseGridViewBtn.Name = "NurseGridViewBtn";
            this.NurseGridViewBtn.Size = new System.Drawing.Size(125, 125);
            this.NurseGridViewBtn.TabIndex = 0;
            this.NurseGridViewBtn.UseVisualStyleBackColor = true;
            this.NurseGridViewBtn.Click += new System.EventHandler(this.NurseGridViewBtn_Click);
            // 
            // addPhysicianPanel1
            // 
            this.addPhysicianPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.addPhysicianPanel1.Location = new System.Drawing.Point(8, 135);
            this.addPhysicianPanel1.Name = "addPhysicianPanel1";
            this.addPhysicianPanel1.Size = new System.Drawing.Size(600, 155);
            this.addPhysicianPanel1.TabIndex = 6;
            // 
            // EmployeesPnlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.EmployeesPnl);
            this.Name = "EmployeesPnlView";
            this.Size = new System.Drawing.Size(650, 600);
            this.EmployeesPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EmployeesPnl;
        private System.Windows.Forms.Button NurseGridViewBtn;
        private System.Windows.Forms.Button AdminGridViewBtn;
        private System.Windows.Forms.Button PhysGridViewBtn;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private AddAdminPanel addAdminPanel1;
        private AddNursePanel addNursePanel1;
        private AddPhysicianPanel addPhysicianPanel1;
    }
}
