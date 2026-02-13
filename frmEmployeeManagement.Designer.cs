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
            lvEmployees = new ListView();
            colID = new ColumnHeader();
            colName = new ColumnHeader();
            colPosition = new ColumnHeader();
            colBaseSalary = new ColumnHeader();
            colDateAdded = new ColumnHeader();
            colDepartment = new ColumnHeader();
            btnAddEmployee = new Button();
            btnRemoveEmployee = new Button();
            btnSearchEmployee = new Button();
            SuspendLayout();
            // 
            // lvEmployees
            // 
            lvEmployees.Columns.AddRange(new ColumnHeader[] { colID, colName, colPosition, colBaseSalary, colDateAdded, colDepartment });
            lvEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvEmployees.FullRowSelect = true;
            lvEmployees.GridLines = true;
            lvEmployees.Location = new Point(12, 105);
            lvEmployees.Name = "lvEmployees";
            lvEmployees.Size = new Size(846, 452);
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
            colPosition.Width = 120;
            // 
            // colBaseSalary
            // 
            colBaseSalary.Text = "BaseSalary";
            colBaseSalary.TextAlign = HorizontalAlignment.Center;
            colBaseSalary.Width = 120;
            // 
            // colDateAdded
            // 
            colDateAdded.DisplayIndex = 5;
            colDateAdded.Text = "Hiring Date";
            colDateAdded.TextAlign = HorizontalAlignment.Center;
            colDateAdded.Width = 200;
            // 
            // colDepartment
            // 
            colDepartment.DisplayIndex = 4;
            colDepartment.Text = "Department";
            colDepartment.TextAlign = HorizontalAlignment.Center;
            colDepartment.Width = 160;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(885, 105);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(232, 92);
            btnAddEmployee.TabIndex = 1;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmployee
            // 
            btnRemoveEmployee.Location = new Point(885, 275);
            btnRemoveEmployee.Name = "btnRemoveEmployee";
            btnRemoveEmployee.Size = new Size(233, 98);
            btnRemoveEmployee.TabIndex = 2;
            btnRemoveEmployee.Text = "Remove Employee";
            btnRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // btnSearchEmployee
            // 
            btnSearchEmployee.Location = new Point(885, 450);
            btnSearchEmployee.Name = "btnSearchEmployee";
            btnSearchEmployee.Size = new Size(233, 98);
            btnSearchEmployee.TabIndex = 3;
            btnSearchEmployee.Text = "Search Employee";
            btnSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 676);
            Controls.Add(btnSearchEmployee);
            Controls.Add(btnRemoveEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(lvEmployees);
            Name = "frmEmployeeManagement";
            Text = "frmEmployeeManagement";
            Load += frmEmployeeManagement_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvEmployees;
        private ColumnHeader colID;
        private ColumnHeader colName;
        private ColumnHeader colPosition;
        private ColumnHeader colBaseSalary;
        private ColumnHeader colDateAdded;
        private ColumnHeader colDepartment;
        private Button btnAddEmployee;
        private Button btnRemoveEmployee;
        private Button btnSearchEmployee;
    }
}