
namespace HospitalGUI.UserControls
{
    partial class ShiftsPnlView
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
            this.ShiftPnl = new System.Windows.Forms.Panel();
            //this.employeesPnlView1 = new HospitalGUI.UserControls.EmployeesPnlView();
            this.ShiftsGrid = new System.Windows.Forms.DataGridView();
            this.ShiftPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ShiftPnl
            // 
            this.ShiftPnl.Controls.Add(this.ShiftsGrid);
            this.ShiftPnl.Location = new System.Drawing.Point(20, 15);
            this.ShiftPnl.Name = "ShiftPnl";
            this.ShiftPnl.Size = new System.Drawing.Size(642, 534);
            this.ShiftPnl.TabIndex = 2;
            // ShiftsGrid
            // 
            this.ShiftsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShiftsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ShiftsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShiftsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShiftsGrid.Location = new System.Drawing.Point(0, 0);
            this.ShiftsGrid.Name = "ShiftsGrid";
            this.ShiftsGrid.Size = new System.Drawing.Size(642, 534);
            this.ShiftsGrid.TabIndex = 0;
            this.ShiftsGrid.DataSource = GetAllShifts();
            // 
            // ShiftsPnlView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShiftPnl);
            this.Name = "ShiftsPnlView";
            this.Size = new System.Drawing.Size(678, 567);
            this.ShiftPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ShiftPnl;
        private System.Windows.Forms.DataGridView ShiftsGrid;
    }
}
