using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMIDProject_2022_CS_123l.BL
{
    public class FormationGroup
    {
        public int studentId;
        public int status;
        public DateTime date;

        public FormationGroup(int studentId, int status, DateTime date)
        {
            this.studentId = studentId;
            this.status = status;
            this.date = date;
        }
    }
}
