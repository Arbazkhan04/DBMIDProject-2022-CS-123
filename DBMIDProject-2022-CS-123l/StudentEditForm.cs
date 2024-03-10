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
    public partial class StudentEditForm : MaterialForm
    {
        int id;
        public StudentEditForm(int id)
        {
            this.id = id;
            InitializeComponent();
            showData();
            populateValueIntoComboxBox();

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

        private void StudentEditForm_Load(object sender, EventArgs e)
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
                PersonDl.updatePerson(id,person);
                StudentDl.updateStudent(id, student);
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

        //load the data fisrt into the text boxes
        public void showData()
        {
            string query = "SELECT * FROM person INNER JOIN student ON person.Id = student.Id WHERE person.Id = @PersonId";
            string connectionString = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open(); // Open the connection
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PersonId", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve person data
                            fname.Text = reader.GetString(reader.GetOrdinal("FirstName"));
                            lname.Text = reader.GetString(reader.GetOrdinal("LastName"));
                            contctf.Text = reader.GetString(reader.GetOrdinal("Contact"));
                            email2f.Text = reader.GetString(reader.GetOrdinal("Email"));
                            DateTime dateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));

                            regNof.Text = reader.GetString(reader.GetOrdinal("RegistrationNo"));

                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
