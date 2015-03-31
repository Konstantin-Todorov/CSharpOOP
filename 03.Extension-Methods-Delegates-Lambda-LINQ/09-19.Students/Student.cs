namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        //Problem 9
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string telephoneNumber;
        private string emailAdress;
        private List<int> marks;
        private int groupNumber;

        public Student(string firstName,string lastName,string facultyNumber,string telephoneNumber,string emailAdress,List<int> marks,int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.TelephoneNumber = telephoneNumber;
            this.EmailAdress = emailAdress;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            private set { groupNumber = value; }
        }

        public List<int> Marks
        {
            get { return marks; }
            private set { marks = value; }
        }

        public string EmailAdress
        {
            get { return emailAdress; }
            private set { emailAdress = value; }
        }

        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            private set { telephoneNumber = value; }
        }
        
        public string FacultyNumber
        {
            get { return facultyNumber; }
            private set { facultyNumber = value; }
        }

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }
        
        public override string ToString()
        {
            return string.Format("Name : {0} {1}\nFN   : {2}\nTel  : {3}\nEmail: {4}\nMarks: {5}\nGroup: {6}",
                this.FirstName, this.LastName, this.FacultyNumber, this.TelephoneNumber, this.EmailAdress, string.Join(", ", this.Marks), this.GroupNumber);
        }

        public string MarksToString()
        {
            return string.Join(",", this.Marks.ToArray());
        }
    }
}
