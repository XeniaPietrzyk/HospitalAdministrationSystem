using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalGUI.UserControls
{
    public partial class AddAdminPanel : UserControl
    {
        private TextBox PermissionTbx;
        private TextBox PasswordTbx;
        private TextBox UserNameTbx;
        private TextBox SexTxb;
        private TextBox PeselTxb;
        private TextBox NameTbx;
        private Button AddAdminBtn;

        public AddAdminPanel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.PermissionTbx = new System.Windows.Forms.TextBox();
            this.PasswordTbx = new System.Windows.Forms.TextBox();
            this.UserNameTbx = new System.Windows.Forms.TextBox();
            this.SexTxb = new System.Windows.Forms.TextBox();
            this.PeselTxb = new System.Windows.Forms.TextBox();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.AddAdminBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PermissionTbx
            // 
            this.PermissionTbx.Location = new System.Drawing.Point(29, 66);
            this.PermissionTbx.Name = "PermissionTbx";
            this.PermissionTbx.PlaceholderText = "Uprawnienia";
            this.PermissionTbx.Size = new System.Drawing.Size(100, 23);
            this.PermissionTbx.TabIndex = 15;
            // 
            // PasswordTbx
            // 
            this.PasswordTbx.Location = new System.Drawing.Point(272, 112);
            this.PasswordTbx.Name = "PasswordTbx";
            this.PasswordTbx.PlaceholderText = "Hasło";
            this.PasswordTbx.Size = new System.Drawing.Size(120, 23);
            this.PasswordTbx.TabIndex = 14;
            // 
            // UserNameTbx
            // 
            this.UserNameTbx.Location = new System.Drawing.Point(29, 112);
            this.UserNameTbx.Name = "UserNameTbx";
            this.UserNameTbx.PlaceholderText = "Nazwa użytkownika";
            this.UserNameTbx.Size = new System.Drawing.Size(180, 23);
            this.UserNameTbx.TabIndex = 13;
            // 
            // SexTxb
            // 
            this.SexTxb.Location = new System.Drawing.Point(459, 20);
            this.SexTxb.Name = "SexTxb";
            this.SexTxb.PlaceholderText = "Płeć";
            this.SexTxb.Size = new System.Drawing.Size(120, 23);
            this.SexTxb.TabIndex = 12;
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
            this.AddAdminBtn.Location = new System.Drawing.Point(475, 112);
            this.AddAdminBtn.Name = "AddAdminBtn";
            this.AddAdminBtn.Size = new System.Drawing.Size(90, 30);
            this.AddAdminBtn.TabIndex = 9;
            this.AddAdminBtn.Text = "Dodaj ";
            this.AddAdminBtn.UseVisualStyleBackColor = false;
            // 
            // AddAdminPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.PermissionTbx);
            this.Controls.Add(this.PasswordTbx);
            this.Controls.Add(this.UserNameTbx);
            this.Controls.Add(this.SexTxb);
            this.Controls.Add(this.PeselTxb);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.AddAdminBtn);
            this.Name = "AddAdminPanel";
            this.Size = new System.Drawing.Size(610, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
