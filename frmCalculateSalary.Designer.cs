namespace Employees_Salary_Calculation_and_Management_Application
{
    partial class frmCalculateSalary
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
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            BoxEmployeeInfoBox = new GroupBox();
            txtBoxDepartment = new TextBox();
            label8 = new Label();
            textBoxBaseSalary = new TextBox();
            textBoxPosition = new TextBox();
            textBoxFullName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblID = new Label();
            gbCalculationProccess = new GroupBox();
            txtOvertime = new TextBox();
            txtDeduction = new TextBox();
            txtBonus = new TextBox();
            txtAbsence = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEmpID = new TextBox();
            btnSearch = new Button();
            BoxEmployeeInfoBox.SuspendLayout();
            gbCalculationProccess.SuspendLayout();
            SuspendLayout();
            // 
            // BoxEmployeeInfoBox
            // 
            BoxEmployeeInfoBox.Controls.Add(txtBoxDepartment);
            BoxEmployeeInfoBox.Controls.Add(label8);
            BoxEmployeeInfoBox.Controls.Add(textBoxBaseSalary);
            BoxEmployeeInfoBox.Controls.Add(textBoxPosition);
            BoxEmployeeInfoBox.Controls.Add(textBoxFullName);
            BoxEmployeeInfoBox.Controls.Add(label3);
            BoxEmployeeInfoBox.Controls.Add(label2);
            BoxEmployeeInfoBox.Controls.Add(label1);
            BoxEmployeeInfoBox.Location = new Point(26, 90);
            BoxEmployeeInfoBox.Name = "BoxEmployeeInfoBox";
            BoxEmployeeInfoBox.Size = new Size(400, 232);
            BoxEmployeeInfoBox.TabIndex = 0;
            BoxEmployeeInfoBox.TabStop = false;
            BoxEmployeeInfoBox.Text = "EmployeeInfoBox";
            // 
            // txtBoxDepartment
            // 
            txtBoxDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtBoxDepartment.Location = new Point(173, 184);
            txtBoxDepartment.Name = "txtBoxDepartment";
            txtBoxDepartment.ReadOnly = true;
            txtBoxDepartment.Size = new Size(221, 34);
            txtBoxDepartment.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 184);
            label8.Name = "label8";
            label8.Size = new Size(144, 31);
            label8.TabIndex = 8;
            label8.Text = "Department";
            // 
            // textBoxBaseSalary
            // 
            textBoxBaseSalary.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxBaseSalary.Location = new Point(173, 133);
            textBoxBaseSalary.Name = "textBoxBaseSalary";
            textBoxBaseSalary.ReadOnly = true;
            textBoxBaseSalary.Size = new Size(221, 34);
            textBoxBaseSalary.TabIndex = 7;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPosition.Location = new Point(173, 81);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.ReadOnly = true;
            textBoxPosition.Size = new Size(221, 34);
            textBoxPosition.TabIndex = 6;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxFullName.Location = new Point(173, 33);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.ReadOnly = true;
            textBoxFullName.Size = new Size(221, 34);
            textBoxFullName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 136);
            label3.Name = "label3";
            label3.Size = new Size(135, 31);
            label3.TabIndex = 4;
            label3.Text = "Base Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 84);
            label2.Name = "label2";
            label2.Size = new Size(102, 31);
            label2.TabIndex = 3;
            label2.Text = "Position";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 2;
            label1.Text = "Full Name";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(26, 28);
            lblID.Name = "lblID";
            lblID.Size = new Size(148, 31);
            lblID.TabIndex = 1;
            lblID.Text = "Employee ID";
            // 
            // gbCalculationProccess
            // 
            gbCalculationProccess.Controls.Add(txtOvertime);
            gbCalculationProccess.Controls.Add(txtDeduction);
            gbCalculationProccess.Controls.Add(txtBonus);
            gbCalculationProccess.Controls.Add(txtAbsence);
            gbCalculationProccess.Controls.Add(label4);
            gbCalculationProccess.Controls.Add(label5);
            gbCalculationProccess.Controls.Add(label6);
            gbCalculationProccess.Controls.Add(label7);
            gbCalculationProccess.Location = new Point(26, 369);
            gbCalculationProccess.Name = "gbCalculationProccess";
            gbCalculationProccess.Size = new Size(400, 291);
            gbCalculationProccess.TabIndex = 1;
            gbCalculationProccess.TabStop = false;
            gbCalculationProccess.Text = "Salary Calculation ";
            // 
            // txtOvertime
            // 
            txtOvertime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOvertime.Location = new Point(173, 41);
            txtOvertime.Name = "txtOvertime";
            txtOvertime.Size = new Size(152, 34);
            txtOvertime.TabIndex = 8;
            txtOvertime.KeyDown += textBox4_KeyDown;
            // 
            // txtDeduction
            // 
            txtDeduction.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtDeduction.Location = new Point(173, 215);
            txtDeduction.Name = "txtDeduction";
            txtDeduction.Size = new Size(152, 34);
            txtDeduction.TabIndex = 7;
            // 
            // txtBonus
            // 
            txtBonus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBonus.Location = new Point(173, 151);
            txtBonus.Name = "txtBonus";
            txtBonus.Size = new Size(152, 34);
            txtBonus.TabIndex = 6;
            txtBonus.KeyDown += txtBonus_KeyDown;
            // 
            // txtAbsence
            // 
            txtAbsence.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAbsence.Location = new Point(173, 103);
            txtAbsence.Name = "txtAbsence";
            txtAbsence.Size = new Size(152, 34);
            txtAbsence.TabIndex = 5;
            txtAbsence.KeyDown += txtAbsence_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 215);
            label4.Name = "label4";
            label4.Size = new Size(126, 31);
            label4.TabIndex = 4;
            label4.Text = "Deduction";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 154);
            label5.Name = "label5";
            label5.Size = new Size(81, 31);
            label5.TabIndex = 3;
            label5.Text = "Bonus";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 103);
            label6.Name = "label6";
            label6.Size = new Size(160, 31);
            label6.TabIndex = 2;
            label6.Text = "Absence Days";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 41);
            label7.Name = "label7";
            label7.Size = new Size(117, 31);
            label7.TabIndex = 1;
            label7.Text = "OverTime";
            // 
            // txtEmpID
            // 
            txtEmpID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmpID.Location = new Point(180, 28);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(188, 34);
            txtEmpID.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(396, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmCalculateSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1185, 680);
            Controls.Add(btnSearch);
            Controls.Add(txtEmpID);
            Controls.Add(gbCalculationProccess);
            Controls.Add(BoxEmployeeInfoBox);
            Controls.Add(lblID);
            Name = "frmCalculateSalary";
            Text = "frmCalculateSalary";
            Load += frmCalculateSalary_Load;
            BoxEmployeeInfoBox.ResumeLayout(false);
            BoxEmployeeInfoBox.PerformLayout();
            gbCalculationProccess.ResumeLayout(false);
            gbCalculationProccess.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private GroupBox BoxEmployeeInfoBox;
        private Label lblID;
        private Label label1;
        public TextBox textBoxBaseSalary;
        public TextBox textBoxPosition;
        public TextBox textBoxFullName;
        private Label label3;
        private Label label2;
        private GroupBox gbCalculationProccess;
        public TextBox txtOvertime;
        public TextBox txtDeduction;
        public TextBox txtBonus;
        public TextBox txtAbsence;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox txtBoxDepartment;
        private Label label8;
        public TextBox txtEmpID;
        private Button btnSearch;
    }
}