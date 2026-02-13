namespace Employees_Salary_Calculation_and_Management_Application
{
    partial class frmOperations
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
            lblWelcomeMessage = new Label();
            lblChoose = new Label();
            btnEmployeeManagement = new Button();
            btnSalaryCalculation = new Button();
            btnShowEmployees = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Urdu Typesetting", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeMessage.Location = new Point(29, 22);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(112, 81);
            lblWelcomeMessage.TabIndex = 0;
            lblWelcomeMessage.Text = ".......";
            lblWelcomeMessage.Click += lblWelcomeMessage_Click;
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Font = new Font("Simplified Arabic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChoose.Location = new Point(198, 117);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(757, 66);
            lblChoose.TabIndex = 1;
            lblChoose.Text = "Choose One Of The Following Operations";
            // 
            // btnEmployeeManagement
            // 
            btnEmployeeManagement.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployeeManagement.Location = new Point(157, 303);
            btnEmployeeManagement.Name = "btnEmployeeManagement";
            btnEmployeeManagement.Size = new Size(239, 109);
            btnEmployeeManagement.TabIndex = 0;
            btnEmployeeManagement.Text = "Employee Management";
            btnEmployeeManagement.UseVisualStyleBackColor = true;
            // 
            // btnSalaryCalculation
            // 
            btnSalaryCalculation.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalaryCalculation.Location = new Point(464, 303);
            btnSalaryCalculation.Name = "btnSalaryCalculation";
            btnSalaryCalculation.Size = new Size(239, 109);
            btnSalaryCalculation.TabIndex = 1;
            btnSalaryCalculation.Text = "Salary Calculation";
            btnSalaryCalculation.UseVisualStyleBackColor = true;
            // 
            // btnShowEmployees
            // 
            btnShowEmployees.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowEmployees.Location = new Point(758, 303);
            btnShowEmployees.Name = "btnShowEmployees";
            btnShowEmployees.Size = new Size(239, 109);
            btnShowEmployees.TabIndex = 2;
            btnShowEmployees.Text = "Show Employees";
            btnShowEmployees.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(192, 64, 0);
            btnLogOut.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(1015, 22);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(143, 50);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Logout";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // frmOperations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 672);
            Controls.Add(btnLogOut);
            Controls.Add(btnShowEmployees);
            Controls.Add(btnSalaryCalculation);
            Controls.Add(btnEmployeeManagement);
            Controls.Add(lblChoose);
            Controls.Add(lblWelcomeMessage);
            Name = "frmOperations";
            Text = "frmOperations";
            Load += frmOperations_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeMessage;
        private Label lblChoose;
        private Button btnEmployeeManagement;
        private Button btnSalaryCalculation;
        private Button btnShowEmployees;
        private Button btnLogOut;
    }
}