namespace School
{
    using System;

    public class Student : People
    {
        private int classNumber;

        public Student(string name,int classNumber)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }


        public int ClassNumber
        {
            get { return this.classNumber; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException();
                }

                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name : {0} \nClass Number : {1} ", this.Name, this.ClassNumber);
        }
    }
}
