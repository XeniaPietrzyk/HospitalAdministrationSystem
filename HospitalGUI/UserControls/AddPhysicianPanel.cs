using Model;
using Model.Controller;
using Model.Helpers;
using Model.Model;
using Model.Service;
using Model.Services;
using System;
using System.Windows.Forms;

namespace HospitalGUI.UserControls
{
    public partial class AddPhysicianPanel : UserControl
    {
        private IEmployeeConfiguration<Physician> _physicianConfiguration;

        private Validate validator;

        private TextBox PWZNumbTbx;
        private TextBox PasswordTbx;
        private TextBox UserNameTbx;
        private TextBox PeselTxb;
        private TextBox NameTbx;
        private Button AddPhysBtn;
        private ComboBox SexCbox;
        private ComboBox SpecCbox;
        private ComboBox PermissionCbox;
        private Context _context;
        public AddPhysicianPanel()
        {
            InitializeComponent();
        }

        public AddPhysicianPanel(Context context)
        {
            _context = context;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.PWZNumbTbx = new System.Windows.Forms.TextBox();
            this.PasswordTbx = new System.Windows.Forms.TextBox();
            this.UserNameTbx = new System.Windows.Forms.TextBox();
            this.PeselTxb = new System.Windows.Forms.TextBox();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.AddPhysBtn = new System.Windows.Forms.Button();
            this.SexCbox = new System.Windows.Forms.ComboBox();
            this.SpecCbox = new System.Windows.Forms.ComboBox();
            this.PermissionCbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PWZNumbTbx
            // 
            this.PWZNumbTbx.Location = new System.Drawing.Point(272, 66);
            this.PWZNumbTbx.Name = "PWZNumbTbx";
            this.PWZNumbTbx.PlaceholderText = "Numer PWZ";
            this.PWZNumbTbx.Size = new System.Drawing.Size(120, 23);
            this.PWZNumbTbx.TabIndex = 17;
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
            // AddPhysBtn
            // 
            this.AddPhysBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.AddPhysBtn.FlatAppearance.BorderSize = 0;
            this.AddPhysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPhysBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddPhysBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.AddPhysBtn.Location = new System.Drawing.Point(475, 112);
            this.AddPhysBtn.Name = "AddPhysBtn";
            this.AddPhysBtn.Size = new System.Drawing.Size(90, 30);
            this.AddPhysBtn.TabIndex = 9;
            this.AddPhysBtn.Text = "Dodaj ";
            this.AddPhysBtn.UseVisualStyleBackColor = false;
            this.AddPhysBtn.Click += new System.EventHandler(this.AddAdminBtn_Click);
            // 
            // SexCbox
            // 
            this.SexCbox.FormattingEnabled = true;
            this.SexCbox.Location = new System.Drawing.Point(459, 20);
            this.SexCbox.Name = "SexCbox";
            this.SexCbox.Size = new System.Drawing.Size(121, 23);
            this.SexCbox.TabIndex = 18;
            this.SexCbox.DataSource = Sex.GetValues(typeof(Sex));
            // 
            // SpecCbox
            // 
            this.SpecCbox.FormattingEnabled = true;
            this.SpecCbox.Location = new System.Drawing.Point(29, 66);
            this.SpecCbox.Name = "SpecCbox";
            this.SpecCbox.Size = new System.Drawing.Size(180, 23);
            this.SpecCbox.TabIndex = 19;
            this.SpecCbox.DataSource = Specialization.GetValues(typeof(Specialization));
            // 
            // PermissionCbox
            // 
            this.PermissionCbox.FormattingEnabled = true;
            this.PermissionCbox.Location = new System.Drawing.Point(459, 66);
            this.PermissionCbox.Name = "PermissionCbox";
            this.PermissionCbox.Size = new System.Drawing.Size(121, 23);
            this.PermissionCbox.TabIndex = 20;
            this.PermissionCbox.DataSource = Permission.GetValues(typeof(Permission));
            // 
            // AddPhysicianPanel
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.PermissionCbox);
            this.Controls.Add(this.SpecCbox);
            this.Controls.Add(this.SexCbox);
            this.Controls.Add(this.PWZNumbTbx);
            this.Controls.Add(this.PasswordTbx);
            this.Controls.Add(this.UserNameTbx);
            this.Controls.Add(this.PeselTxb);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.AddPhysBtn);
            this.Name = "AddPhysicianPanel";
            this.Size = new System.Drawing.Size(610, 155);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddAdminBtn_Click(object sender, EventArgs e)
        {          
            if (IsNull())
            {
                Physician newPhysician = new Physician();
                newPhysician.Name = NameTbx.Text;
                var peselValidate = true;
                try
                {
                    var pesel = long.Parse(PeselTxb.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("PESEL powinien składać się z cyfr");
                    PeselTxb.Focus();
                    peselValidate = false;
                }
                if (peselValidate)
                {
                    if (PeselTxb.Text.Length < 11 || PeselTxb.Text.Length > 11)
                    {
                        MessageBox.Show("PESEL powinien mieć długość 11 cyfr");
                        PeselTxb.Focus();
                    }
                    newPhysician.Pesel = long.Parse(PeselTxb.Text);
                    newPhysician.Password = PasswordTbx.Text;
                    newPhysician.UserName = UserNameTbx.Text;
                    newPhysician.Sex = (Sex)SexCbox.SelectedItem;
                    newPhysician.Specialization = (Specialization)SpecCbox.SelectedItem;
                    newPhysician.PWZNumber = Convert.ToInt32(PWZNumbTbx.Text);
                    newPhysician.Permission = (Permission)PermissionCbox.SelectedItem;
                    newPhysician.EmployeeType = EmployeeType.physician;
                    validator = new Validate();
                    if (validator.UserNameKeyValidate(newPhysician.UserName, newPhysician.Password, _context))
                    {
                        _physicianConfiguration = new PhysicianService();
                        _physicianConfiguration.Add(newPhysician, _context);
                    }
                    else
                    {
                        string message = "Nazwa użytkownika jest zajęta. Wybierz inną.";
                        string caption = "Error Detected in Input";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        UserNameTbx.Focus();
                        result = MessageBox.Show(message, caption, buttons);
                    }
                }
            }
        }

        private bool IsNull()
        {
            if (NameTbx.Text == "" || PeselTxb.Text == "" || PasswordTbx.Text == "" || UserNameTbx.Text == "")
            {
                string message = "Żadne pole nie może być puste!";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                return false;
            }
            return true;
        }
    }
}
