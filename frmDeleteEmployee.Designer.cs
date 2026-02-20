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
            textBoxIDforDelete = new TextBox();
            btnSearchForDelete = new Button();
            button1 = new Button();
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
            // textBoxIDforDelete
            // 
            textBoxIDforDelete.Location = new Point(261, 137);
            textBoxIDforDelete.Name = "textBoxIDforDelete";
            textBoxIDforDelete.Size = new Size(223, 27);
            textBoxIDforDelete.TabIndex = 1;
            textBoxIDforDelete.TextChanged += textBoxIDforDelete_TextChanged;
            textBoxIDforDelete.KeyDown += textBoxIDforDelete_KeyDown;
            // 
            // btnSearchForDelete
            // 
            btnSearchForDelete.Location = new Point(323, 197);
            btnSearchForDelete.Name = "btnSearchForDelete";
            btnSearchForDelete.Size = new Size(94, 29);
            btnSearchForDelete.TabIndex = 2;
            btnSearchForDelete.Text = "Search";
            btnSearchForDelete.UseVisualStyleBackColor = true;
            btnSearchForDelete.Click += btnSearchForDelete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(694, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmDeleteEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnSearchForDelete);
            Controls.Add(textBoxIDforDelete);
            Controls.Add(label1);
            Name = "frmDeleteEmployee";
            Text = "frmDeleteEmployee";
            Load += frmDeleteEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxIDforDelete;
        private Button btnSearchForDelete;
        private Button button1;
    }
}