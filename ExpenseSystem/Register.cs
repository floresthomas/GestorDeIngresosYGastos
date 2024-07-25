using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpenseSystem
{
    public partial class Register : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bboyt\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30");
        public Register()
        {
            InitializeComponent();
        }

        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_username_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (username_password.Text == "" || register_password.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Por favor rellena los campos en blanco", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT * FROM users WHERE username = @usern";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", username_password.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                string tempUsern = username_password.Text.Substring(0, 1).ToUpper() + username_password.Text.Substring(1);
                                MessageBox.Show(tempUsern + " ya existe", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Contraseña inválida, se necesitan al menos 8 caracteres", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text != textBox1.Text)
                            {
                                MessageBox.Show("Las contraseñas no coinciden", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username, password, date_create) VALUES (@usern, @pass, @date_create)";
                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", username_password.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertUser.Parameters.AddWithValue("@date_create", today);

                                    insertUser.ExecuteNonQuery();
                                    MessageBox.Show("Registrado correctamente!", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        MessageBox.Show("Conexión fallida: " + ex, "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = checkBox1.Checked ? '\0' : '*';
            textBox1.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}