//    We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches, a set of disciplines. Students have a name and unique class number. 
//    Classes have unique text identifier. Teachers have a name. Disciplines have a name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, 
//    teachers and disciplines could have optional comments (free text block).
//    Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace School
{
    using System;

    public class MainSchool
    {
        static void Main()
        {

            School school = new School("MG Baba Tonka");
            Console.WriteLine(school.ToString());

            Student student = new Student("Konstantin Todorov", 14);
            Console.WriteLine("{0} {1}",student.Name,student.ClassNumber);
            
            Class currentClass = new Class("10 B Class");
            Console.WriteLine(currentClass.ClassIdentifier.ToString());
            
            Teacher teacher = new Teacher("Ivan Stefanov");
            Console.WriteLine(teacher.Name.ToString());
            
            Discipline informatics = new Discipline("Informatics", 2, 2);
            Console.WriteLine(informatics.Name.ToString());

            //school.AddClass(currentClass);
            //currentClass.AddTeacher(teacher);
            //teacher.AddDiscipline(informatics);


        }    
    }
}
