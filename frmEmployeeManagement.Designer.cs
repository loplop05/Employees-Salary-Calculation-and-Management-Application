namespace Employees_Salary_Calculation_and_Management_Application
{
    partial class frmEmployeeManagement
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
            lvEmployees = new ListView();
            colID = new ColumnHeader();
            colName = new ColumnHeader();
            colPosition = new ColumnHeader();
            colBaseSalary = new ColumnHeader();
            colDepartment = new ColumnHeader();
            colDateHiring = new ColumnHeader();
            btnAddEmployee = new Button();
            btnRemoveEmployee = new Button();
            btnSearchEmployee = new Button();
            fillEmps = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnBackToMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lvEmployees
            // 
            lvEmployees.Columns.AddRange(new ColumnHeader[] { colID, colName, colPosition, colBaseSalary, colDepartment, colDateHiring });
            lvEmployees.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvEmployees.FullRowSelect = true;
            lvEmployees.GridLines = true;
            lvEmployees.Location = new Point(12, 105);
            lvEmployees.Name = "lvEmployees";
            lvEmployees.Size = new Size(877, 452);
            lvEmployees.TabIndex = 0;
            lvEmployees.UseCompatibleStateImageBehavior = false;
            lvEmployees.View = View.Details;
            // 
            // colID
            // 
            colID.Text = "ID";
            colID.Width = 100;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.TextAlign = HorizontalAlignment.Center;
            colName.Width = 140;
            // 
            // colPosition
            // 
            colPosition.Text = "Position";
            colPosition.TextAlign = HorizontalAlignment.Center;
            colPosition.Width = 150;
            // 
            // colBaseSalary
            // 
            colBaseSalary.Text = "BaseSalary";
            colBaseSalary.TextAlign = HorizontalAlignment.Center;
            colBaseSalary.Width = 120;
            // 
            // colDepartment
            // 
            colDepartment.Text = "Department";
            colDepartment.TextAlign = HorizontalAlignment.Center;
            colDepartment.Width = 160;
            // 
            // colDateHiring
            // 
            colDateHiring.Text = "Date Hired";
            colDateHiring.Width = 140;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(913, 105);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(232, 92);
            btnAddEmployee.TabIndex = 1;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnRemoveEmployee
            // 
            btnRemoveEmployee.Location = new Point(913, 273);
            btnRemoveEmployee.Name = "btnRemoveEmployee";
            btnRemoveEmployee.Size = new Size(233, 98);
            btnRemoveEmployee.TabIndex = 2;
            btnRemoveEmployee.Text = "Remove Employee";
            btnRemoveEmployee.UseVisualStyleBackColor = true;
            btnRemoveEmployee.Click += btnRemoveEmployee_Click;
            // 
            // btnSearchEmployee
            // 
            btnSearchEmployee.Location = new Point(913, 447);
            btnSearchEmployee.Name = "btnSearchEmployee";
            btnSearchEmployee.Size = new Size(233, 98);
            btnSearchEmployee.TabIndex = 3;
            btnSearchEmployee.Text = "Search Employee";
            btnSearchEmployee.UseVisualStyleBackColor = true;
            btnSearchEmployee.Click += btnSearchEmployee_Click;
            // 
            // fillEmps
            // 
            fillEmps.Location = new Point(913, 583);
            fillEmps.Name = "fillEmps";
            fillEmps.Size = new Size(233, 50);
            fillEmps.TabIndex = 4;
            fillEmps.Text = "Fill Employee";
            fillEmps.UseVisualStyleBackColor = true;
            fillEmps.Click += fillEmps_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Location = new Point(12, 33);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(233, 50);
            btnBackToMenu.TabIndex = 5;
            btnBackToMenu.Text = "Back To Menu";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // frmEmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1189, 676);
            Controls.Add(btnBackToMenu);
            Controls.Add(fillEmps);
            Controls.Add(btnSearchEmployee);
            Controls.Add(btnRemoveEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(lvEmployees);
            Name = "frmEmployeeManagement";
            Text = "frmEmployeeManagement";
            Load += frmEmployeeManagement_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader colID;
        private ColumnHeader colName;
        private ColumnHeader colPosition;
        private ColumnHeader colBaseSalary;
        private ColumnHeader colDepartment;
        private Button btnAddEmployee;
        private Button btnRemoveEmployee;
        private Button btnSearchEmployee;
        private Button fillEmps;
        private ColumnHeader colDateHiring;
        private ErrorProvider errorProvider1;
        public ListView lvEmployees;
        private Button btnBackToMenu;
    }
}