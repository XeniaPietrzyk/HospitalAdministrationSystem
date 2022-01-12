
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.AdminGridViewBtn = new System.Windows.Forms.Button();
            this.PhysGridViewBtn = new System.Windows.Forms.Button();
            this.NurseGridViewBtn = new System.Windows.Forms.Button();
            this.addPhysicianPanel1 = new HospitalGUI.UserControls.AddPhysicianPanel(_context);
            this.addNursePanel1 = new HospitalGUI.UserControls.AddNursePanel(_context);
            this.addAdminPanel1 = new HospitalGUI.UserControls.AddAdminPanel(_context);
            this.EmployeesPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesPnl
            // 
            this.EmployeesPnl.Controls.Add(this.addAdminPanel1);
            this.EmployeesPnl.Controls.Add(this.addNursePanel1);
            this.EmployeesPnl.Controls.Add(this.addPhysicianPanel1);
            this.EmployeesPnl.Controls.Add(this.DeleteBtn);
            this.EmployeesPnl.Controls.Add(this.UpdateBtn);
            this.EmployeesPnl.Controls.Add(this.EmployeeGrid);
            this.EmployeesPnl.Controls.Add(this.AdminGridViewBtn);
            this.EmployeesPnl.Controls.Add(this.PhysGridViewBtn);
            this.EmployeesPnl.Controls.Add(this.NurseGridViewBtn);
            this.EmployeesPnl.Location = new System.Drawing.Point(15, 15);
            this.EmployeesPnl.Name = "EmployeesPnl";
            this.EmployeesPnl.Size = new System.Drawing.Size(615, 570);
            this.EmployeesPnl.TabIndex = 1;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.DeleteBtn.Location = new System.Drawing.Point(384, 531);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(90, 30);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Usuń";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.UpdateBtn.Location = new System.Drawing.Point(513, 531);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(90, 30);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Edytuj";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Location = new System.Drawing.Point(0, 297);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.RowTemplate.Height = 25;
            this.EmployeeGrid.Size = new System.Drawing.Size(615, 224);
            this.EmployeeGrid.TabIndex = 3;
            this.EmployeeGrid.ParentChanged += new System.EventHandler(this.EmployeeGrid_ParentChanged);
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
            // addPhysicianPanel2
            // 
            this.addPhysicianPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.addPhysicianPanel1.Location = new System.Drawing.Point(5, 134);
            this.addPhysicianPanel1.Name = "addPhysicianPanel1";
            this.addPhysicianPanel1.Size = new System.Drawing.Size(610, 155);
            this.addPhysicianPanel1.TabIndex = 6;
            // 
            // addNursePanel2
            // 
            this.addNursePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.addNursePanel1.Location = new System.Drawing.Point(5, 134);
            this.addNursePanel1.Name = "addNursePanel1";
            this.addNursePanel1.Size = new System.Drawing.Size(610, 155);
            this.addNursePanel1.TabIndex = 7;
            // 
            // addAdminPanel2
            // 
            this.addAdminPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.addAdminPanel1.Location = new System.Drawing.Point(5, 134);
            this.addAdminPanel1.Name = "addAdminPanel1";
            this.addAdminPanel1.Size = new System.Drawing.Size(610, 155);
            this.addAdminPanel1.TabIndex = 8;
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
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}
