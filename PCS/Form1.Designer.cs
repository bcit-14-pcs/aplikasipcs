namespace PCS
{
    partial class Employee
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
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.tbxPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbxBasicsalary = new System.Windows.Forms.TextBox();
            this.tbxEmployeename = new System.Windows.Forms.TextBox();
            this.lblEmployeename = new System.Windows.Forms.Label();
            this.lblBasicsalary = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFreerole = new System.Windows.Forms.TextBox();
            this.tbxTotalsalary = new System.Windows.Forms.TextBox();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.lblFreerole = new System.Windows.Forms.Label();
            this.tbxAttendance = new System.Windows.Forms.TextBox();
            this.lblIdemployee = new System.Windows.Forms.Label();
            this.tbxIdemployee = new System.Windows.Forms.TextBox();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.pnlEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.btnDatabase);
            this.pnlEmployee.Controls.Add(this.tbxPosition);
            this.pnlEmployee.Controls.Add(this.lblPosition);
            this.pnlEmployee.Controls.Add(this.tbxBasicsalary);
            this.pnlEmployee.Controls.Add(this.tbxEmployeename);
            this.pnlEmployee.Controls.Add(this.lblEmployeename);
            this.pnlEmployee.Controls.Add(this.lblBasicsalary);
            this.pnlEmployee.Controls.Add(this.btnEnter);
            this.pnlEmployee.Controls.Add(this.label4);
            this.pnlEmployee.Controls.Add(this.tbxIdemployee);
            this.pnlEmployee.Controls.Add(this.tbxFreerole);
            this.pnlEmployee.Controls.Add(this.tbxTotalsalary);
            this.pnlEmployee.Controls.Add(this.lblAttendance);
            this.pnlEmployee.Controls.Add(this.lblFreerole);
            this.pnlEmployee.Controls.Add(this.tbxAttendance);
            this.pnlEmployee.Controls.Add(this.lblIdemployee);
            this.pnlEmployee.Location = new System.Drawing.Point(12, 12);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(517, 275);
            this.pnlEmployee.TabIndex = 0;
            this.pnlEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbxPosition
            // 
            this.tbxPosition.Location = new System.Drawing.Point(140, 82);
            this.tbxPosition.Name = "tbxPosition";
            this.tbxPosition.Size = new System.Drawing.Size(318, 20);
            this.tbxPosition.TabIndex = 14;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(50, 85);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 13;
            this.lblPosition.Text = "Position";
            // 
            // tbxBasicsalary
            // 
            this.tbxBasicsalary.Location = new System.Drawing.Point(140, 108);
            this.tbxBasicsalary.Name = "tbxBasicsalary";
            this.tbxBasicsalary.Size = new System.Drawing.Size(318, 20);
            this.tbxBasicsalary.TabIndex = 12;
            // 
            // tbxEmployeename
            // 
            this.tbxEmployeename.Location = new System.Drawing.Point(140, 56);
            this.tbxEmployeename.Name = "tbxEmployeename";
            this.tbxEmployeename.Size = new System.Drawing.Size(318, 20);
            this.tbxEmployeename.TabIndex = 11;
            // 
            // lblEmployeename
            // 
            this.lblEmployeename.AutoSize = true;
            this.lblEmployeename.Location = new System.Drawing.Point(50, 59);
            this.lblEmployeename.Name = "lblEmployeename";
            this.lblEmployeename.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeename.TabIndex = 10;
            this.lblEmployeename.Text = "Employee Name";
            // 
            // lblBasicsalary
            // 
            this.lblBasicsalary.AutoSize = true;
            this.lblBasicsalary.Location = new System.Drawing.Point(50, 111);
            this.lblBasicsalary.Name = "lblBasicsalary";
            this.lblBasicsalary.Size = new System.Drawing.Size(65, 13);
            this.lblBasicsalary.TabIndex = 9;
            this.lblBasicsalary.Text = "Basic Salary";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(383, 186);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your Total Salary";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbxFreerole
            // 
            this.tbxFreerole.Location = new System.Drawing.Point(140, 160);
            this.tbxFreerole.Name = "tbxFreerole";
            this.tbxFreerole.Size = new System.Drawing.Size(318, 20);
            this.tbxFreerole.TabIndex = 5;
            // 
            // tbxTotalsalary
            // 
            this.tbxTotalsalary.Location = new System.Drawing.Point(231, 215);
            this.tbxTotalsalary.Name = "tbxTotalsalary";
            this.tbxTotalsalary.Size = new System.Drawing.Size(227, 20);
            this.tbxTotalsalary.TabIndex = 4;
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Location = new System.Drawing.Point(50, 137);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(62, 13);
            this.lblAttendance.TabIndex = 3;
            this.lblAttendance.Text = "Attendance";
            // 
            // lblFreerole
            // 
            this.lblFreerole.AutoSize = true;
            this.lblFreerole.Location = new System.Drawing.Point(50, 163);
            this.lblFreerole.Name = "lblFreerole";
            this.lblFreerole.Size = new System.Drawing.Size(47, 13);
            this.lblFreerole.TabIndex = 2;
            this.lblFreerole.Text = "FeeRole";
            // 
            // tbxAttendance
            // 
            this.tbxAttendance.Location = new System.Drawing.Point(140, 134);
            this.tbxAttendance.Name = "tbxAttendance";
            this.tbxAttendance.Size = new System.Drawing.Size(318, 20);
            this.tbxAttendance.TabIndex = 1;
            // 
            // lblIdemployee
            // 
            this.lblIdemployee.AutoSize = true;
            this.lblIdemployee.Location = new System.Drawing.Point(50, 33);
            this.lblIdemployee.Name = "lblIdemployee";
            this.lblIdemployee.Size = new System.Drawing.Size(67, 13);
            this.lblIdemployee.TabIndex = 0;
            this.lblIdemployee.Text = "ID Employee";
            // 
            // tbxIdemployee
            // 
            this.tbxIdemployee.Location = new System.Drawing.Point(140, 30);
            this.tbxIdemployee.Name = "tbxIdemployee";
            this.tbxIdemployee.Size = new System.Drawing.Size(318, 20);
            this.tbxIdemployee.TabIndex = 6;
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(302, 186);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(75, 23);
            this.btnDatabase.TabIndex = 15;
            this.btnDatabase.Text = "Database";
            this.btnDatabase.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 303);
            this.Controls.Add(this.pnlEmployee);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFreerole;
        private System.Windows.Forms.TextBox tbxTotalsalary;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label lblFreerole;
        private System.Windows.Forms.TextBox tbxAttendance;
        private System.Windows.Forms.Label lblIdemployee;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblBasicsalary;
        private System.Windows.Forms.Label lblEmployeename;
        private System.Windows.Forms.TextBox tbxBasicsalary;
        private System.Windows.Forms.TextBox tbxEmployeename;
        private System.Windows.Forms.TextBox tbxPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox tbxIdemployee;
        private System.Windows.Forms.Button btnDatabase;
    }
}

