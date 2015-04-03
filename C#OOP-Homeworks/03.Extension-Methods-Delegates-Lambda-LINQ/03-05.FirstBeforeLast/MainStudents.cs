//Problem 3:
//First before last
//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.

//Problem 4:
//Age range
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

//Problem 5:
//Order students
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.

namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainStudents
    {
        static void Main()
        {
            Students[] groupe = new Students[]
            {
                new Students("Konstantin","Todorov",19),
                new Students("Tony","Hadjiev",21),
                new Students("Biser","Sirakov",20),
                new Students("Kristin","Bankova",20),
                new Students("Rafi","Pehlivanian",25),
                new Students("Preslav","Georgiev",30)
            };

            //Problem 3
            Students.SortStudentByFirstName(groupe);

            //Problem 4
            Students.SortInAgeRange(groupe);

            //Problem 5 
            Students.OrderStudentsInDescending(groupe);

        }
    }
}
