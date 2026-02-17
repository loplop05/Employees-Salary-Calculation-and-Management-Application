namespace Employees_Salary_Calculation_and_Management_Application
{
    partial class frmAnalytics
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lvDeptStats = new ListView();
            Department = new ColumnHeader();
            Employees = new ColumnHeader();
            colTotalSalary = new ColumnHeader();
            lvPositionStats = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnRefresh = new Button();
            btnClose = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 71);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Total Employees";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 71);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Total Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 71);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Average Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 71);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "Highest Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(674, 71);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 4;
            label5.Text = "Lowest Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(812, 71);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 5;
            label6.Text = "Total Employees";
            // 
            // lvDeptStats
            // 
            lvDeptStats.Columns.AddRange(new ColumnHeader[] { Department, Employees, colTotalSalary });
            lvDeptStats.FullRowSelect = true;
            lvDeptStats.GridLines = true;
            lvDeptStats.Location = new Point(63, 155);
            lvDeptStats.Name = "lvDeptStats";
            lvDeptStats.Size = new Size(425, 316);
            lvDeptStats.TabIndex = 6;
            lvDeptStats.UseCompatibleStateImageBehavior = false;
            lvDeptStats.View = View.Details;
            // 
            // Department
            // 
            Department.Text = "Department";
            Department.Width = 140;
            // 
            // Employees
            // 
            Employees.Text = "Employees ";
            Employees.Width = 140;
            // 
            // colTotalSalary
            // 
            colTotalSalary.Text = " Total Salary";
            colTotalSalary.Width = 140;
            // 
            // lvPositionStats
            // 
            lvPositionStats.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvPositionStats.FullRowSelect = true;
            lvPositionStats.GridLines = true;
            lvPositionStats.Location = new Point(712, 155);
            lvPositionStats.Name = "lvPositionStats";
            lvPositionStats.Size = new Size(349, 316);
            lvPositionStats.TabIndex = 7;
            lvPositionStats.UseCompatibleStateImageBehavior = false;
            lvPositionStats.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Position ";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Employees ";
            columnHeader2.Width = 160;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(439, 528);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 60);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(608, 528);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(129, 60);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 41);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 10;
            label7.Text = "Total Employees";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 41);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 11;
            label8.Text = "Total Salary";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(342, 41);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 12;
            label9.Text = "Average Salary";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(512, 41);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 13;
            label10.Text = "Highest Salary";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(674, 41);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 14;
            label11.Text = "Lowest Salary";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(812, 41);
            label12.Name = "label12";
            label12.Size = new Size(118, 20);
            label12.TabIndex = 15;
            label12.Text = "Total Employees";
            // 
            // frmAnalytics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 719);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(lvPositionStats);
            Controls.Add(lvDeptStats);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAnalytics";
            Text = "frmAnalytics";
            Load += frmAnalytics_Load;
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
        private ListView lvDeptStats;
        private ColumnHeader Department;
        private ColumnHeader Employees;
        private ColumnHeader colTotalSalary;
        private ListView lvPositionStats;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnRefresh;
        private Button btnClose;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}