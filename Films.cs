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
        private int user_id;

        public Films(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            user_id = id;
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
        }

        private void refreshFilmsData(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string query = "SELECT Films.id as id, Films.name as name" +
                ", Films.creationYear as creationYear, Films.style as style, " +
                "Directors.name as nameDirectors FROM Films join Directors on " +
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
            addNewFilm addNewFilm = new addNewFilm(user_id);
            addNewFilm.ShowDialog();
            addNewFilm.Close();
            refreshFilmsData(filmsData);
        }

        private void buttonUpdateFilm_Click(object sender, EventArgs e)
        {

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
            addNewDirector addNewDirector1 = new addNewDirector(user_id);
            addNewDirector1.ShowDialog();
            addNewDirector1.Close();
            refreshDirectorsData(directorsData);
        }
    }
}
