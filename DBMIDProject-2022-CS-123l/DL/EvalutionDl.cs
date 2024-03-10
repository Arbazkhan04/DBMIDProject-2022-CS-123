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
    public class EvalutionDl
    {
        // addd into the database
        public static void addEvalution(string name, int totalMarks, int totalWeightage)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Evaluation (Name,TotalMArks,TotalWeightage) VALUES (@Name,@TotalMArks,@TotalWeightage)", con);
            cmd.Parameters.AddWithValue("@Name",name);
            cmd.Parameters.AddWithValue("@TotalMArks", totalMarks);
            cmd.Parameters.AddWithValue("@TotalWeightage", totalWeightage);
            cmd.ExecuteNonQuery();
        }

        public static void addGroupEvalution(int groupId, int evalutionId,int marks,DateTime date)
        {
            MessageBox.Show("Group Id: " + groupId + " Evalution Id: " + evalutionId + " Marks: " + marks + " Date: " + date);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO GroupEvaluation  VALUES (@GroupId,@EvaluationId,@ObtainedMarks,@EvaluationDate)", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@EvaluationId", evalutionId);
            cmd.Parameters.AddWithValue("@ObtainedMarks", marks);
            cmd.Parameters.AddWithValue("@EvaluationDate", date);
            cmd.ExecuteNonQuery();
        }
    }
}
