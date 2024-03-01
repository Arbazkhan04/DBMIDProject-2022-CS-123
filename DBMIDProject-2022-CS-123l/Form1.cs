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
using DBMIDProject_2022_CS_123l.BL;
using DBMIDProject_2022_CS_123l.DL;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DBMIDProject_2022_CS_123l
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            populateValueIntoComboxBox();
            showData(dataGridView1);
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void studentPage_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void advisorPage_Click(object sender, EventArgs e)
        {

        }

        private void fname_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void lname_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void contctf_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void emailf_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
             
            string fName = fname.Text;
            string lName = lname.Text;
            string contact = contctf.Text;
            string email = email2f.Text;
            DateTime dateOfBirth = dateTimePicker1.Value;
            string gender = comboBox1.Text;
            string regNo = regNof.Text;
            int reg = (gender == "Male") ? 1 : 2;

            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(regNo))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                Person person = new Person(fName, lName, contact, email, dateOfBirth, reg);
                Student student = new Student(regNo);
                PersonDl.addPerson(person);
                StudentDl.addStudent(student);
            }

            //reset the form as well
            resetForm();
        }

        public void resetForm()
        {

            // Reset form values
            fname.Text = "";
            lname.Text = "";
            contctf.Text = "";
            email2f.Text = "";
            dateTimePicker1.Value = DateTime.Today; // Reset DateTimePicker to today's date
            comboBox1.SelectedIndex = -1; // Reset ComboBox selection
            regNof.Text = "";

            MessageBox.Show("Form submitted successfully.");
        }

        public void populateValueIntoComboxBox()
        {
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static void showData(DataGridView dataGridView)
        {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("select * from Person inner join Student on Person.Id = Student.Id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
        }
    }
}
