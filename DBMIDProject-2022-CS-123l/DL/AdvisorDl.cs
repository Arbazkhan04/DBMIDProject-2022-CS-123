using DBMIDProject_2022_CS_123l.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
    }
}
