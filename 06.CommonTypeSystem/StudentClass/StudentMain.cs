
//Problem 1. Student class
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

//Problem 2. IClonable
//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

//Problem 3. IComparable
//Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).    
namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudentClass.Enumerations;

    public class StudentMain
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", "Petrov", "Georgiev", "409522002", "ul.Bulgarska Morava", 
                "0894702306", "email@mail.com", "Third", Speciality.MehanicalEngineering, Faculty.Engeneering, University.AngelKunchev);
           
            Student student2 = new Student("Tony", "Stefanov", "Petkov", "200225904", "ul.Preslav",
                "0888888888", "emailite@mails.com", "Second", Speciality.Menagement, Faculty.Ecology, University.SofiaUniversity);
            
            Student student3 = new Student("Stefan", "Borislavov", "Draganov", "220225904", "ul.Todor Kablechkov",
                "0894125762", "yahoo@yahoo.com", "First", Speciality.Physiology, Faculty.Physiology, University.NBU);
            
            Student student4 = new Student("Tony", "Stefanov", "Petkov", "200225904", "ul.Preslav",
               "0888888888", "emailite@mails.com", "Second", Speciality.Menagement, Faculty.Ecology, University.SofiaUniversity);

            Console.WriteLine("Student 1 : {0}\n", student1);
            Console.WriteLine("Student 2 : {0}\n", student2);
            Console.WriteLine("Student 3 : {0}\n", student3);
            Console.WriteLine("Student 4 : {0}\n", student4);

            Console.WriteLine("\nstudent1`s hash code : {0}", student1.GetHashCode());
            Console.WriteLine("\nstudent2`s hash code : {0}", student2.GetHashCode());
            Console.WriteLine("\nstudent3`s hash code : {0}", student3.GetHashCode());
            Console.WriteLine("\nstudent4`s hash code : {0}", student4.GetHashCode());

            //Console.WriteLine("\nstudent2 == student4 --> {0}", student2 == student4);
            //Console.WriteLine("student1 != student2 --> {0}", student1 != student2);

            var clonedStudent1 = student1.Clone();

            Console.WriteLine("\nCloned student1 : \n{0}", clonedStudent1);
        }
    }
}
