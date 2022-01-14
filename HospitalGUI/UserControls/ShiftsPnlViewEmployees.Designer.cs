
using Model.Helpers;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalGUI.UserControls
{
    partial class ShiftsPnlViewEmployees
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
            this.Dutylbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShiftPnl = new System.Windows.Forms.Panel();
            this.ShiftsDataGrid = new System.Windows.Forms.DataGridView();
            this.DutyDataGrid = new System.Windows.Forms.DataGridView();
            this.AddShiftBtn = new System.Windows.Forms.Button();
            this.DeleteShiftBtn = new System.Windows.Forms.Button();
            this.ShiftPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DutyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Dutylbl
            // 
            this.Dutylbl.AutoSize = true;
            this.Dutylbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dutylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.Dutylbl.Location = new System.Drawing.Point(17, 5);
            this.Dutylbl.Name = "Dutylbl";
            this.Dutylbl.Size = new System.Drawing.Size(72, 18);
            this.Dutylbl.TabIndex = 3;
            this.Dutylbl.Text = "DYŻURY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(17, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ZMIANY";
            // 
            // ShiftPnl
            // 
            this.ShiftPnl.Controls.Add(this.ShiftsDataGrid);
            this.ShiftPnl.Controls.Add(this.DutyDataGrid);
            this.ShiftPnl.Controls.Add(this.AddShiftBtn);
            this.ShiftPnl.Controls.Add(this.DeleteShiftBtn);
            this.ShiftPnl.Controls.Add(this.label1);
            this.ShiftPnl.Controls.Add(this.Dutylbl);
            this.ShiftPnl.Location = new System.Drawing.Point(20, 15);
            this.ShiftPnl.Name = "ShiftPnl";
            this.ShiftPnl.Size = new System.Drawing.Size(556, 583);
            this.ShiftPnl.TabIndex = 2;
            // 
            // ShiftsDataGrid
            // 
            this.ShiftsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShiftsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ShiftsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShiftsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ShiftsDataGrid.Location = new System.Drawing.Point(0, 329);
            this.ShiftsDataGrid.Name = "ShiftsDataGrid";
            this.ShiftsDataGrid.RowTemplate.Height = 25;
            this.ShiftsDataGrid.Size = new System.Drawing.Size(556, 214);
            this.ShiftsDataGrid.TabIndex = 20;
            this.ShiftsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShiftsDataGrid_CellClick);
            // 
            // DutyDataGrid
            // 
            this.DutyDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DutyDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.DutyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DutyDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.DutyDataGrid.Location = new System.Drawing.Point(0, 35);
            this.DutyDataGrid.Name = "DutyDataGrid";
            this.DutyDataGrid.RowTemplate.Height = 25;
            this.DutyDataGrid.Size = new System.Drawing.Size(556, 188);
            this.DutyDataGrid.TabIndex = 19;
            this.DutyDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DutyDataGrid_CellClick);
            // 
            // AddShiftBtn
            // 
            this.AddShiftBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.AddShiftBtn.FlatAppearance.BorderSize = 0;
            this.AddShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddShiftBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddShiftBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.AddShiftBtn.Location = new System.Drawing.Point(470, 293);
            this.AddShiftBtn.Name = "AddShiftBtn";
            this.AddShiftBtn.Size = new System.Drawing.Size(80, 30);
            this.AddShiftBtn.TabIndex = 10;
            this.AddShiftBtn.Text = "Dodaj";
            this.AddShiftBtn.UseVisualStyleBackColor = false;
            this.AddShiftBtn.Click += new System.EventHandler(this.AddShiftBtn_Click);
            // 
            // DeleteShiftBtn
            // 
            this.DeleteShiftBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.DeleteShiftBtn.FlatAppearance.BorderSize = 0;
            this.DeleteShiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteShiftBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteShiftBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(71)))), ((int)(((byte)(139)))));
            this.DeleteShiftBtn.Location = new System.Drawing.Point(470, 550);
            this.DeleteShiftBtn.Name = "DeleteShiftBtn";
            this.DeleteShiftBtn.Size = new System.Drawing.Size(80, 30);
            this.DeleteShiftBtn.TabIndex = 8;
            this.DeleteShiftBtn.Text = "Usuń";
            this.DeleteShiftBtn.UseVisualStyleBackColor = false;
            this.DeleteShiftBtn.Click += new System.EventHandler(this.DeleteShiftBtn_Click);
            // 
            // ShiftsPnlViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ShiftPnl);
            this.Name = "ShiftsPnlViewEmployees";
            this.Size = new System.Drawing.Size(600, 621);
            this.ShiftPnl.ResumeLayout(false);
            this.ShiftPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DutyDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Dutylbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ShiftPnl;
        private System.Windows.Forms.Button DeleteShiftBtn;
        private System.Windows.Forms.Button AddShiftBtn;
        private System.Windows.Forms.DataGridView DutyDataGrid;
        private System.Windows.Forms.DataGridView ShiftsDataGrid;
    }
}
