namespace Employees_Salary_Calculation_and_Management_Application
{
    partial class frmAddEmployee
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            txtBoxBaseSalary = new TextBox();
            cbPosition = new ComboBox();
            label6 = new Label();
            textBoxDepartment = new TextBox();
            btnSaveEmployeeInfo = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 27);
            label1.Name = "label1";
            label1.Size = new Size(229, 41);
            label1.TabIndex = 0;
            label1.Text = "Employee Info ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 1;
            label2.Text = "ID ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(12, 219);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 3;
            label4.Text = "Position ";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(12, 309);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 4;
            label5.Text = "Base Salary";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(70, 124);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(190, 27);
            textBoxID.TabIndex = 5;
            textBoxID.KeyDown += textBoxID_KeyDown;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(80, 172);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(190, 27);
            textBoxName.TabIndex = 6;
            textBoxName.KeyDown += textBoxName_KeyDown;
            // 
            // txtBoxBaseSalary
            // 
            txtBoxBaseSalary.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxBaseSalary.Location = new Point(128, 309);
            txtBoxBaseSalary.Name = "txtBoxBaseSalary";
            txtBoxBaseSalary.ReadOnly = true;
            txtBoxBaseSalary.Size = new Size(163, 31);
            txtBoxBaseSalary.TabIndex = 7;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "Sales ", "Customer Service", "Call Center", "Cashier", "Accountant", "Junior Sales Supervisor", "Senior Sales Supervisor", "ShowRoom Manager" });
            cbPosition.Location = new Point(103, 219);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(199, 28);
            cbPosition.TabIndex = 8;
            cbPosition.SelectedIndexChanged += cbPosition_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(12, 267);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 9;
            label6.Text = "Department";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxDepartment.Location = new Point(128, 263);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.ReadOnly = true;
            textBoxDepartment.Size = new Size(163, 31);
            textBoxDepartment.TabIndex = 10;
            // 
            // btnSaveEmployeeInfo
            // 
            btnSaveEmployeeInfo.Location = new Point(39, 379);
            btnSaveEmployeeInfo.Name = "btnSaveEmployeeInfo";
            btnSaveEmployeeInfo.Size = new Size(105, 45);
            btnSaveEmployeeInfo.TabIndex = 11;
            btnSaveEmployeeInfo.Text = "Save";
            btnSaveEmployeeInfo.UseVisualStyleBackColor = true;
            btnSaveEmployeeInfo.Click += btnSaveEmployeeInfo_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(197, 379);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 45);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(395, 485);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveEmployeeInfo);
            Controls.Add(textBoxDepartment);
            Controls.Add(label6);
            Controls.Add(cbPosition);
            Controls.Add(txtBoxBaseSalary);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddEmployee";
            Text = "frmAddEmployee";
            Load += frmAddEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        public TextBox textBoxID;
        public TextBox textBoxName;
        public ComboBox cbPosition;
        public TextBox textBoxDepartment;
        private Button btnSaveEmployeeInfo;
        private Button btnCancel;
        public TextBox txtBoxBaseSalary;
        private ErrorProvider errorProvider1;
    }
}