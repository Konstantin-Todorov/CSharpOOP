//Problem 9. Student groups
//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

//Problem 10. Student groups extensions
//Implement the previous using the same query expressed with extension methods.

//Problem 11. Extract students by email
//Extract all students that have email in abv.bg.
//Use string methods and LINQ.

//Problem 12. Extract students by phone
//Extract all students with phones in Sofia.
//Use LINQ.

//Problem 13. Extract students by marks
//Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
//Use LINQ.

//Problem 14. Extract students with two marks
//Write down a similar program that extracts the students with exactly two marks "2".
//Use extension methods.

//Problem 15. Extract marks
//Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

//Problem 16.* Groups
//Create a class Group with properties GroupNumber and DepartmentName.
//Introduce a property GroupNumber in the Student class.
//Extract all students from "Mathematics" department.
//Use the Join operator.

//Problem 17. Longest string
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

//Problem 18. Grouped by GroupNumber
//Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
//Use LINQ.

//Problem 19. Grouped by GroupName extensions
//Rewrite the previous using extension methods.

namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Students;

    public class StudentsMain
    {
        public static List<Student> students = new List<Student>()
            
        {
                new Student("Konstantin","Todorov","19506","02-760-324-4695","konstantin.todorof@gmail.com",new List<int>() { 2, 3,6,4,5 } ,5),
                new Student("Tony","Hadjiev","19523","02-260-324-4645","toni.trr@gmail.com",new List<int>() { 2, 3,5,4,3 } ,3),
                new Student("Biser","Sirakov","19524","02-760-223-4142","bs.sirakov@abv.bg",new List<int>() { 2, 4,6,6,5 } ,5),
                new Student("Kristin","Bankova","15525","02-160-245-3122","kr.bankova@abv.bg",new List<int>() { 3, 4,4,5,5 } ,2),
                new Student("Rafi","Pehlivanian","19527","03-760-123-2122","rafas.gibson@gmail.com",new List<int>() { 5,4 } ,1),
                new Student("Preslav","Georgiev","29506","04-740-773-4622","pepkobebko@gmail.com",new List<int>() { 2, 3,2,6,6 } ,5),
        };

        public static void Main()
        {
            //var studensFromGroupe5 = students.Where(st => st.GroupeNumber == 5)
            //                                 .OrderBy(st => st.FirstName);
            var studensFromGroupe5 = from st in students
                                     where st.GroupNumber == 5
                                     orderby st.FirstName
                                     select st;

            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Students From Groupe Five : \n");
            PrintStudents(studensFromGroupe5.ToArray<Student>()); //Problem  10
            Console.WriteLine(new string('*',40));

            var studentsWithABVMail = from st in students
                                      where st.EmailAdress.Contains("abv.bg")
                                      select st;
            
            Console.WriteLine("Students Whit Emails In ABV : \n");
            PrintStudents(studentsWithABVMail.ToArray<Student>()); //Problem 11
            Console.WriteLine(new string('*', 40));

            var studentsByPhone = from st in students
                                  where st.TelephoneNumber.StartsWith("02")
                                  select st;

            Console.WriteLine("Students With PhoneNumbers In \"Sofia\" Which  Starts Whit \"02\": \n");
            PrintStudents(studentsByPhone.ToArray<Student>()); //Problem 12
            Console.WriteLine(new string('*', 40));

            var studentsWithMark6 = from st in students
                                    where st.Marks.Contains(6)
                                    select new { FullName = st.FirstName + " " + st.LastName, Marks = st.MarksToString() };

            Console.WriteLine("Students Which Have Atleast One Excelent Grade : \n");
            
            foreach (var st in studentsWithMark6)
            {
                Console.WriteLine("FullName : {0} , Marks : {1} \n",st.FullName.PadRight(18,' '),st.Marks.PadRight(12,' '));
            }                                                                 //Problem 13
            
            Console.WriteLine(new string('*', 40));

            var studentsWithTwoMarks = students.Where(st => st.Marks.Count == 2);
            
            Console.WriteLine("Students With Two Marks : \n");
            
            foreach (var st in studentsWithTwoMarks)
            {
                var fullName = st.FirstName + " " + st.LastName;
                Console.WriteLine("FullName : {0} , Marks : {1} \n", fullName.PadRight(18, ' '), st.MarksToString().PadRight(12, ' '));
            }                                                                 //Problem 14
            
            Console.WriteLine(new string('*', 40));

            var studentMarksFrom2006 = from st in students
                                       where st.FacultyNumber.EndsWith("06")
                                       select st;

            Console.WriteLine("Students And Marks From \"2006\" : \n");

            foreach (var st in studentMarksFrom2006)
            {
                var fullName = st.FirstName + " " + st.LastName;
                Console.WriteLine("FullName : {0} , Marks : {1} \n", fullName.PadRight(18, ' '), st.MarksToString().PadRight(12, ' '));
            }                                                                 //Problem 15

            Console.WriteLine(new string('*', 40));

            Group[] departaments = new Group[]
            {
                new Group(1,"Art"),
                new Group(2,"Iconomics"),
                new Group(3,"Mathematics"),
                new Group(4,"Law"),
                new Group(5,"Informatics")
            };

            var studentsGroup = from st in students
                                join d in departaments on st.GroupNumber equals d.GroupNumber
                                where st.GroupNumber == 3
                                select new { FullName = st.FirstName + " " + st.LastName, Departament = d.DepartamentName };


            Console.WriteLine("Students From Departament \"Mathematics\" : \n");

            foreach (var st in studentsGroup)
            {
                Console.WriteLine("FullName : {0} , Departament : {1} \n", st.FullName.PadRight(18, ' '), st.Departament.PadRight(12, ' '));
            }                                                                 //Problem 16

            Console.WriteLine(new string('*', 40));

            var longestEmail = students.OrderByDescending(st => st.EmailAdress.Length).First().EmailAdress;
            Console.WriteLine("The Longest Email Is ------------> {0} \n",longestEmail); // Problem 17

            Console.WriteLine(new string ('*',40));

            var studentsGroupedByGroups = from st in students
                                          group st by st.GroupNumber into studentGroup
                                          select new { StudentGroup = studentGroup.Key, studentsInGroup = studentGroup };

            Console.WriteLine("Students Grouped By Groupes : \n");

            foreach (var group in studentsGroupedByGroups)
            {
                Console.WriteLine("Students In Group {0} : \n",group.StudentGroup);
                foreach (var student in group.studentsInGroup)
                {
                    Console.WriteLine("{0}\n",student);
                }
                Console.WriteLine(new string('-',40));
            }                                                                 //Problem 18

            Console.WriteLine(new string('*', 40));

            var studentsGroupedByExtintions = students.GroupBy(st => st.GroupNumber);

            Console.WriteLine("Students Group By Extention Metods : ");

            foreach (var group in studentsGroupedByExtintions)
            {
                Console.WriteLine("Students In Group {0} : \n",group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("{0}\n",student);
                }
                Console.WriteLine(new string('-', 40));
            }                                                                //Problem 19

            Console.WriteLine(new string('*', 40));
        }

        static void PrintStudents(Student[] students)
        {
            foreach (Student st in students)
            {
                Console.WriteLine(st + Environment.NewLine);
            }
        }
    }
}
