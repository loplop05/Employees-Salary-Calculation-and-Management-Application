namespace Employees_Salary_Calculation_and_Management_Application
{
    partial class frmLogin
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
            LoginBtn = new Button();
            txtbxPassWord = new TextBox();
            txtbxUserName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.Font = new Font("Tw Cen MT Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(412, 450);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(259, 87);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // txtbxPassWord
            // 
            txtbxPassWord.BackColor = Color.White;
            txtbxPassWord.Location = new Point(412, 400);
            txtbxPassWord.Name = "txtbxPassWord";
            txtbxPassWord.Size = new Size(259, 27);
            txtbxPassWord.TabIndex = 1;
            txtbxPassWord.Tag = "0000";
            // 
            // txtbxUserName
            // 
            txtbxUserName.BackColor = Color.White;
            txtbxUserName.ForeColor = SystemColors.WindowText;
            txtbxUserName.Location = new Point(412, 261);
            txtbxUserName.Name = "txtbxUserName";
            txtbxUserName.Size = new Size(259, 27);
            txtbxUserName.TabIndex = 0;
            txtbxUserName.Tag = "admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold);
            label3.Location = new Point(412, 316);
            label3.Name = "label3";
            label3.Size = new Size(259, 52);
            label3.TabIndex = 8;
            label3.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold);
            label2.Location = new Point(412, 186);
            label2.Name = "label2";
            label2.Size = new Size(259, 52);
            label2.TabIndex = 7;
            label2.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(346, 22);
            label1.Name = "label1";
            label1.Size = new Size(403, 104);
            label1.TabIndex = 6;
            label1.Text = "SalaryDesk";
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 100;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 640);
            Controls.Add(LoginBtn);
            Controls.Add(txtbxPassWord);
            Controls.Add(txtbxUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            IsMdiContainer = true;
            Name = "frmLogin";
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
        public TextBox txtbxPassWord;
        public TextBox txtbxUserName;
    }
}