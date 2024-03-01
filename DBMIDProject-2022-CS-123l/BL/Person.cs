using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBMIDProject_2022_CS_123l.BL
{
    public class Person
    {

        public string fName;
        public string lName;
        public string contact;
        public string email;
        public DateTime dateOfBirth;
        public int gender;

        public Person(string fName, string lName, string contact, string email, DateTime dateOfBirth, int gender)
        {
            this.fName = fName;
            this.lName = lName;
            this.contact = contact;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }
    }
}
