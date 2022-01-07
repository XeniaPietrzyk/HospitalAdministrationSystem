
namespace HospitalGUI
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.LogoPctrBox = new System.Windows.Forms.PictureBox();
            this.LoginTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPctrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPctrBox
            // 
            this.LogoPctrBox.Image = global::HospitalGUI.Properties.Resources.hospital;
            this.LogoPctrBox.InitialImage = global::HospitalGUI.Properties.Resources.hospital;
            this.LogoPctrBox.Location = new System.Drawing.Point(180, 12);
            this.LogoPctrBox.Name = "LogoPctrBox";
            this.LogoPctrBox.Size = new System.Drawing.Size(533, 362);
            this.LogoPctrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPctrBox.TabIndex = 0;
            this.LogoPctrBox.TabStop = false;
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.Location = new System.Drawing.Point(363, 380);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.PlaceholderText = "Login";
            this.LoginTxtBox.Size = new System.Drawing.Size(166, 23);
            this.LoginTxtBox.TabIndex = 3;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(363, 432);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PlaceholderText = "Password";
            this.PasswordTxtBox.Size = new System.Drawing.Size(166, 23);
            this.PasswordTxtBox.TabIndex = 4;
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.LogInBtn.FlatAppearance.BorderSize = 0;
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogInBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.LogInBtn.Location = new System.Drawing.Point(400, 485);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(92, 45);
            this.LogInBtn.TabIndex = 5;
            this.LogInBtn.Text = "Sign in";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(841, 13);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(40, 40);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 623);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.LoginTxtBox);
            this.Controls.Add(this.LogoPctrBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Administration System";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPctrBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPctrBox;
        private System.Windows.Forms.TextBox LoginTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

