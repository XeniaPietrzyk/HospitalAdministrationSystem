
using Model;
using Model.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HospitalGUI
{
    partial class MainView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftMenuPnl = new System.Windows.Forms.Panel();
            this.NavMarkPnl = new System.Windows.Forms.Panel();
            this.NavEmplBtn = new System.Windows.Forms.Button();
            this.NavShiftsBtn = new System.Windows.Forms.Button();
            this.NavLogoutBtn = new System.Windows.Forms.Button();
            this.UserMenuPnl = new System.Windows.Forms.Panel();
            this.PositionLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.ShiftPnl = new System.Windows.Forms.Panel();
            this.ShiftsGrid = new System.Windows.Forms.DataGridView();
            this.EmployeesPnl = new System.Windows.Forms.Panel();
            this.NurseGridViewBtn = new System.Windows.Forms.Button();
            this.PhysGridViewBtn = new System.Windows.Forms.Button();
            this.AdminGridViewBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LeftMenuPnl.SuspendLayout();
            this.UserMenuPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            this.ShiftPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMenuPnl
            // 
            this.LeftMenuPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.LeftMenuPnl.Controls.Add(this.NavMarkPnl);
            this.LeftMenuPnl.Controls.Add(this.NavEmplBtn);
            this.LeftMenuPnl.Controls.Add(this.NavShiftsBtn);
            this.LeftMenuPnl.Controls.Add(this.NavLogoutBtn);
            this.LeftMenuPnl.Controls.Add(this.UserMenuPnl);
            this.LeftMenuPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenuPnl.Location = new System.Drawing.Point(0, 0);
            this.LeftMenuPnl.Name = "LeftMenuPnl";
            this.LeftMenuPnl.Size = new System.Drawing.Size(200, 623);
            this.LeftMenuPnl.TabIndex = 0;
            // 
            // NavMarkPnl
            // 
            this.NavMarkPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(240)))));
            this.NavMarkPnl.Location = new System.Drawing.Point(0, 183);
            this.NavMarkPnl.Name = "NavMarkPnl";
            this.NavMarkPnl.Size = new System.Drawing.Size(11, 100);
            this.NavMarkPnl.TabIndex = 1;
            // 
            // NavEmplBtn
            // 
            this.NavEmplBtn.FlatAppearance.BorderSize = 0;
            this.NavEmplBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavEmplBtn.Location = new System.Drawing.Point(33, 239);
            this.NavEmplBtn.Name = "NavEmplBtn";
            this.NavEmplBtn.Size = new System.Drawing.Size(75, 23);
            this.NavEmplBtn.TabIndex = 2;
            // 
            // NavShiftsBtn
            // 
            this.NavShiftsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NavShiftsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavShiftsBtn.FlatAppearance.BorderSize = 0;
            this.NavShiftsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavShiftsBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NavShiftsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(186)))), ((int)(((byte)(224)))));
            this.NavShiftsBtn.Image = global::HospitalGUI.Properties.Resources.HospitalIconS;
            this.NavShiftsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NavShiftsBtn.Location = new System.Drawing.Point(0, 183);
            this.NavShiftsBtn.Name = "NavShiftsBtn";
            this.NavShiftsBtn.Size = new System.Drawing.Size(200, 50);
            this.NavShiftsBtn.TabIndex = 4;
            this.NavShiftsBtn.Text = "Dyżury";
            this.NavShiftsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NavShiftsBtn.UseVisualStyleBackColor = true;
            this.NavShiftsBtn.Click += new System.EventHandler(this.NavShiftsBtn_Click);
            // 
            // NavLogoutBtn
            // 
            this.NavLogoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NavLogoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NavLogoutBtn.FlatAppearance.BorderSize = 0;
            this.NavLogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavLogoutBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NavLogoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(186)))), ((int)(((byte)(224)))));
            this.NavLogoutBtn.Image = global::HospitalGUI.Properties.Resources.logoutIcon3;
            this.NavLogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NavLogoutBtn.Location = new System.Drawing.Point(0, 573);
            this.NavLogoutBtn.Name = "NavLogoutBtn";
            this.NavLogoutBtn.Size = new System.Drawing.Size(200, 50);
            this.NavLogoutBtn.TabIndex = 3;
            this.NavLogoutBtn.Text = "Wyloguj";
            this.NavLogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NavLogoutBtn.UseVisualStyleBackColor = true;
            this.NavLogoutBtn.Click += new System.EventHandler(this.NavLogoutBtn_Click);
            // 
            // UserMenuPnl
            // 
            this.UserMenuPnl.Controls.Add(this.PositionLbl);
            this.UserMenuPnl.Controls.Add(this.NameLbl);
            this.UserMenuPnl.Controls.Add(this.pictureBox1);
            this.UserMenuPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserMenuPnl.Location = new System.Drawing.Point(0, 0);
            this.UserMenuPnl.Name = "UserMenuPnl";
            this.UserMenuPnl.Size = new System.Drawing.Size(200, 183);
            this.UserMenuPnl.TabIndex = 1;
            // 
            // PositionLbl
            // 
            this.PositionLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(240)))));
            this.PositionLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PositionLbl.ForeColor = System.Drawing.Color.White;
            this.PositionLbl.Location = new System.Drawing.Point(48, 140);
            this.PositionLbl.Name = "PositionLbl";
            this.PositionLbl.Padding = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.PositionLbl.Size = new System.Drawing.Size(100, 25);
            this.PositionLbl.TabIndex = 2;
            this.PositionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLbl
            // 
            this.NameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(205)))), ((int)(((byte)(240)))));
            this.NameLbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(56)))), ((int)(((byte)(98)))));
            this.NameLbl.Location = new System.Drawing.Point(33, 103);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Padding = new System.Windows.Forms.Padding(3, 4, 3, 5);
            this.NameLbl.Size = new System.Drawing.Size(130, 27);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalGUI.Properties.Resources.Nurse;
            this.pictureBox1.InitialImage = global::HospitalGUI.Properties.Resources.Physician;
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Data
            // 
            this.Data.Name = "Data";
            // 
            // Time
            // 
            this.Time.Name = "Time";
            // 
            // EmployeeId
            // 
            this.EmployeeId.Name = "EmployeeId";
            // 
            // Employee
            // 
            this.Employee.Name = "Employee";
            // 
            // EmployeeType
            // 
            this.EmployeeType.Name = "EmployeeType";
            // 
            // EmployeeSpec
            // 
            this.EmployeeSpec.Name = "EmployeeSpec";
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.EmployeeGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmployeeGrid.Location = new System.Drawing.Point(0, 171);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.Size = new System.Drawing.Size(573, 300);
            this.EmployeeGrid.TabIndex = 0;
            // 
            // ShiftPnl
            // 
            this.ShiftPnl.Controls.Add(this.ShiftsGrid);
            this.ShiftPnl.Location = new System.Drawing.Point(215, 12);
            this.ShiftPnl.Name = "ShiftPnl";
            this.ShiftPnl.Size = new System.Drawing.Size(573, 600);
            this.ShiftPnl.TabIndex = 1;
            // 
            // ShiftsGrid
            // 
            this.ShiftsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShiftsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ShiftsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShiftsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShiftsGrid.Location = new System.Drawing.Point(0, 0);
            this.ShiftsGrid.Name = "ShiftsGrid";
            this.ShiftsGrid.Size = new System.Drawing.Size(573, 322);
            this.ShiftsGrid.TabIndex = 0;
            // 
            // EmployeesPnl
            // 
            this.EmployeesPnl.Location = new System.Drawing.Point(215, 12);
            this.EmployeesPnl.Name = "EmployeesPnl";
            this.EmployeesPnl.Size = new System.Drawing.Size(670, 599);
            this.EmployeesPnl.TabIndex = 0;
            // 
            // NurseGridViewBtn
            // 
            this.NurseGridViewBtn.Location = new System.Drawing.Point(0, 0);
            this.NurseGridViewBtn.Name = "NurseGridViewBtn";
            this.NurseGridViewBtn.Size = new System.Drawing.Size(75, 23);
            this.NurseGridViewBtn.TabIndex = 0;
            // 
            // PhysGridViewBtn
            // 
            this.PhysGridViewBtn.Location = new System.Drawing.Point(0, 0);
            this.PhysGridViewBtn.Name = "PhysGridViewBtn";
            this.PhysGridViewBtn.Size = new System.Drawing.Size(75, 23);
            this.PhysGridViewBtn.TabIndex = 0;
            // 
            // AdminGridViewBtn
            // 
            this.AdminGridViewBtn.Location = new System.Drawing.Point(0, 0);
            this.AdminGridViewBtn.Name = "AdminGridViewBtn";
            this.AdminGridViewBtn.Size = new System.Drawing.Size(75, 23);
            this.AdminGridViewBtn.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 623);
            this.Controls.Add(this.EmployeesPnl);
            this.Controls.Add(this.ShiftPnl);
            this.Controls.Add(this.LeftMenuPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.LeftMenuPnl.ResumeLayout(false);
            this.UserMenuPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            this.ShiftPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        private void InitializeAdminComponent()
        {
            // 
            // NavEmplBtn
            // 
            this.NavEmplBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NavEmplBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavEmplBtn.FlatAppearance.BorderSize = 0;
            this.NavEmplBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavEmplBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NavEmplBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(186)))), ((int)(((byte)(224)))));
            this.NavEmplBtn.Image = global::HospitalGUI.Properties.Resources.EmployeeIcon;
            this.NavEmplBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NavEmplBtn.Location = new System.Drawing.Point(0, 233);
            this.NavEmplBtn.Name = "NavEmplBtn";
            this.NavEmplBtn.Size = new System.Drawing.Size(200, 50);
            this.NavEmplBtn.TabIndex = 5;
            this.NavEmplBtn.Text = "Pracownicy";
            this.NavEmplBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NavEmplBtn.UseVisualStyleBackColor = true;
            this.NavEmplBtn.Click += new System.EventHandler(this.NavEmplBtn_Click);
        }

        private void InitializeShiftsGrid()
        {
            // 
            // ShiftsGrid
            // 
            this.ShiftsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ShiftsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //this.ShiftsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            //this.Data,
            //this.Time,
            //this.EmployeeId,
            //this.Employee,
            //this.EmployeeType,
            //this.EmployeeSpec});
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

        private void InitializeEmployeeGrid()
        {
            // 
            // EmployeesPnl
            // 
            this.EmployeesPnl.Controls.Add(this.NurseGridViewBtn);
            this.EmployeesPnl.Controls.Add(this.PhysGridViewBtn);
            this.EmployeesPnl.Controls.Add(this.AdminGridViewBtn);
            this.EmployeesPnl.Controls.Add(this.EmployeeGrid);
            this.EmployeesPnl.Location = new System.Drawing.Point(215, 12);
            this.EmployeesPnl.Name = "EmployeesPnl";
            this.EmployeesPnl.Size = new System.Drawing.Size(770, 770);
            this.EmployeesPnl.TabIndex = 2;
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
        #endregion

        private System.Windows.Forms.Panel LeftMenuPnl;
        private System.Windows.Forms.Panel UserMenuPnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NavLogoutBtn;
        private System.Windows.Forms.Label PositionLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button NavShiftsBtn;
        private System.Windows.Forms.Button NavEmplBtn;
        private System.Windows.Forms.Panel NavMarkPnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSpec;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.Panel ShiftPnl;
        private System.Windows.Forms.DataGridView ShiftsGrid;
        private System.Windows.Forms.Panel EmployeesPnl;
        private System.Windows.Forms.Button NurseGridViewBtn;
        private System.Windows.Forms.Button PhysGridViewBtn;
        private System.Windows.Forms.Button AdminGridViewBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}