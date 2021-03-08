using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProject
{
    class Subject : Teacher, Print
    {
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public string GetInfo()
        {
            return "Subject Name: "+SubjectName+ "; Teacher Name: " + Name + "; Class&Section: " + ClassAndSection+"; Subject code: "+SubjectCode;
        }
    }
}
