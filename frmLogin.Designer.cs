namespace Employees_Salary_Calculation_and_Management_Application
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbxUserName = new TextBox();
            txtbxPassWord = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(351, 27);
            label1.Name = "label1";
            label1.Size = new Size(403, 104);
            label1.TabIndex = 0;
            label1.Text = "SalaryDesk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold);
            label2.Location = new Point(440, 190);
            label2.Name = "label2";
            label2.Size = new Size(259, 52);
            label2.TabIndex = 1;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold);
            label3.Location = new Point(440, 320);
            label3.Name = "label3";
            label3.Size = new Size(259, 52);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD";
            label3.Click += this.label3_Click;
            // 
            // txtbxUserName
            // 
            txtbxUserName.Location = new Point(440, 265);
            txtbxUserName.Name = "txtbxUserName";
            txtbxUserName.Size = new Size(259, 27);
            txtbxUserName.TabIndex = 3;
            // 
            // txtbxPassWord
            // 
            txtbxPassWord.Location = new Point(440, 404);
            txtbxPassWord.Name = "txtbxPassWord";
            txtbxPassWord.Size = new Size(259, 27);
            txtbxPassWord.TabIndex = 4;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 642);
            Controls.Add(txtbxPassWord);
            Controls.Add(txtbxUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbxUserName;
        private TextBox txtbxPassWord;
    }
}
