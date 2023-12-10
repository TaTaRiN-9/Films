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

        public Films()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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

        private void readRow(DataGridView dataGrid, IDataRecord dataRecord)
        {

            dataGrid.Rows.Add(dataRecord.GetInt32(0), dataRecord.GetString(1), dataRecord.GetInt32(2),
                dataRecord.GetString(3), dataRecord.GetInt32(4));
        }

        private void refreshFilmsData(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            string query = $"SELECT * FROM Films";

            SqlCommand sqlCommand = new SqlCommand(query, database.GetConnection());
            database.openConnection();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader);
                readRow(dataGrid, sqlDataReader);
            }
            sqlDataReader.Close();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            refreshFilmsData(filmsData);
        }

        private void Films_Load(object sender, EventArgs e)
        {
            createFilmsData();
            refreshFilmsData(filmsData);
        }

        private void addNewFilmClick(object sender, EventArgs e)
        {

        }

        private void buttonUpdateFilm_Click(object sender, EventArgs e)
        {

        }
    }
}
