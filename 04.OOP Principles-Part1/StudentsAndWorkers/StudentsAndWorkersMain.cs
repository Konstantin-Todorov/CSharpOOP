using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class StudentsAndWorkersMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Konstantin","Todorov",5),
                new Student("Toni","Hadjiev",4),
                new Student("Biser","Sirakov",3),
                new Student("Pesho","Yordanov",5),
                new Student("Preslav","Georgiev",6),
                new Student("Ivan","Velkov",3),
                new Student("Peter","Ivanov",2),
                new Student("Andrei","Ivanov",6),
                new Student("Bogomil","Hristoskov",5),
                new Student("Hristiana","Georgieva",4),
            };

            List<Worker> worker = new List<Worker>()
            {
                new Worker("Stefan","Georgiev",50,6),
                new Worker("Ismail","Hasanov",40,7),
                new Worker("Evgeni","Gevezovski",70,8),
                new Worker("Kristian","Genchev",45,6),
                new Worker("Georgy","Ivanov",100,7),
                new Worker("Hristian","Petrov",55,6),
                new Worker("Dimitur","Berbatov",75,10),
                new Worker("Gospodin","Todorov",200,3),
                new Worker("Valentin","Kocev",150,5),
                new Worker("Ron","Ribbas",300,2),
            };

            var studentsSortedByGrade = students.OrderBy(x => x.Grade);

            foreach (var student in studentsSortedByGrade)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new String('*',30));

            var workersSortedByMonyPerHour = worker.OrderByDescending(x => x.MoneyPerHour()).ToList();

            foreach (Worker employee in workersSortedByMonyPerHour)
            {
                Console.WriteLine(employee);
                Console.WriteLine(new String('-',20));
            }

            Console.WriteLine(new String('*',30));

            var concatGroups = studentsSortedByGrade
                .Concat<Human>(workersSortedByMonyPerHour)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            Console.WriteLine("Both Groups Sorted By Names :\n");
            foreach (var person in concatGroups)
            {
                Console.WriteLine("{0} {1}", person.FirstName.PadRight(10), person.LastName.PadRight(10));
            }
        }
    }
}
