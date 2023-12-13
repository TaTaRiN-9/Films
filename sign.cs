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
    public partial class sign : Form
    {
        private string nameProgram;
        public sign(string name)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = name;
            nameProgram = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            //Считываем данные от пользователя
            string emailUser = emailUserAcc.Text;
            string passwordUser = pass.Text;
            string confirmPassword = confirmPass.Text;
            if (emailUser == "" || passwordUser == "" || confirmPassword == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (passwordUser == confirmPassword)
                {
                    //Пишем запрос
                    string queryCheckEmail = $"SELECT email FROM test_db WHERE email = '{emailUser}'";

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();

                    SqlCommand sqlCommand = new SqlCommand(queryCheckEmail, database.GetConnection());

                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        // регистрируем пользователя в базе данных
                        string querySignUp = $"insert into test_db(email, password) values ('{emailUser}', '{passwordUser}')";
                        SqlCommand command = new SqlCommand(querySignUp, database.GetConnection());

                        database.openConnection();
                        // Если тронута одна строка, значит все успешно.
                        if (command.ExecuteNonQuery() == 1)
                        {
                            Films films = new Films(5);
                            this.Hide();
                            films.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Аккаунт не был зарегистрирован!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        emailUserAcc.Clear();
                        pass.Clear();
                        confirmPass.Clear();
                        MessageBox.Show("Такой email уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    pass.Clear();
                    confirmPass.Clear();
                    MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            database.closeConnection();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logIn log_in = new logIn(nameProgram);
            this.Close();
            log_in.Show();
        }

        private void sign_Load(object sender, EventArgs e)
        {
            pass.PasswordChar = '*';
            confirmPass.PasswordChar = '*';
        }
    }
}
