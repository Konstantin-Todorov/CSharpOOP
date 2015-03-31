namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private char sex;

        public Animal(int age , string name , char sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public char Sex
        {
            get { return this.sex; }
            private set { this.sex = value; }
        }
        

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public static double AverageAge(Animal[] arr)
        {
            return arr.Average(x => x.Age);
        }

        public abstract void MakeSound();
    }
}
