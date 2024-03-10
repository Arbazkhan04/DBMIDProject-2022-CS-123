using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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
        //advisor id 
        int projectId=0;
        //query for showing in data grid view student
        string queryShowStudet = "select Student.Id,Person.FirstName, Person.Contact,Person.Gender, Student.RegistrationNo from Person inner join Student on Person.Id = Student.Id";
        string queryShowAdvisor = "select Advisor.Id,Advisor.Designation, Person.FirstName, Person.Contact,Person.Gender from person inner join Advisor on Person.Id = Advisor.Id";
        string queryShowProject = "select * from project inner join projectstatus on project.Id = projectstatus.project_Id";
        string queryShowFacultyAdvisor = "select Project.Id,Project.Title,Project.Description,projectStatus.isApproved from Project inner join projectStatus on Project.Id = projectStatus.Id";
        string queryToShowAllAcceptedProject = "select Project.Id,Project.Title,Project.Description from Project inner join projectStatus on Project.Id = projectStatus.Id where projectStatus.isApproved = 1";
        string connectionString = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";
        String showAdvisorName = "SELECT FirstName FROM Advisor INNER JOIN Person ON Advisor.Id = Person.Id LEFT JOIN ProjectAdvisor ON Advisor.Id = ProjectAdvisor.AdvisorId WHERE ProjectAdvisor.AdvisorId IS NULL";
        public Form1()
        {
            InitializeComponent();
            //for student
            populateValueIntoComboxBox();
            showData(dataGridView1, queryShowStudet);

            //for advisor
            populateIntoAdvisorComboBox();
            showDataForAdvisor(advisorDataGridView2, queryShowAdvisor);
            populateIntoAdvisorDesigantionComboBox();

            //for project
            showDataForAdvisor(projectDataGridView, queryShowProject);

            //faculty advisor
            showFultyAdvisor(fADataGridView, queryShowFacultyAdvisor);

            //show all accepted project
            showListOfAvailableProject(showProjectDataGridView, queryToShowAllAcceptedProject);

            //select advisor for the project 
            selectBoardAdvisorForProject(dataGridView2,queryToShowAllAcceptedProject);

            //show advisor names
            populateAdvior(mainComboBox,showAdvisorName);
            populateAdvior(coAdvisorComboBox, showAdvisorName);
            populateAdvior(industrialComboBox, showAdvisorName);

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

        public void showData(DataGridView dataGridView, string query)
        {
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();


            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;

            // Adjust column width and enable text wrapping for all columns
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.MinimumWidth = 100; // Adjust the minimum width as needed
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            // Add Edit button
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(editButton);

            // Add Delete button
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(deleteButton);

            // Add new event handlers
            dataGridView.CellContentClick += dataGridView_CellContentClick;
        }

        private static void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                string buttonClicked = dataGridView.Columns[e.ColumnIndex].HeaderText;

                if (buttonClicked == "Edit")
                {
                    StudentEditForm editForm = new StudentEditForm(id);
                    editForm.ShowDialog();
                    // Refresh the DataGridView after editing
                }
                else if (buttonClicked == "Delete")
                {
                    //first delete from  studentGroup Tabel
                    FormationGroupDl.deleteStudentGroupById(id);
                    StudentDl.deleteStudent(id);
                }
            }
        }

    //show adviosr 
    public static void showDataForAdvisor(DataGridView dataGridView, string query)
        {
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;

            // Adjust column width and enable text wrapping for all columns
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.MinimumWidth = 100; // Adjust the minimum width as needed
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            // Add Edit button
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(editButton);
            // Add Delete button
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(deleteButton);

            // Handle button click event
            dataGridView.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                    string buttonClicked = dataGridView.Columns[e.ColumnIndex].HeaderText;

                    if (buttonClicked == "Edit")
                    {
                        EditFormForAdvisor editForm = new EditFormForAdvisor(id);
                        editForm.ShowDialog();
                    }
                    else if (buttonClicked == "Delete")
                    {
                        AdvisorDl.deleteProjectAdvisor(id);
                        AdvisorDl.deleteAdvisor(id);
                    }
                }
            };
        }

        //show project
        public static void showDataForProject(DataGridView dataGridView, string query)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;

            // Adjust column width and enable text wrapping for all columns
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.MinimumWidth = 100; // Adjust the minimum width as needed
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
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

                Project project = new Project(t, description);
                ProjectDl.addProject(project);
                //get id of project
                //create an object projectStatus and add it to the database 
                int projectId = ProjectDl.nextProjectId();
                ProjectDl.addProjectStatus(0, projectId);
                MessageBox.Show("Your project idea is submitted successfully");
            }

            //reset the form 
            title.Text = "";
            richTextBox1.Text = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static void showFultyAdvisor(DataGridView dataGridView, string query)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Set the DataSource first
            dataGridView.DataSource = dt;

            // Adjust column width and enable text wrapping for all columns
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.MinimumWidth = 100; // Adjust the minimum width as needed
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            // Add Accept button
            DataGridViewButtonColumn acceptButton = new DataGridViewButtonColumn();
            acceptButton.HeaderText = "Accept";
            acceptButton.Text = "Accept";
            acceptButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(acceptButton);

            // Add Reject button
            DataGridViewButtonColumn rejectButton = new DataGridViewButtonColumn();
            rejectButton.HeaderText = "Reject";
            rejectButton.Text = "Reject";
            rejectButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(rejectButton);

            // Handle button click event
            dataGridView.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                    string buttonClicked = dataGridView.Columns[e.ColumnIndex].HeaderText;

                    if (buttonClicked == "Accept")
                    {
                        // Handle Accept button click
                        // You can perform actions for accepting here
                        ProjectDl.updateProject(id);
                        MessageBox.Show("Accepted ID: " + id);
                    }
                    else if (buttonClicked == "Reject")
                    {
                        // Handle Reject button click
                        // You can perform actions for rejecting here
                        ProjectDl.deleteProject(id);
                        MessageBox.Show("Rejected ID: " + id);
                    }
                }
            };
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void showListOfAvailableProject(DataGridView dataGridView, string query)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Set the DataSource first
            dataGridView.DataSource = dt;

            // Adjust column width and enable text wrapping for all columns
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.MinimumWidth = 100; // Adjust the minimum width as needed
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            // Add Accept button
            DataGridViewButtonColumn acceptButton = new DataGridViewButtonColumn();
            acceptButton.HeaderText = "Create Group";
            acceptButton.Text = "Create Group";
            acceptButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(acceptButton);

            // Handle button click event
            dataGridView.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                    string buttonClicked = dataGridView.Columns[e.ColumnIndex].HeaderText;

                    if (buttonClicked == "Create Group")
                    {
                        // Handle Create Group button click
                        // You can perform actions for creating group here
                        MessageBox.Show("Create Group for ID: " + id);
                        Form group = new Group(id);
                        this.Opacity = 0;
                        group.Show();
                    }
                }
            };
        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void selectBoardAdvisorForProject(DataGridView dataGridView,string query)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Set the DataSource first
            dataGridView.DataSource = dt;

            // Add Accept button
            DataGridViewButtonColumn acceptButton = new DataGridViewButtonColumn();
            acceptButton.HeaderText = "Assign";
            acceptButton.Text = "Assign";
            acceptButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(acceptButton);

            // Handle button click event
            dataGridView.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                     projectId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                     string buttonClicked = dataGridView.Columns[e.ColumnIndex].HeaderText;

                    if (buttonClicked == "Assign")
                    {
                        // Handle Create Group button click
                        // You can perform actions for creating group here
                        //referh the comboBox as well
                        panel1.Visible = true; 
                    }
                }
            };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        public void populateAdvior(ComboBox comboBox, string query)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string advisorName = reader["FirstName"].ToString();
                comboBox.Items.Add(advisorName);
            }
            reader.Close();
        }
        private void materialRaisedButton15_Click(object sender, EventArgs e)
        {
            //check if maincombox is emty
            if(mainComboBox.SelectedItem != null || coAdvisorComboBox.SelectedItem!=null || industrialComboBox.SelectedItem!=null)
            {
                string mainAdvisor = mainComboBox.SelectedItem == null ? "" : mainComboBox.SelectedItem.ToString();
                string coAdvisor = coAdvisorComboBox.SelectedItem == null ? "" : coAdvisorComboBox.SelectedItem.ToString();
                string industrialAdvisor = industrialComboBox.SelectedItem == null ? "" : industrialComboBox.SelectedItem.ToString();
                MessageBox.Show(mainAdvisor);
                MessageBox.Show(coAdvisor);
                MessageBox.Show(industrialAdvisor);
                MessageBox.Show(projectId.ToString());
                //create object for main advisor 

                if (mainAdvisor != "")
                {
                    //get main Advior id by name
                    int advisorId = AdvisorDl.getAdvisorIdByName(mainAdvisor);  
                    // get the role of the advisor
                    // for main the id is 11;
                    ProjectDl.addAdvisorToProject(projectId,advisorId, 11);

                }
                if (coAdvisor != "")
                {
                    int advisorId = AdvisorDl.getAdvisorIdByName(coAdvisor);
                    // for co the id is 12;
                    ProjectDl.addAdvisorToProject(projectId,advisorId, 12);   
                }
                if (industrialAdvisor != "")
                {
                    int advisorId = AdvisorDl.getAdvisorIdByName(industrialAdvisor);

                    ProjectDl.addAdvisorToProject(projectId,advisorId, 14);
                }

                //add the advisor to the project
                // ProjectDl.addAdvisorToProject(mainAdvisor, coAdvisor, industrialAdvisor, advisorId);
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select atleast one advisor");
            }
           //resset the combobox as weel
            mainComboBox.SelectedIndex = -1;
            coAdvisorComboBox.SelectedIndex = -1;
            industrialComboBox.SelectedIndex = -1;
            projectId = 0;
            //clear the items of all comboBox first 
            mainComboBox.Items.Clear();
            coAdvisorComboBox.Items.Clear();
            industrialComboBox.Items.Clear();
            //populate the comboBox again
            populateAdvior(mainComboBox, showAdvisorName);
            populateAdvior(coAdvisorComboBox, showAdvisorName);
            populateAdvior(industrialComboBox, showAdvisorName);
        }
        private void coAdvisorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveSelectedItemFromOtherComboBoxes(coAdvisorComboBox, mainComboBox, industrialComboBox);
        }

        private void mainComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveSelectedItemFromOtherComboBoxes(mainComboBox, coAdvisorComboBox, industrialComboBox);
        }

        private void industrialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveSelectedItemFromOtherComboBoxes(industrialComboBox, mainComboBox, coAdvisorComboBox);
        }

        private void RemoveSelectedItemFromOtherComboBoxes(ComboBox selectedComboBox, ComboBox comboBox1, ComboBox comboBox2)
        {
            string selectedAdvisor = selectedComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedAdvisor))
            {
                // Remove the selected item from the other ComboBoxes
                comboBox1.Items.Remove(selectedAdvisor);
                comboBox2.Items.Remove(selectedAdvisor);
            }
        }

        private void regNof_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            showData(dataGridView1, queryShowStudet);
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            showDataForAdvisor(advisorDataGridView2, queryShowAdvisor);
        }
    }
}
