namespace School
{
    using System;
    using System.Collections.Generic;

    public class Class 
    {
        private string classIdentifier;
        private List<Teacher> teacher;
        private List<Student> students;

        public Class(string classIdentifier)
        {
            this.ClassIdentifier = classIdentifier;
            this.Teacher = new List<Teacher>();
            this.Student = new List<Student>();
        }

        public List<Teacher> Teacher
        {
            get { return this.teacher; }
            private set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.teacher = value; 
            }
        }

        public string ClassIdentifier
        {
            get { return this.classIdentifier; }
            private set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.classIdentifier = value; 
            }
        }

        public List<Student> Student
        {
            get { return students; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                students = value;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teacher.Add(teacher);
        }
        
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public override string ToString()
        {
            return string.Format("Class : {0}", this.ClassIdentifier);
        }
    }
}
