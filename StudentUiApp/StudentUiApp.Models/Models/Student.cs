using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentUiApp.Models.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }

        public string oldName;

    }
}
