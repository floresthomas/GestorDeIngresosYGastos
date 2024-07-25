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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace ExpenseSystem
{
    public partial class ExpenseForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bboyt\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public ExpenseForm()
        {
            InitializeComponent();
            displayExpenseData();
            displayCategyList();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayExpenseData();
            displayCategyList();
        }

        public void displayExpenseData()
        {
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.expensesListData();

            dataGridView1.DataSource = listData;
        }

        public void displayCategyList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Gastos");
                    cmd.Parameters.AddWithValue("@status", "Activo");

                    expense_category.Items.Clear();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        expense_category.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
            }
        }

        private void expense_addBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" || expense_cost.Text == ""
                || expense_description.Text == "")
            {
                MessageBox.Show("Por favor rellena los campos en blanco", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    string insertData = "INSERT INTO expenses (category, item, cost, description, date_expense, date_insert) " +
                                           "VALUES (@cat, @item, @cost, @desc, @date_ex, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connection))
                    {
                        cmd.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", expense_item.Text);
                        cmd.Parameters.AddWithValue("@cost", expense_cost.Text);
                        cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                        cmd.Parameters.AddWithValue("@date_ex", dateTimePicker1.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Agregado correctamente", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                }
            }
            displayExpenseData();
        }

        public void clearFields()
        {
            expense_item.Text = "";
            expense_category.SelectedIndex = -1;
            expense_cost.Text = "";
            expense_description.Text = "";
        }

        private void expense_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void expense_updateBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" || expense_cost.Text == ""
                || expense_description.Text == "")
            {
                MessageBox.Show("Por favor rellena los campos en blanco", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Estás seguro/a de querer editar el ID: " + getID + "?", "Mensaje de confirmación", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string updateData = "UPDATE expenses SET category = @cat, item = @item, cost = @cost, description = @desc," +
                                            "date_expense = @date_ex WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            cmd.Parameters.AddWithValue("@cat", expense_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", expense_item.Text);
                            cmd.Parameters.AddWithValue("@cost", expense_cost.Text);
                            cmd.Parameters.AddWithValue("@desc", expense_description.Text);
                            cmd.Parameters.AddWithValue("@date_ex", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@id", getID);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Editado correctamente", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        connection.Close();
                    }
                }
            }
            displayExpenseData();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                expense_category.SelectedItem = row.Cells[1].Value.ToString();
                expense_item.Text = row.Cells[2].Value.ToString();
                expense_cost.Text = row.Cells[3].Value.ToString();
                expense_description.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Value = DateTime.ParseExact(row.Cells[5].Value.ToString(), "MM-dd-yyyy", CultureInfo.InvariantCulture);
            }
        }

        private void expense_deleteBtn_Click(object sender, EventArgs e)
        {
            if (expense_category.SelectedIndex == -1 || expense_item.Text == "" || expense_cost.Text == ""
                || expense_description.Text == "")
            {
                MessageBox.Show("Selecciona un item primero", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Estás seguro/a de querer eliminar el ID: " + getID + "?", "Mensaje de confirmación", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string deleteData = "DELETE FROM expenses WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Eliminado correctamente", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        connection.Close();
                    }
                }
            }
            displayExpenseData();
        }
    }
}
