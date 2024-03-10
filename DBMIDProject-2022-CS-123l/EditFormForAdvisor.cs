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
    public partial class EditFormForAdvisor : MaterialForm
    {
        int id;
        public EditFormForAdvisor(int id)
        {
            InitializeComponent();
            this.id = id;
            showData();
           
            populateIntoAdvisorComboBox();
            populateIntoAdvisorDesigantionComboBox();
            // Create a material theme manager and add the form to manage (this)`
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

        private void EditFormForAdvisor_Load(object sender, EventArgs e)
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
            int designationCode = GetDesignationCode(designation);
            decimal salary = decimal.Parse(advisorSalary.Text);
            int genderNo = (gender == "Male") ? 1 : 2;

            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(designation))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                Person person = new Person(fName, lName, contact, email, dateOfBirth, genderNo);
                Advisor advisor = new Advisor(designationCode, salary);
                PersonDl.updatePerson(id,person);
                AdvisorDl.updateAdvisor(id,advisor);
            }

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
                    return -1;
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


        public  void showData()
        {
            MessageBox.Show("ejalekfl1");
            string query = "SELECT * FROM person INNER JOIN advisor ON person.Id = advisor.Id WHERE advisor.Id = 19";
            string connectionString = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open(); // Open the connection
                using (var cmd = new SqlCommand(query, con))
                {

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("ejalekfl");
                            // Retrieve person data
                            advisorFname.Text = reader.GetString(reader.GetOrdinal("FirstName"));
                            advisorLname.Text = reader.GetString(reader.GetOrdinal("LastName"));
                            advisorContact.Text = reader.GetString(reader.GetOrdinal("Contact"));
                            advisorEmail.Text = reader.GetString(reader.GetOrdinal("Email"));
                            DateTime dateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                            decimal salary = reader.GetDecimal(reader.GetOrdinal("Salary"));
                            advisorSalary.Text = salary.ToString();
                        }
                    }
                }
            }
        }

    }
}
