﻿using System;
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
using System.Globalization;

namespace ExpenseSystem
{
    public partial class IncomeForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bboyt\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public IncomeForm()
        {
            InitializeComponent();

            displayCategyList();
            displayIncomeData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayIncomeData();
            displayCategyList();
        }

        public void displayIncomeData()
        {
            IncomeData iData = new IncomeData();
            List<IncomeData> listData = iData.incomeListData();

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
                    cmd.Parameters.AddWithValue("@type", "Ingresos");
                    cmd.Parameters.AddWithValue("@status", "Activo");

                    income_category.Items.Clear();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        income_category.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
            }
        }

        public void clearFields()
        {
            income_item.Text = "";
            income_category.SelectedIndex = -1;
            income_cost.Text = "";
            income_description.Text = "";
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {

        }

        private void income_addBtn_Click_1(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_cost.Text == ""
                 || income_description.Text == "")
            {
                MessageBox.Show("Por favor rellena los campos en blanco", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string insertData = "INSERT INTO income (category, item, income, description, date_income, date_insert) " +
                                            "VALUES(@cat, @item, @income, @description, @date_income, @date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connection))
                        {
                            cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", income_item.Text);
                            cmd.Parameters.AddWithValue("@income", decimal.Parse(income_cost.Text)); // Verifica el tipo de dato
                            cmd.Parameters.AddWithValue("@description", income_description.Text);
                            cmd.Parameters.AddWithValue("@date_income", dateTimePicker1.Value);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Agregado correctamente", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Error de SQL: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            displayIncomeData();
        }

        private void income_deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_cost.Text == ""
    || income_description.Text == "")
            {
                MessageBox.Show("Por favor rellena los campos en blanco", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Estás seguro/a de querer eliminar el ID: " + getID + "?", "Mensaje de confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string insertData = "DELETE FROM income WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(insertData, connection))
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
            displayIncomeData();
        }

        private void income_updateBtn_Click_1(object sender, EventArgs e)
        {
            if (income_category.SelectedIndex == -1 || income_item.Text == "" || income_cost.Text == ""
|| income_description.Text == "")
            {
                MessageBox.Show("Selecciona un item primero", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Estás seguro/a de editar el ID: " + getID + "?", "Mensaje de confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        connection.Open();

                        string updateData = "UPDATE income SET category = @cat, item = @item, income = @income, " +
                            "description = @description, date_income = @date_income WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connection))
                        {
                            cmd.Parameters.AddWithValue("@cat", income_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", income_item.Text);
                            cmd.Parameters.AddWithValue("@income", income_cost.Text);
                            cmd.Parameters.AddWithValue("@description", income_description.Text);
                            cmd.Parameters.AddWithValue("@date_income", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Editado correctamente", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        connection.Close();
                    }
                }

            }
            displayIncomeData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int getID = 0;

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                income_category.SelectedItem = row.Cells[1].Value.ToString();
                income_item.Text = row.Cells[2].Value.ToString();
                income_cost.Text = row.Cells[3].Value.ToString();
                income_description.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Value = DateTime.ParseExact(row.Cells[5].Value.ToString(), "MM-dd-yyyy", CultureInfo.InvariantCulture);
            }
        }
    }
}