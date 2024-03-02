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
using System.Xml.Linq;
using DBMIDProject_2022_CS_123l.BL;
using DBMIDProject_2022_CS_123l.DL;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DBMIDProject_2022_CS_123l
{
    public partial class Form1 : MaterialForm
    {
        //query for showing in data grid view student
        string queryShowStudet = "select * from Person inner join Student on Person.Id = Student.Id";
        string queryShowAdvisor = "select * from person inner join Advisor on Person.Id = Advisor.Id";
        public Form1()
        {
            InitializeComponent();
            //for student
            populateValueIntoComboxBox();
            showData(dataGridView1, queryShowStudet);
         
            //for advisor
            populateIntoAdvisorComboBox();
            showData(advisorDataGridView2, queryShowAdvisor);
            populateIntoAdvisorDesigantionComboBox();
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

        public static void showData(DataGridView dataGridView,string query)
        {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            string fName = advisorFname.Text;
            string lName = advisorLname.Text;
            string contact = advisorContact.Text;
            string email = advisorEmail.Text;
            DateTime dateOfBirth = advisorDateTimePicker.Value;
            string gender = advisorComboBox.Text;
            string designation = DesignationComboBox.Text;
            int designationCode =  GetDesignationCode(designation);
            decimal salary = decimal.Parse(advisorSalary.Text);
            int genderNo = (gender == "Male") ? 1 : 2;
            MessageBox.Show(salary.ToString());
            MessageBox.Show(designation);
            MessageBox.Show(designationCode.ToString());
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(designation))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                Person person = new Person(fName, lName, contact, email, dateOfBirth, genderNo);
                Advisor advisor = new Advisor(designationCode, salary);
                PersonDl.addPerson(person);
                AdvisorDl.addAdviosr(advisor);
            }

            //reset the form as well
            resetForm();
        }

        private int GetDesignationCode(string designation)
        {
            switch (designation.ToLower())
            {
                case "professor":
                    return 6;
                case "assistant professor":
                    return 8;
                case "lecturer":
                    return 9;
                case "industry professional":
                    return 10;
                case "associate professor":
                    return 7;
                default:
                    return -1; // Default code indicating an unknown designation
            }
        }

        public void populateIntoAdvisorComboBox()
        {
            advisorComboBox.Items.Add("Male");
            advisorComboBox.Items.Add("Female");
        }

        public void populateIntoAdvisorDesigantionComboBox()
        {
            DesignationComboBox.Items.Add("Professor");
            DesignationComboBox.Items.Add("Assistant Professor");
            DesignationComboBox.Items.Add("Associate Professor");
            DesignationComboBox.Items.Add("Lecturer");
            DesignationComboBox.Items.Add("Industry Professional");
        }

        private void DesignationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void materialTabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            string t = title.Text;
            string description = richTextBox1.Text;
           
            if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(t))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                Project  project = new Project(t, description);
                ProjectDl.addProject(project);
                //get id of project
                //create an object projectStatus and add it to the database 
                int projectId = ProjectDl.nextProjectId();
                ProjectDl.addProjectStatus(0, projectId);

            }

        }
    }
}
