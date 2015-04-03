namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName , string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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
        

        public string FirstName
        {
            get { return this.firstName; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.firstName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
