using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMIDProject_2022_CS_123l.BL
{
    public class Project
    {
        public string title;
        public string description;

        public Project(string title, string description)
        {
            this.title = title;
            this.description = description;
        }
    }
}
