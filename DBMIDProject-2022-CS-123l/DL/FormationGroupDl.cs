using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DBMIDProject_2022_CS_123l.BL;
using System.Windows.Forms;
using System.Drawing;

namespace DBMIDProject_2022_CS_123l.DL
{
    public class FormationGroupDl
    {
        public static void createGroup()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO [Group] (Created_On) VALUES (@Created_On)", con);
            cmd.Parameters.AddWithValue("@Created_On",DateTime.Now);
            cmd.ExecuteNonQuery();
        }
        public static int nextGroupId()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT MAX(Id) FROM [Group]", con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }


        public static void addGroupStudent(FormationGroup group,int groupId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO GroupStudent (GroupId,StudentId,Status,AssignmentDate) VALUES (@GroupId,@StudentId,@Status,@AssignmentDate)", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@StudentId", group.studentId);
            cmd.Parameters.AddWithValue("@Status", group.status);
            cmd.Parameters.AddWithValue("@AssignmentDate", group.date);
            cmd.ExecuteNonQuery();
        }

        public static void addProjectGroup(int projectId,int groupId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO GroupProject (ProjectId,GroupId,AssignmentDate) VALUES (@ProjectId,@GroupId,@AssignmentDate)", con);
            cmd.Parameters.AddWithValue("@ProjectId", projectId);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
            cmd.ExecuteNonQuery();
        }


        // delete the studne form groupStudent table by id
        public static void deleteStudentGroupById(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmdDeleteStatus = new SqlCommand("DELETE FROM GroupStudent WHERE StudentId = @Id", con);
            cmdDeleteStatus.Parameters.AddWithValue("@Id", id);
            cmdDeleteStatus.ExecuteNonQuery();
        }

    }
}

