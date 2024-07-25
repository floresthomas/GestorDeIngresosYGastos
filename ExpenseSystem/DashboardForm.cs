using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace ExpenseSystem
{
    public partial class DashboardForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bboyt\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public DashboardForm()
        {
            InitializeComponent();
            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();

            expensesTodayIncome();
            expenseYesterdayIncome();
            expensesThisMonth();
            expenseThisYear();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            incometotalIncome();

            expensesTodayIncome();
            expenseYesterdayIncome();
            expensesThisMonth();
            expenseThisYear();
            expenseTotalCost();
        }

        public void incomeTodayIncome()
        {
            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE date_income = @date_in";

                using(SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);

                    object result = cmd.ExecuteScalar();

                    if(result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        income_totalincome.Text = todayCost.ToString("C");
                    } else
                    {
                        income_totalincome.Text = "$0.00";
                    }
                }
            }
        }

        public void incomeYesterdayIncome()
        {
            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";

                using(SqlCommand command = new SqlCommand(query, connect))
                {
                    object result = command.ExecuteScalar();

                    if(result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        income_yesterdayincome.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        income_yesterdayincome.Text = "$0.00";
                    }
                }
            }
        }

        public void incomeThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <= @endMonth";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@startMonth", startMonth);
                    command.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);

                        income_thisMonthIncome.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        income_thisMonthIncome.Text = "$0.00";
                    }
                }
            }
        }

        public void incomeThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@startYear", startYear);
                    command.Parameters.AddWithValue("@endYear", endYear);

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);

                        income_thisYearIncome.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        income_thisYearIncome.Text = "$0.00";
                    }
                }
            }
        }

        public void incometotalIncome()
        {
            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(income) FROM income";
                using(SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if(result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);
                        totalIncome.Text = totalCost.ToString("C");
                    }
                    else
                    {
                        totalIncome.Text = "$0.00";
                    }
                }
            }
        }

        public void expensesTodayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense = @date_ex";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_ex", today);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        expense_todayExpense.Text = todayCost.ToString("C");
                    }
                    else
                    {
                        expense_todayExpense.Text = "$0.00";
                    }
                }
            }
        }

        public void expenseYesterdayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE CONVERT(DATE, date_expense) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        expense_yesterdayExpense.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        expense_yesterdayExpense.Text = "$0.00";
                    }
                }
            }
        }

        public void expensesThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startMonth AND date_expense <= @endMonth";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@startMonth", startMonth);
                    command.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);

                        expense_thisMonthExpense.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        expense_thisMonthExpense.Text = "$0.00";
                    }
                }
            }
        }

        public void expenseThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startYear AND date_expense <= @endYear";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@startYear", startYear);
                    command.Parameters.AddWithValue("@endYear", endYear);

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);

                        expense_thisYearExpense.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        expense_thisYearExpense.Text = "$0.00";
                    }
                }
            }
        }

        public void expenseTotalCost()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(cost) FROM expenses";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);
                        totalExpenses.Text = totalCost.ToString("C");
                    }
                    else
                    {
                        totalExpenses.Text = "$0.00";
                    }
                }
            }
        }
    }
}
