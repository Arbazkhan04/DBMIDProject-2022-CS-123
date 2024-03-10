using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMIDProject_2022_CS_123l.BL;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_123l.DL
{
    public class ProjectDl
    {
        public static void addProject(Project project)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Project (Title,Description) VALUES (@Title,@Description)", con);
            cmd.Parameters.AddWithValue("@Title", project.title);
            cmd.Parameters.AddWithValue("@Description", project.description);
            cmd.ExecuteNonQuery();
        }   

        public static int nextProjectId()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select max(Id) from Project", con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }

        public static void addProjectStatus(int status,int projectId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO ProjectStatus (isApproved,project_Id) VALUES (@isApproved,@project_Id)", con);
            cmd.Parameters.AddWithValue("@isApproved", status);
            cmd.Parameters.AddWithValue("@project_Id", projectId);
            cmd.ExecuteNonQuery();
        }   

        // delete the project from the database first romove the freign key contraint form projecr status then delete the project
        public static void deleteProject(int id)
        {
            var con = Configuration.getInstance().getConnection();
            // First, delete related records from projectStatus
            SqlCommand cmdDeleteStatus = new SqlCommand("DELETE FROM projectStatus WHERE Project_Id = @Id", con);
            cmdDeleteStatus.Parameters.AddWithValue("@Id", id);
            cmdDeleteStatus.ExecuteNonQuery();

            // Then, delete the project itself
            SqlCommand cmdDeleteProject = new SqlCommand("DELETE FROM Project WHERE Id = @Id", con);
            cmdDeleteProject.Parameters.AddWithValue("@Id", id);
            cmdDeleteProject.ExecuteNonQuery();
        }

        //update the project in project staus just change the staut from 0 to 1
        public static void updateProject(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE projectStatus SET isApproved = @isApproved WHERE project_Id = @Id", con);
            cmd.Parameters.AddWithValue("@isApproved", 1);
            cmd.Parameters.AddWithValue("@Id", id); 
            cmd.ExecuteNonQuery();
        }


        //add advisor to the project
        public static void addAdvisorToProject(int projectId, int advisorId, int role)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES (@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate)", con);
            cmd.Parameters.AddWithValue("@AdvisorId", advisorId);
            cmd.Parameters.AddWithValue("@ProjectId", projectId);
            cmd.Parameters.AddWithValue("@AdvisorRole", role);
            cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Today); // Ensure AssignmentDate is compatible with the data type in the database schema
            cmd.ExecuteNonQuery();
        }

    }
}
