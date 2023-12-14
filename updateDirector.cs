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
    public partial class updateDirector : Form
    {
        private Database database = new Database();
        private Director director;
        public updateDirector(Director director)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Изменение данных режиссёра";
            this.director = director;
        }

        private void updateDirector_Load(object sender, EventArgs e)
        {
            textSurname.Text = director.Name.Split()[0];
            textName.Text = director.Name.Split()[1];
            textPlace.Text = director.BirthPlace;
            dateTimePickerDate.Text = director.BirthDate;
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
        }

        private void buttonUpdateDirector_Click(object sender, EventArgs e)
        {
            if (textSurname.Text != "" && textName.Text != "" && 
                textPlace.Text != "")
            {
                string fullName = textSurname.Text + " " + textName.Text;
                string queryUpdateDirector = $"UPDATE Directors SET " +
                    $"name = '{fullName}', birthDate = '{dateTimePickerDate.Text}', birthPlace = '{textPlace.Text}'" +
                    $"WHERE id = {director.Id}";

                SqlCommand sqlCommand = new SqlCommand(queryUpdateDirector, database.GetConnection());
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

        private void buttonDeleteDirector_Click(object sender, EventArgs e)
        {
            if (textSurname.Text != "" && textName.Text != "" &&
                textPlace.Text != "")
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого режиссёра?\n" +
                    "Все фильмы, создавшие этот режиссер, тоже будут удалены!",
                    "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    string queryDeleteFilm = $"DELETE Films WHERE director_id = {director.Id}";
                    SqlCommand sqlCommand = new SqlCommand(queryDeleteFilm, database.GetConnection());
                    database.openConnection();
                    sqlCommand.ExecuteNonQuery();
                    database.closeConnection();

                    string fullName = textSurname.Text + " " + textName.Text;
                    string queryUpdateDirector = $"DELETE Directors WHERE id = {director.Id}";

                    SqlCommand sqlCommand2 = new SqlCommand(queryUpdateDirector, database.GetConnection());
                    database.openConnection();
                    sqlCommand2.ExecuteNonQuery();
                    database.closeConnection();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
