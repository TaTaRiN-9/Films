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
    public partial class Films : Form
    {
        Database database = new Database();
        private OrdinaryUser user;
        private int selectedRowDirector;
        private int selectedRowFilm;

        public Films(OrdinaryUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.user = user;
        }

        private void createDirectorsData()
        {
            directorsData.Columns.Add("id", "id");
            directorsData.Columns.Add("name", "Имя");
            directorsData.Columns.Add("birthDate", "Дата рождения");
            directorsData.Columns.Add("birthPlace", "Место рождения");
            directorsData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            directorsData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            directorsData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            directorsData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void readRowDirectors(DataGridView dataGrid, IDataRecord dataRecord)
        {
            dataGrid.Rows.Add(dataRecord.GetInt32(0), dataRecord.GetString(1), 
                dataRecord.GetString(2), dataRecord.GetString(3));

            if (dataRecord.GetInt32(4) == user.Id)
            {
                foreach (DataGridViewCell viewCell in dataGrid.Rows[dataGrid.Rows.Count - 1].Cells)
                {
                    viewCell.Style.BackColor = Color.LightGreen;
                }
            }
        }

        private void refreshDirectorsData(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string query = "SELECT * FROM Directors";

            SqlCommand sqlCommand = new SqlCommand(query, database.GetConnection());
            database.openConnection();

            SqlDataReader sqlDataReaderDirectors = sqlCommand.ExecuteReader();

            while (sqlDataReaderDirectors.Read())
            {
                readRowDirectors(dataGrid, sqlDataReaderDirectors);
            }
            sqlDataReaderDirectors.Close();
        }

        private void createFilmsData()
        {
            filmsData.Columns.Add("id", "id");
            filmsData.Columns.Add("name", "Название");
            filmsData.Columns.Add("creationYear", "Год создания");
            filmsData.Columns.Add("style", "Жанр");
            filmsData.Columns.Add("director_id", "Режиссер");
            filmsData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            filmsData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            filmsData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            filmsData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            filmsData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void readRowFilms(DataGridView dataGrid, IDataRecord dataRecord)
        {

            dataGrid.Rows.Add(dataRecord.GetInt32(0), dataRecord.GetString(1), dataRecord.GetInt32(2),
                dataRecord.GetString(3), dataRecord.GetString(4));

            if (dataRecord.GetInt32(5) == user.Id)
            {
                foreach (DataGridViewCell viewCell in dataGrid.Rows[dataGrid.Rows.Count - 1].Cells)
                {
                    viewCell.Style.BackColor = Color.LightGreen;
                }
            }
        }

        private void refreshFilmsData(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string query = "SELECT Films.id as id, Films.name as name" +
                ", Films.creationYear as creationYear, Films.style as style, " +
                "Directors.name as nameDirectors, Films.author as author FROM Films join Directors on " +
                "Directors.id = Films.director_id";

            SqlCommand sqlCommandFilms = new SqlCommand(query, database.GetConnection());
            database.openConnection();

            SqlDataReader sqlDataReaderFilms = sqlCommandFilms.ExecuteReader();

            while (sqlDataReaderFilms.Read())
            {
                readRowFilms(dataGrid, sqlDataReaderFilms);
            }
            sqlDataReaderFilms.Close();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            refreshFilmsData(filmsData);
        }

        private void Films_Load(object sender, EventArgs e)
        {
            createFilmsData();
            createDirectorsData();
            refreshFilmsData(filmsData);
            refreshDirectorsData(directorsData);
        }

        private void addNewFilmClick(object sender, EventArgs e)
        {
            addNewFilm addNewFilm = user.addNewFilm();
            addNewFilm.ShowDialog();
            addNewFilm.Close();
            refreshFilmsData(filmsData);
        }

        private void buttonUpdateFilm_Click(object sender, EventArgs e)
        {
            if (selectedRowFilm >= 0)
            {
                Film film = filmData();
                string query = $"SELECT author FROM Films WHERE id = {film.Id}";

                SqlCommand sqlCommand = new SqlCommand(query, database.GetConnection());
                database.openConnection();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                sqlDataReader.Read();
                if (user.Id == (int)sqlDataReader.GetValue(0) || Array.Exists(Admin.adminsID, element => element == user.Id))
                {
                    sqlDataReader.Close();
                    // создаем окно редактирования данных о фильме
                    updateFilm updateFilmForm = user.updateFilm(film);
                    updateFilmForm.ShowDialog();
                    updateFilmForm.Close();
                    refreshDirectorsData(directorsData);
                    refreshFilmsData(filmsData);
                }
                else
                {
                    sqlDataReader.Close();
                    MessageBox.Show("Можно удалять только те поля, которые вы создавали!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выберите режиссёра!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Film filmData()
        {
            DataGridViewRow row = filmsData.Rows[selectedRowFilm];
            int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            string name = row.Cells[1].Value.ToString();
            int creationYear = Convert.ToInt32(row.Cells[2].Value.ToString());
            string style = row.Cells[3].Value.ToString();
            string nameDirector = row.Cells[4].Value.ToString();

            string query = $"SELECT id FROM Directors WHERE name = '{nameDirector}'";
            SqlCommand sqlCommand = new SqlCommand(query, database.GetConnection());
            database.openConnection();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();

            int director_id = Convert.ToInt32(sqlDataReader.GetValue(0));
            sqlDataReader.Close();
            return new Film(id,
                name,
                creationYear,
                style,
                director_id);
        }

        private void buttonDeleteSearch_Click(object sender, EventArgs e)
        {
            lineSearch.Clear();
        }

        private void buttonDelSearchDirector_Click(object sender, EventArgs e)
        {
            searchDirector.Clear();
        }

        private void buttonUpdateDirectors_Click(object sender, EventArgs e)
        {
            refreshDirectorsData(directorsData);
        }

        private void addNewDirector_Click(object sender, EventArgs e)
        {
            addNewDirector addNewDirector1 = user.addNewDirector();
            addNewDirector1.ShowDialog();
            addNewDirector1.Close();
            refreshDirectorsData(directorsData);
        }

        private void lineSearch_TextChanged(object sender, EventArgs e)
        {
            filmsData.Rows.Clear();

            string searchFilm = $"SELECT f.id, f.name, creationYear, style, " +
                $"d.name as nameDirectors FROM Films f join Directors d ON " +
                $"f.director_id = d.id WHERE concat(f.id, f.name, creationYear, " +
                $"style, d.name) LIKE '%" + lineSearch.Text + "%'";
            

            SqlCommand sqlCommand = new SqlCommand(searchFilm, database.GetConnection());

            database.openConnection();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                readRowFilms(filmsData, sqlDataReader);
            }
            sqlDataReader.Close();

        }

        private void searchDirector_TextChanged(object sender, EventArgs e)
        {
            directorsData.Rows.Clear();

            string querySearchDirectors = $"SELECT * FROM Directors WHERE " +
                $"concat(id, name, birthDate, birthPlace) LIKE '%" + searchDirector.Text + "%'";

            SqlCommand sqlCommand = new SqlCommand(querySearchDirectors, database.GetConnection());

            database.openConnection();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                readRowDirectors(directorsData, sqlDataReader);
            }
            sqlDataReader.Close();
        }

        private void buttonUpdateDirector_Click(object sender, EventArgs e)
        {
            if (selectedRowDirector >= 0)
            {
                Director director = directorData();
                string query = $"SELECT author FROM Directors WHERE id = {director.Id}";

                SqlCommand sqlCommand = new SqlCommand(query, database.GetConnection());

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                sqlDataReader.Read();
                if (user.Id == (int)sqlDataReader.GetValue(0) || Array.Exists(Admin.adminsID, element => element == user.Id))
                {
                    sqlDataReader.Close();
                    updateDirector updateDirectorForm = user.updateDirector(director);
                    updateDirectorForm.ShowDialog();
                    updateDirectorForm.Close();
                    refreshDirectorsData(directorsData);
                    refreshFilmsData(filmsData);
                }
                else
                {
                    sqlDataReader.Close();
                    MessageBox.Show("Можно удалять только те поля, которые вы создавали!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Выберите режиссёра!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Director directorData()
        {
            DataGridViewRow row = directorsData.Rows[selectedRowDirector];
            return new Director(Convert.ToInt32(row.Cells[0].Value.ToString()),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString());
        }

        private void directorsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowDirector = e.RowIndex;
        }

        private void leaveFromAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logIn logIn = new logIn("Вход в систему");
            logIn.Show();
            this.Hide();
        }

        private void filmsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowFilm = e.RowIndex;
        }
    }
}
