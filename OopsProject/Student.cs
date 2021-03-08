using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProject
{
    class Student : Print
    {
        public string Name { get; set; }
        public string ClassAndSection { get; set; }


        public virtual string GetInfo()
        {
            return "Name: " + Name + ", Class&Section: " + ClassAndSection;
        }

    }
}
