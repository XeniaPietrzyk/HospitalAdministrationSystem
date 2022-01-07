using Model;
using Model.Controller;
using Model.Helpers;
using Model.Model;
using Model.Service;
using System;
using System.Windows.Forms;

namespace HospitalGUI.UserControls
{
    public partial class AddNursePanel : UserControl
    {
        private IEmployeeConfiguration<Nurse> _nurseConfiguration;

        private TextBox PasswordTbx;
        private TextBox UserNameTbx;
        private TextBox PeselTxb;
        private TextBox NameTbx;
        private ComboBox SexCbox;
        private ComboBox PermissionCbox;
        private Button AddNurseBtn;
        private Context _context;

        public AddNursePanel()
        {
            InitializeComponent();
        }

        public AddNursePanel(Context context)
        {
            _context = context;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.PasswordTbx = new System.Windows.Forms.TextBox();
            this.UserNameTbx = new System.Windows.Forms.TextBox();
            this.PeselTxb = new System.Windows.Forms.TextBox();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.AddNurseBtn = new System.Windows.Forms.Button();
            this.SexCbox = new System.Windows.Forms.ComboBox();
            this.PermissionCbox = new System.Windows.Forms.ComboBox();
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
            // AddNurseBtn
            // 
            this.AddNurseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.AddNurseBtn.FlatAppearance.BorderSize = 0;
            this.AddNurseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNurseBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNurseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.AddNurseBtn.Location = new System.Drawing.Point(475, 112);
            this.AddNurseBtn.Name = "AddNurseBtn";
            this.AddNurseBtn.Size = new System.Drawing.Size(90, 30);
            this.AddNurseBtn.TabIndex = 9;
            this.AddNurseBtn.Text = "Dodaj ";
            this.AddNurseBtn.UseVisualStyleBackColor = false;
            // 
            // SexCbox
            // 
            this.SexCbox.FormattingEnabled = true;
            this.SexCbox.Location = new System.Drawing.Point(460, 20);
            this.SexCbox.Name = "SexCbox";
            this.SexCbox.Size = new System.Drawing.Size(121, 23);
            this.SexCbox.TabIndex = 19;
            this.SexCbox.DataSource = Sex.GetValues(typeof(Sex));
            //this.SexCbox.DataSource = Sex.GetValues(typeof(Sex));
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
            // AddNursePanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.PermissionCbox);
            this.Controls.Add(this.SexCbox);
            this.Controls.Add(this.PasswordTbx);
            this.Controls.Add(this.UserNameTbx);
            this.Controls.Add(this.PeselTxb);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.AddNurseBtn);
            this.Name = "AddNursePanel";
            this.Size = new System.Drawing.Size(610, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddNurseBtn_Click(object sender, EventArgs e)
        {
            Nurse newNurse = new Nurse();
            newNurse.Name = NameTbx.Text;
            newNurse.Pesel = long.Parse(PeselTxb.Text);
            newNurse.Password = PasswordTbx.Text;
            newNurse.UserName = UserNameTbx.Text;
            newNurse.Sex = (Sex)SexCbox.SelectedItem;
            newNurse.Permission = (Permission)PermissionCbox.SelectedItem;
            _nurseConfiguration = new NurseService();
            _nurseConfiguration.Add(newNurse, _context);
        }
    }
}
