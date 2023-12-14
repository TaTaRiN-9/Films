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
    public partial class addNewDirector : Form
    {
        private Database database = new Database();
        private int user_id;
        public addNewDirector(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Добавление режиссёра";
            user_id = id;
        }

        private void addNewDirector_Load(object sender, EventArgs e)
        {
            dateTimePickerDate.Format = DateTimePickerFormat.Short;
        }

        private void addDirector_Click(object sender, EventArgs e)
        {
            if (textCity.Text != "" && textName.Text != "" && textSurname.Text != "")
            {
                string nameDirector = textSurname.Text + " " + textName.Text;
                string birthPlace = textCity.Text;
                string birthDate = dateTimePickerDate.Text;
                try
                {
                    string query = $"INSERT INTO Directors(name, birthDate, birthPlace, author) " +
                        $"VALUES ('{nameDirector}', '{birthDate}', '{birthPlace}', {user_id})";

                    SqlCommand sqlCommand = new SqlCommand(query, database.GetConnection());
                    database.openConnection();

                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить режиссёра!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Такой режиссёр уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Все поля должны быть заполнены и выбраны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
