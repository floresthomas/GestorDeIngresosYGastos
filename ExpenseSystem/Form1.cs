using System.Data;
using System.Data.SqlClient;
namespace ExpenseSystem
{
    public partial class Form1 : Form
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bboyt\Documents\expense.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            regForm.Show();

            this.Hide();
        }

        public static string username;
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", textBox2.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if(table.Rows.Count > 0)
                    {
                        username = textBox1.Text;

                        MessageBox.Show("Iniciaste sesión correctamente!", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainForm mForm = new MainForm();

                        mForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario/contraseña incorrectos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = (checkBox1.Checked) ? '\0' : '*';
        }
    }
}
