using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsPlus
{
    public partial class OnStart : Form
    {
        public OnStart()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            CheckPerson check = new CheckPerson();
            this.Hide();
            check.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CreatePerson create = new CreatePerson();
            this.Hide();
            create.ShowDialog();
        }

        private void OnStart_Load(object sender, EventArgs e)
        {
            Database.Connect();
        }
    }
}
