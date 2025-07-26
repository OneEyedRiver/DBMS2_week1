using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc2025.Models
{
    public class College
    {

        public class student {

            public string student_no { get; set; }

            public string name { get; set; }

            public string course { get; set; }

            public string address { get; set; }

            public List<Subjects> subjects { get; set;  }

            



        }

        public class Subjects
        {


            public string subjectCode { get; set; }

            public string subjectName { get; set; }

            public string day { get; set; }

            public string time { get; set; }



        }

    }
}