namespace Employees_Salary_Calculation_and_Management_Application
{
    partial class frmSearchEmployee
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
            btnSearch = new Button();
            textBoxIDforSearch = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 63);
            label1.Name = "label1";
            label1.Size = new Size(371, 54);
            label1.TabIndex = 0;
            label1.Text = "Enter Employee ID";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(327, 207);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxIDforSearch
            // 
            textBoxIDforSearch.Location = new Point(265, 140);
            textBoxIDforSearch.Name = "textBoxIDforSearch";
            textBoxIDforSearch.Size = new Size(225, 27);
            textBoxIDforSearch.TabIndex = 2;
            textBoxIDforSearch.KeyDown += textBoxIDforSearch_KeyDown_1;
            textBoxIDforSearch.KeyPress += textBoxIDforSearch_KeyPress;
            // 
            // frmSearchEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxIDforSearch);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Name = "frmSearchEmployee";
            Text = "frmSearchEmployee";
            Load += frmSearchEmployee_Load;
            Shown += frmSearchEmployee_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearch;
        private TextBox textBoxIDforSearch;
    }
}