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
    public partial class addNewFilm : Form
    {
        private Database database = new Database();
        private string[] genres = new string[7] { "Фантастика", 
            "Фэнтези", "Драма", "Комедия", "Детектив", "Приключения", 
            "Мелодрама"};
        private int user_id;

        public addNewFilm(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Добавление фильма";
            user_id = id;
        }

        private void addNewFilm_Load(object sender, EventArgs e)
        {
            choiceStyle.Items.AddRange(genres);

            string query = "SELECT name FROM Directors";

            SqlCommand sqlCommand = new SqlCommand(query, database.GetConnection());

            database.openConnection();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    choiceDirectors.Items.Add(sqlDataReader.GetValue(0));
                }
            }

            sqlDataReader.Close();
        }

        private void addFilm_Click(object sender, EventArgs e)
        {
            if (textNameFilm.Text != "" && textCreationYear.Text != "" 
                && choiceDirectors.SelectedIndex > -1 && choiceStyle.SelectedIndex > -1)
            {
                string nameFilm = textNameFilm.Text;
                int creationYear = Convert.ToInt32(textCreationYear.Text);
                string filmDirector = (String)choiceDirectors.SelectedItem;
                string styleFilm = (String)choiceStyle.SelectedItem;

                string query = $"INSERT INTO Films(name, creationYear, style, director_id, author)" +
                    $" VALUES ('{nameFilm}', {creationYear}, '{styleFilm}', " +
                    $"(SELECT id FROM Directors WHERE name = '{filmDirector}'), {user_id})";
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, database.GetConnection());
                    database.openConnection();

                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не получилось добавить фильм!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Такой фильм уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены и выбраны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textCreationYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
