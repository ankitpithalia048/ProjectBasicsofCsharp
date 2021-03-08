using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProject
{
    class OopsProjectProgram
    {
        public static void Do()
        {

            List<Student> students = new List<Student>();
            Student s1 = new Student() { Name = "Ankit", ClassAndSection = "X B" };
            Student s2 = new Student() { Name = "Sheetal", ClassAndSection = "XI B" };
            Student s3 = new Student() { Name = "Ramu", ClassAndSection = "XII B" };
            students.Add(s1); 
            students.Add(s2); 
            students.Add(s3);

            List<Subject> subjects = new List<Subject>();
            Subject subj1 = new Subject();
            subj1.Name = "Mr. john";
            subj1.SubjectCode = "phy-01";
            subj1.ClassAndSection = "X A";
            subj1.SubjectName = "Physics";
            Subject subj2 = new Subject();
            subj2.Name = "Mr. Rakesh";
            subj2.SubjectCode = "chem-01";
            subj2.ClassAndSection = "XI A";
            subj2.SubjectName = "Chemistry";
            Subject subj3 = new Subject();
            subj3.Name = "Mr. Deeraj";
            subj3.SubjectCode = "Bio-01";
            subj3.ClassAndSection = "XII A";
            subj3.SubjectName = "Biology";

            subjects.Add(subj1); 
            subjects.Add(subj2); 
            subjects.Add(subj3);
            
            Console.WriteLine("===============Students in a class=============\n");
            foreach (Student s in students)
                Console.WriteLine(s.GetInfo());
            Console.WriteLine("\n\n============Subjects Taught By Teacher============\n");
            foreach (Subject s in subjects)
                Console.WriteLine(s.GetInfo());
        }
    }
}
