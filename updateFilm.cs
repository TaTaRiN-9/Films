using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Films
{
    public partial class updateFilm : Form
    {
        private Database database = new Database();
        private string[] genres = new string[7] { "Фантастика",
            "Фэнтези", "Драма", "Комедия", "Детектив", "Приключения",
            "Мелодрама"};
        private Film film;
        private int adminId = 0;
        public updateFilm(Film film)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Изменение фильма";
            this.film = film;
        }

        public updateFilm(Film film, int id) : this(film)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Изменение фильма";
            this.adminId = id;
        }

        private void buttonUpdateFilm_Click(object sender, EventArgs e)
        {
            if (textNameFilm.Text != "" && textCreationYear.Text != "" &&
                choiceDirectors.SelectedIndex > -1 && choiceStyle.SelectedIndex > -1)
            {
                string nameFilm = textNameFilm.Text;
                int creationYear = Convert.ToInt32(textCreationYear.Text);
                string filmDirector = (String)choiceDirectors.SelectedItem;
                string styleFilm = (String)choiceStyle.SelectedItem;
                string queryUpdateFilm = $"UPDATE f SET f.director_id = (SELECT id FROM Directors " +
                    $"WHERE name = '{filmDirector}'), f.name = '{nameFilm}', " +
                    $"f.creationYear = {creationYear}, f.style = '{styleFilm}' From Films f " +
                    $"JOIN Directors d ON d.id = f.director_id WHERE f.id = {film.Id}";

                SqlCommand sqlCommand = new SqlCommand(queryUpdateFilm, database.GetConnection());
                database.openConnection();
                sqlCommand.ExecuteNonQuery();
                database.closeConnection();
                this.Close();
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDeleteFilm_Click(object sender, EventArgs e)
        {
            if (textNameFilm.Text != "" && textCreationYear.Text != "" && 
                choiceDirectors.SelectedIndex > -1 && choiceStyle.SelectedIndex > -1)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот фильм?",
                    "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    string queryDeleteFilm = $"DELETE Films WHERE id = {film.Id}";
                    SqlCommand sqlCommand = new SqlCommand(queryDeleteFilm, database.GetConnection());
                    database.openConnection();
                    sqlCommand.ExecuteNonQuery();
                    database.closeConnection();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updateFilm_Load(object sender, EventArgs e)
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

            string queryName = $"SELECT name FROM Directors WHERE id = {film.DirectorId}";

            sqlCommand = new SqlCommand(queryName, database.GetConnection());

            database.openConnection();
            sqlDataReader = sqlCommand.ExecuteReader();

            sqlDataReader.Read();
            sqlDataReader.GetValue(0);

            textNameFilm.Text = film.Name;
            textCreationYear.Text = film.CreationYear.ToString();
            choiceStyle.Text = film.Style;

            choiceDirectors.Text = sqlDataReader.GetValue(0).ToString();
            sqlDataReader.Close();
        }
    }
}
