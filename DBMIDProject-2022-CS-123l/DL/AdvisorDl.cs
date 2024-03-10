using DBMIDProject_2022_CS_123l.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_123l.DL
{
    public class AdvisorDl
    {
        public static void addAdviosr(Advisor advisor)
        {
            MessageBox.Show(nextStudentId().ToString());
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Advisor (Id,Designation,Salary) VALUES (@Id,@Designation,@Salary)", con);
            cmd.Parameters.AddWithValue("@Id", nextStudentId());
            cmd.Parameters.AddWithValue("@Designation", advisor.designation);
            cmd.Parameters.AddWithValue("@Salary", advisor.salary);
            cmd.ExecuteNonQuery();
        }

        public static int nextStudentId()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select max(Id) from person", con);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }

        public static int getAdvisorIdByName(string name)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Advisor.Id FROM Advisor INNER JOIN Person ON Advisor.Id = Person.Id WHERE Person.FirstName = @Name", con);
            cmd.Parameters.AddWithValue("@Name", name);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show(id.ToString());
            return id;
        }
        public static void updateAdvisor(int id, Advisor advisor)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE advisor SET Designation = @Designation, Salary = @Salary WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Designation", advisor.designation);
            cmd.Parameters.AddWithValue("@Id", id); // This is the ID of the person to be updated
            cmd.Parameters.AddWithValue("@Salary", advisor.salary);
            cmd.ExecuteNonQuery();
        }


        // delete advisor 
        public static void deleteAdvisor(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Advisor WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        //delete project asdivsor first 
        public static void deleteProjectAdvisor(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM ProjectAdvisor WHERE AdvisorId = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }


    }
}
