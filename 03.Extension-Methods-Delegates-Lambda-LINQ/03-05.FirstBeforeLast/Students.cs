namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Students
    {
        //Fields
        private string firstName;
        private string lastName;
        private int age;

        //Constructor
        public Students(string firstName , string lastName , int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //Properties
        public string FirstName { get; private set; }
        
        public string LastName { get; private set; }

        public int Age { get; private set; }

        //Methods
        public static void Print(IEnumerable<Students> students)
        {
            foreach (Students student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            
            Console.WriteLine();
        }

        //Problem 3 
        public static void SortStudentByFirstName(IList<Students> sortStudents)
        {
            //var sortedStudents = sortStudents.Where(st => st.FirstName.CompareTo(st.LastName) < 0);
            var sortedStudents =
                from st in sortStudents
                where st.FirstName.CompareTo(st.LastName) < 0
                orderby st.FirstName
                select st;

            Console.WriteLine("Students sorted by first name before last name alphabeticly : ");

            Print(sortedStudents);
        }

        //Problem 4 
        public static void SortInAgeRange(IList<Students> sortStudents)
        {
            //var sortedStudents = sortStudents.Where(st => st.Age >= 18 && st.Age <= 24);

            var sortedStudents =
                from st in sortStudents
                where st.Age >= 18 && st.Age <= 24
                orderby st.Age
                select st;

            Console.WriteLine("Students sorted by age between 18 and 24 : ");
            Print(sortedStudents);
        }

        //Problem 5 
        public static void OrderStudentsInDescending(IList<Students> sortStudents)
        {
        //    var descendingSort = sortStudents
        //                         .OrderByDescending(st => st.FirstName)
        //                         .ThenByDescending(st => st.LastName);
            var descendingSort =
                from st in sortStudents
                orderby st.FirstName descending, st.LastName descending
                select st;

            Console.WriteLine("Students in descending order : ");
            Print(descendingSort);
        }


    }
}
