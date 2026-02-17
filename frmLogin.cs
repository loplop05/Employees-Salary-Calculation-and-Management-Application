using System;
using System.Windows.Forms;

namespace Employees_Salary_Calculation_and_Management_Application
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtbxUserName.Focus();
            txtbxPassWord.UseSystemPasswordChar = true; // Hide password
        }

        // Move to password when Enter pressed
        private void txtbxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtbxPassWord.Focus();
                e.SuppressKeyPress = true;
            }
        }

        // Click login when Enter pressed in password
        private void txtbxPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!ValidateInputs())
                return;

            if (IsLoginValid())
            {
                OpenMainForm();
            }
            else
            {
                ShowLoginError();
            }
        }

        // =============================
        // Validation Methods
        // =============================

        private bool ValidateInputs()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtbxUserName.Text))
            {
                errorProvider1.SetError(txtbxUserName, "User Name is required");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtbxPassWord.Text))
            {
                errorProvider1.SetError(txtbxPassWord, "Password is required");
                isValid = false;
            }

            return isValid;
        }

        private bool IsLoginValid()
        {
            return txtbxUserName.Text == txtbxUserName.Tag?.ToString()
                && txtbxPassWord.Text == txtbxPassWord.Tag?.ToString();
        }

        private void OpenMainForm()
        {
            using (frmOperations frm = new frmOperations(txtbxUserName.Text))
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }

            txtbxUserName.Clear();
            txtbxPassWord.Clear();
            txtbxUserName.Focus();
        }

        private void ShowLoginError()
        {
            errorProvider1.SetError(txtbxUserName, "Invalid User Name or Password");
            errorProvider1.SetError(txtbxPassWord, "Invalid User Name or Password");

            txtbxPassWord.Clear();
            txtbxPassWord.Focus();
        }
    }
}
