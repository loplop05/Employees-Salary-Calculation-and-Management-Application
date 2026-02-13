using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employees_Salary_Calculation_and_Management_Application
{
    public partial class frmEmployeeManagement : Form
    {
        public frmEmployeeManagement()
        {
            InitializeComponent();
           
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {

        }
        private void FillListView()
        {
            for (int i = 0; i < lvEmployees.Items.Count; i++)
            {
                if (i % 2 == 0)
                    lvEmployees.Items[i].BackColor = Color.White;
                else
                    lvEmployees.Items[i].BackColor = Color.LightGray;
            }










        }
    }
}
