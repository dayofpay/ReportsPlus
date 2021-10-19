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
    public partial class CreatePerson : Form
    {
        public CreatePerson()
        {
            InitializeComponent();
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            API.getName = nameBox.Text;
            API.getSecondName = secondName.Text;
            API.getThirdName = thirdName.Text;
            API.getEgn = egn.Text;
            API.phoneNum = phone.Text;
            API.getAddress = addressBox.Text;
            API.knownNicknames = nicknames.Text;
            API.signature = signature.Text;
            API.photo = photo.Text;
            API.workplace = workplace.Text;
            API.workplace_role = position.Text;
            API.workplace_salary = Convert.ToInt16(salary.Text);
            API.education_type = education.Text;
            API.education_status = education_status.Text;
            try
            {
                MySqlCommand uploadPerson = new MySqlCommand("INSERT INTO persons(firstName,secondName,thridName,address,egn,education_type,education_status,known_nicknames,photo,phone_number,signature)VALUES('" + API.getName + "'" + "," + "'" + API.getSecondName + "','" + API.getThirdName + "','" + API.getAddress + "','" + API.getEgn + "','" + API.education_type + "','" + API.education_status + "','" + API.knownNicknames + "','" + API.photo + "','" + API.phoneNum + "','" + API.signature + "')", Database.connection);
                MySqlCommand uploadWorkData = new MySqlCommand("INSERT INTO persons_status(workplace,workplace_role,workplace_salary,egn)VALUES('" + API.workplace + "','" + API.workplace_role + "','" + API.workplace_salary + "','" + API.getEgn + "')",Database.connection);
                uploadPerson.ExecuteScalar();
                uploadWorkData.ExecuteScalar();
            }
            catch(MySqlException dataError)
            {
                MessageBox.Show($"Грешка: \r\n {dataError.ToString()}", "ReportsPlus");
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            OnStart onStart = new OnStart();
            this.Hide();
            onStart.ShowDialog();
        }

        private void CreatePerson_Load(object sender, EventArgs e)
        {

        }
    }
}
