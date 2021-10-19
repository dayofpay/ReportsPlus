using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Drawing.Imaging;
using System.Drawing.Printing;
namespace ReportsPlus
{
    public partial class Person : Form
    {
        private Button printButton = new Button();
        private PrintDocument printDocument1 = new PrintDocument();

        public Person()
        {
            InitializeComponent();
            printButton.Click += new EventHandler(printButton_Click);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.Controls.Add(printButton);
            printButton.Text = "ПРИНТИРАЙ";
        }
        void printButton_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }
        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Person_Load(object sender, EventArgs e)
        {

        var request = WebRequest.Create(API.photo);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
            var request2 = WebRequest.Create(API.signature);

            using (var response2 = request2.GetResponse())
            using (var stream2 = response2.GetResponseStream())
            {
                pictureBox2.Image = Bitmap.FromStream(stream2);
            }
            API.DoCalc(API.workplace_salary);
            name.Text = API.getName;
            secondName.Text = API.getSecondName;
            thirdName.Text = API.getThirdName;
            adress.Text = API.getAddress;
            egn.Text = API.getEgn;
            edu.Text = API.education_type;
            eduType.Text = API.education_status;
            nicknames.Text = API.knownNicknames;
            phoneNums.Text = API.phoneNum;
            workPlace.Text = API.workplace;
            workplacePosition.Text = API.workplace_role;
            salary.Text = API.workplace_salary+" BGN/ Месец";
            yearSalary.Text = API.yearSalary.ToString() + "BGN";
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static void Print()
        {

        }
    }
}
