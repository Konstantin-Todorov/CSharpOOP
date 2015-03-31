
namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using StudentClass.Enumerations;

    public class Student : ICloneable , IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string mobilePhone;
        private string email;
        private string course;
        private Speciality speciality;
        private Faculty faculty;
        private University university;

        public Student(string firstName, string middleName, string lastName, string ssn, string address,
            string mobilePhone, string email, string course, Speciality speciality, Faculty faculty, University university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MiddleName = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.Faculty = faculty;
            this.University = university;
        }

        public University University
        {
            get { return this.university; }
            private set { this.university = value; }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }
            private set { this.faculty = value; }
        }

        public Speciality Speciality
        {
            get { return this.speciality; }
            private set { this.speciality = value; }
        }

        public string Course
        {
            get { return this.course; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.course = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.email = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.mobilePhone = value;
            }
        }

        public string Address
        {
            get { return this.address; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.address = value;
            }
        }

        public string SSN
        {
            get { return this.ssn; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.ssn = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.middleName = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.firstName = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (this.FirstName.Equals((obj as Student).FirstName) &&
                this.MiddleName.Equals((obj as Student).MiddleName) &&
                this.LastName.Equals((obj as Student).LastName) &&
                this.SSN.Equals((obj as Student).SSN) &&
                this.Address.Equals((obj as Student).Address) &&
                this.MobilePhone.Equals((obj as Student).MobilePhone) &&
                this.Email.Equals((obj as Student).Email) &&
                this.Course.Equals((obj as Student).Course) &&
                this.Speciality.Equals((obj as Student).Speciality) &&
                this.Faculty.Equals((obj as Student).Faculty) &&
                this.University.Equals((obj as Student).University)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2}\nSsn: {3}\nAddress: {4}\nMobile: {5}\nEmail: {6}\nCourse: {7}\nSpeciality: {8}\nFaculty: {9}\nUniversity: {10}",
               this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.Email, this.Course, this.Speciality, this.Faculty, this.University);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((firstName != null) ? this.firstName.GetHashCode() : 0);
                result = result * 23 + ((middleName != null) ? this.middleName.GetHashCode() : 0);
                result = result * 23 + ((lastName != null) ? this.lastName.GetHashCode() : 0);
                result = result * 23 + this.ssn.GetHashCode();
                result = result * 23 + ((address != null) ? this.address.GetHashCode() : 0);
                result = result * 23 + ((mobilePhone != null) ? this.mobilePhone.GetHashCode() : 0);
                result = result * 23 + ((email != null) ? this.email.GetHashCode() : 0);
                result = result * 23 + this.course.GetHashCode();
                result = result * 23 + this.speciality.GetHashCode();
                result = result * 23 + this.university.GetHashCode();
                result = result * 23 + this.faculty.GetHashCode();
                return result;
            }
        }

        public static bool operator ==(Student firstStudent,Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone,  //Problem 2
                this.Email, this.Course, this.Speciality, this.Faculty, this.University);
        }




        public int CompareTo(Student other)
        {
            var nameOfStudent = this.FirstName + this.MiddleName + this.LastName;
            var nameOfOtherStudent = other.FirstName + other.MiddleName + other.LastName;                                //Problem 3

            if (nameOfStudent == nameOfOtherStudent)
            {
                return this.SSN.CompareTo(this.SSN);
            }

            return nameOfStudent.CompareTo(nameOfOtherStudent);
        }
    }
}
