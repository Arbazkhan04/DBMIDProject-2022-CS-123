using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMIDProject_2022_CS_123l.BL;
using DBMIDProject_2022_CS_123l.DL;
using MaterialSkin;
using MaterialSkin.Controls;


namespace DBMIDProject_2022_CS_123l
{
    public partial class Group : MaterialForm
    {
        int count = 0;//to count the number of students(student can not exceed 3);
        int projectId;
        List<FormationGroup> groups = new List<FormationGroup>();
        string queryForStudent = "SELECT * FROM Student";
        public Group(int prjectId)
        {
            projectId = prjectId;
            MessageBox.Show(projectId.ToString());
            InitializeComponent();
            //show all the students in the data grid view
            showStudennt(dataGridView1, queryForStudent);

            // Initialize MaterialSkinManager
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            // Subscribe to the FormClosing event
            this.FormClosing += Group_FormClosing;
        }

        private void Group_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show the main form (Form1) when the Group form is closing
            Form1 mainForm = new Form1();
            mainForm.Show();
        }


        private void Group_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public  void showStudennt(DataGridView dataGridView,string query)
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
           acceptButton.HeaderText = "Add Student";
            acceptButton.Text = "Add Student";
            acceptButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(acceptButton);

            // Handle button click event
            dataGridView.CellContentClick += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                    string buttonClicked = dataGridView.Columns[e.ColumnIndex].HeaderText;
                    if(buttonClicked == "Add Student")
                    {
                        count++; // Increment the count
                        if (count > 3)
                        {
                            MessageBox.Show("You can not add more than 3 students in a group add students again");
                            //empty the studnet list as well
                            groups.Clear();
                            count = 0; //rest the count;
                            return;
                        }
                        // Add the student to the list
                        groups.Add(new FormationGroup(id, 3, DateTime.Now)); //3 means the status is active
                        MessageBox.Show("Add into Group : " + id);
                     }
                 }
            };
       }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            // when the button is clicked add the group into the database and group project and group stundets
            //first add the group into the database
            if (count>0 && count <= 3)
            {
                //craete a group
                FormationGroupDl.createGroup();
                //get the id of the group
                int groupId = FormationGroupDl.nextGroupId();
                //create the group student
                foreach (var group in groups)
                {
                    //add the group student
                    FormationGroupDl.addGroupStudent(group, groupId);
                }
                //create group project
                FormationGroupDl.addProjectGroup(projectId, groupId);
                MessageBox.Show("Group Created");
            }
            else
            {
                MessageBox.Show("You can not add more than 3 or 0 students in a group add students");
            }
            count = 0;
            groups.Clear();
        }
    }
}
