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
    public class StudentDl
    {
        public static void addStudent(Student student)
        {
            MessageBox.Show(nextStudentId().ToString());
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO student (Id,RegistrationNo) VALUES (@Id,@RegistrationNo)", con);
            cmd.Parameters.AddWithValue("@Id", nextStudentId());
            cmd.Parameters.AddWithValue("@RegistrationNo", student.regNo);
            cmd.ExecuteNonQuery();
        }

        public static void deleteStudent(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM student WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        public static void updateStudent(int id, Student student)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE student SET RegistrationNo = @RegistrationNo WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@RegistrationNo", student.regNo);
            cmd.Parameters.AddWithValue("@Id", id);
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
