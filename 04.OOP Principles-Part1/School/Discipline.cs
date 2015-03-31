namespace School
{
    using System;

    public class Discipline : People
    {
        //private string name;
        private int numberOfLectures;
        private int numberOfExercices;

        public Discipline(string name )
        {
            this.Name = name;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercices = numberOfExcercises;
        }

        public int NumberOfExcercices
        {
            get { return this.numberOfExercices; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException();
                }
                this.numberOfExercices = value; 
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            private set 
            {

                if (value < 0)
                {
                    throw new ArgumentNullException();
                }

                this.numberOfLectures = value;
            }
        }
        
        //public string Name
        //{
        //    get { return this.name; }
        //    private set
        //    {
        //        if (value == null)
        //        {
        //            throw new ArgumentNullException();
        //        }

        //        this.name = value; 
        //    }
        //}

        public override string ToString()
        {
            return string.Format("Name :{0} , Number Of Lectures :{1} , Number Of Excercices :{2}", this.Name, this.NumberOfLectures, this.NumberOfExcercices);
        }
    }
}
