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
    public class PersonDl
    {
        public static void addPerson(Person person)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Person (FirstName,LastName,Contact,Email,DateOfBirth,Gender) VALUES (@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
            cmd.Parameters.AddWithValue("@FirstName", person.fName);
            cmd.Parameters.AddWithValue("@LastName", person.lName);
            cmd.Parameters.AddWithValue("@Contact", person.contact);
            cmd.Parameters.AddWithValue("@Email", person.email);
            cmd.Parameters.AddWithValue("@DateOfBirth", person.dateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", person.gender);
            cmd.ExecuteNonQuery();
        }

        public static void deletePerson(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Person WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        public static void updatePerson(int id, Person person)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@FirstName", person.fName);
            cmd.Parameters.AddWithValue("@Id", id); // This is the ID of the person to be updated
            cmd.Parameters.AddWithValue("@LastName", person.lName);
            cmd.Parameters.AddWithValue("@Contact", person.contact);
            cmd.Parameters.AddWithValue("@Email", person.email);
            cmd.Parameters.AddWithValue("@DateOfBirth", person.dateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", person.gender);
            cmd.ExecuteNonQuery();
        }
    }
}
