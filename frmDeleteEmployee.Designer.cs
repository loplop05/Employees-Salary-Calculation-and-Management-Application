namespace Employees_Salary_Calculation_and_Management_Application
{
    partial class frmDeleteEmployee
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
            txtBoxDelete = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 42);
            label1.Name = "label1";
            label1.Size = new Size(371, 54);
            label1.TabIndex = 0;
            label1.Text = "Enter Employee ID";
            // 
            // txtBoxDelete
            // 
            txtBoxDelete.Location = new Point(261, 137);
            txtBoxDelete.Name = "txtBoxDelete";
            txtBoxDelete.Size = new Size(223, 27);
            txtBoxDelete.TabIndex = 1;
            // 
            // frmDeleteEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxDelete);
            Controls.Add(label1);
            Name = "frmDeleteEmployee";
            Text = "frmDeleteEmployee";
            Load += frmDeleteEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxDelete;
    }
}