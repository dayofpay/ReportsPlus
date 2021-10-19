using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ReportsPlus
{
    public partial class CheckPerson : Form
    {
        public CheckPerson()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand checkResults = new MySqlCommand("SELECT * FROM persons WHERE egn = '" + egnBox.Text + "'", Database.connection);
                MySqlCommand checkResultsWork = new MySqlCommand("SELECT * FROM persons_status WHERE egn = '" + egnBox.Text + "'", Database.connection);
                using (MySqlDataReader reader = checkResults.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        API.getName = reader.GetString(0);
                        API.getSecondName = reader.GetString(1);
                        API.getThirdName = reader.GetString(2);
                        API.getAddress = reader.GetString(3);
                        API.getEgn = reader.GetString(4);
                        API.education_type = reader.GetString(5);
                        API.education_status = reader.GetString(6);
                        API.knownNicknames = reader.GetString(7);
                        API.photo = reader.GetString(8);
                        API.phoneNum = reader.GetString(9);
                        API.signature = reader.GetString(10);
                    }
                    reader.Close();
                }
                using (MySqlDataReader readWork = checkResultsWork.ExecuteReader())
                {
                    while (readWork.Read())
                    {
                        API.workplace = readWork.GetString(0);
                        API.workplace_role = readWork.GetString(1);
                        API.workplace_salary = readWork.GetDouble(2);
                    }
                    readWork.Close();
                }
                Person person = new Person();
                this.Hide();
                person.ShowDialog();
            }
            catch(MySqlException getError)
            {
                MessageBox.Show($"Грешка : \r\n {getError.Message}", "ReportsPlus | Error");
            }
        }
    }
}
