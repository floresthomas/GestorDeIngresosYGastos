using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            displayUsername();
        }

        public void displayUsername()
        {
            string getUsername = Form1.username;

            label2.Text = "Bienvenido, " + getUsername.Substring(0, 1).ToUpper() + getUsername.Substring(1);
        }

        private void X_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro de que quieres cerrar?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = true;
            incomeForm1.Visible = false;
            expenseForm1.Visible = false;

            CategoryForm cForm = categoryForm1 as CategoryForm;

            if (cForm != null)
            {
                cForm.refreshData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expenseForm1.Visible = false;

            DashboardForm dForm = dashboardForm1 as DashboardForm;

            if(dForm != null)
            {
                dForm.refreshData();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro de que quieres cerrar sesión?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = true;
            expenseForm1.Visible = false;

            IncomeForm iForm = incomeForm1 as IncomeForm;
            if(iForm != null)
            {
                iForm.refreshData();
            }
        }

        private void expensesBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm1.Visible = false;
            expenseForm1.Visible = true;

            ExpenseForm eForm = expenseForm1 as ExpenseForm;
            if(eForm != null)
            {
                eForm.refreshData();
            }
        }
    }
}
