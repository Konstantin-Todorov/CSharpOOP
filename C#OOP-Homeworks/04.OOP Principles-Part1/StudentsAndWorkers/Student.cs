﻿namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get { return this.grade; }
            private set 
            {
                if (value <= 1 || value > 6 )
                {
                    throw new ArgumentException("Grade must be in the range [2..6]");
                }
                this.grade = value; 
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}  Grade : {2}", this.FirstName.PadRight(10), this.LastName.PadRight(10), this.Grade);
        }
    }
}
