using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5.Models
{
    public class Teacher
    {   
        public int teacherID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string courseSubject { get; set; }
        public int studentID { get; set; }
    }
}
