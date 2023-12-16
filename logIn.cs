using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Films
{
    public partial class logIn : Form
    {
        Database database = new Database();
        private string nameProgram;
        public logIn(string name)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = name;
            nameProgram = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string emailUser = textBox3.Text;
            string password = textBox4.Text;

            string query = $"SELECT id, email, password FROM test_db WHERE email='{emailUser}' and password='{password}'";

            SqlCommand sqlCommand = new SqlCommand(query, database.GetConnection());
            database.openConnection();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();
                int id = (int)sqlDataReader.GetValue(0);
                OrdinaryUser ordinaryUser = new OrdinaryUser(id);
                Films films = new Films(ordinaryUser);
                films.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email или пароль не совпадает!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlDataReader.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign signUp = new sign(nameProgram);
            this.Hide();
            signUp.ShowDialog();
        }

        private void logIn_Load_1(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
        }
    }
}
