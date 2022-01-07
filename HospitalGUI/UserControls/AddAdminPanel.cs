﻿using Model;
using Model.Controller;
using Model.Helpers;
using Model.Model;
using Model.Service;
using System;
using System.Windows.Forms;

namespace HospitalGUI.UserControls
{
    public partial class AddAdminPanel : UserControl
    {
        private IEmployeeConfiguration<Admin> _adminConfiguration;

        private TextBox PasswordTbx;
        private TextBox UserNameTbx;
        private TextBox PeselTxb;
        private TextBox NameTbx;
        private ComboBox SexCbox;
        private ComboBox PermissionCbox;
        private Button AddAdminBtn;
        private Context _context;

        public AddAdminPanel()
        {
            InitializeComponent();
        }

        public AddAdminPanel(Context context)
        {
            _context = context;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.PasswordTbx = new TextBox();
            this.UserNameTbx = new TextBox();
            this.PeselTxb = new TextBox();
            this.NameTbx = new TextBox();
            this.AddAdminBtn = new Button();
            this.SexCbox = new ComboBox();
            this.PermissionCbox = new ComboBox();
            this.SuspendLayout();
            // 
            // PasswordTbx
            // 
            this.PasswordTbx.Location = new System.Drawing.Point(272, 65);
            this.PasswordTbx.Name = "PasswordTbx";
            this.PasswordTbx.PlaceholderText = "Hasło";
            this.PasswordTbx.Size = new System.Drawing.Size(120, 23);
            this.PasswordTbx.TabIndex = 14;
            // 
            // UserNameTbx
            // 
            this.UserNameTbx.Location = new System.Drawing.Point(29, 65);
            this.UserNameTbx.Name = "UserNameTbx";
            this.UserNameTbx.PlaceholderText = "Nazwa użytkownika";
            this.UserNameTbx.Size = new System.Drawing.Size(180, 23);
            this.UserNameTbx.TabIndex = 13;
            // 
            // PeselTxb
            // 
            this.PeselTxb.Location = new System.Drawing.Point(272, 20);
            this.PeselTxb.Name = "PeselTxb";
            this.PeselTxb.PlaceholderText = "PESEL";
            this.PeselTxb.Size = new System.Drawing.Size(120, 23);
            this.PeselTxb.TabIndex = 11;
            // 
            // NameTbx
            // 
            this.NameTbx.Location = new System.Drawing.Point(29, 20);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.PlaceholderText = "Imię i nazwisko";
            this.NameTbx.Size = new System.Drawing.Size(180, 23);
            this.NameTbx.TabIndex = 10;
            // 
            // AddAdminBtn
            // 
            this.AddAdminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.AddAdminBtn.FlatAppearance.BorderSize = 0;
            this.AddAdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAdminBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddAdminBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.AddAdminBtn.Location = new System.Drawing.Point(479, 112);
            this.AddAdminBtn.Name = "AddAdminBtn";
            this.AddAdminBtn.Size = new System.Drawing.Size(90, 30);
            this.AddAdminBtn.TabIndex = 9;
            this.AddAdminBtn.Text = "Dodaj ";
            this.AddAdminBtn.UseVisualStyleBackColor = false;
            this.AddAdminBtn.Click += new System.EventHandler(this.AddAdminBtn_Click);
            // 
            // SexCbox
            // 
            this.SexCbox.FormattingEnabled = true;
            this.SexCbox.Location = new System.Drawing.Point(460, 20);
            this.SexCbox.Name = "SexCbox";
            this.SexCbox.Size = new System.Drawing.Size(121, 23);
            this.SexCbox.TabIndex = 19;
            this.SexCbox.DataSource = Sex.GetValues(typeof(Sex));
            // 
            // PermissionCbox
            // 
            this.PermissionCbox.FormattingEnabled = true;
            this.PermissionCbox.Location = new System.Drawing.Point(460, 65);
            this.PermissionCbox.Name = "PermissionCbox";
            this.PermissionCbox.Size = new System.Drawing.Size(121, 23);
            this.PermissionCbox.TabIndex = 21;
            this.PermissionCbox.DataSource = Permission.GetValues(typeof(Permission));
            // 
            // AddAdminPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.PermissionCbox);
            this.Controls.Add(this.SexCbox);
            this.Controls.Add(this.PasswordTbx);
            this.Controls.Add(this.UserNameTbx);
            this.Controls.Add(this.PeselTxb);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.AddAdminBtn);
            this.Name = "AddAdminPanel";
            this.Size = new System.Drawing.Size(610, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddAdminBtn_Click(object sender, EventArgs e)
        {
            Admin newAdmin = new Admin();
            newAdmin.Name = NameTbx.Text;
            newAdmin.Pesel = long.Parse(PeselTxb.Text);
            newAdmin.Password = PasswordTbx.Text;
            newAdmin.UserName = UserNameTbx.Text;
            newAdmin.Sex = (Sex)SexCbox.SelectedItem;
            newAdmin.Permission = (Permission)PermissionCbox.SelectedItem;
            _adminConfiguration = new AdminService();
            _adminConfiguration.Add(newAdmin, _context);
        }
    }
}