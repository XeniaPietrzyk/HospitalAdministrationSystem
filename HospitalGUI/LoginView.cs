using Model;
using Model.Login;
using System;
using System.Windows.Forms;

namespace HospitalGUI
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            _start = new Context();
            _start.Configure();
        }
        Context _start { get; set; }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            var login = LoginTxtBox.Text;
            var password = PasswordTxtBox.Text;
            LoginValidation loginValidator = new LoginValidation();
            var employee = loginValidator.ValidateUser(_start, login, password);
            if (employee != null)
            {
                var correctPassword = loginValidator.ValidatePassword(employee, password);
                if (correctPassword)
                {
                    //var permission = employee.Permission;
                    MainView mainView = new MainView(_start, employee);
                    mainView.Show();
                    this.Hide();
                }
                else
                {
                    string message = "Podano niepoprawne dane logowania.";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, caption, buttons);

                }
            }
            else
            {
                string message = "Podano niepoprawne dane logowania.";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
