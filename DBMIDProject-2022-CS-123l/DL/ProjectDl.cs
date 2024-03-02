using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMIDProject_2022_CS_123l.BL;
using System.Data.SqlClient;

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
    }
}
