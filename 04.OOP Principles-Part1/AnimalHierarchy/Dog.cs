namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dog : Animal
    {
        private string breed;

        public Dog(int age,string name,char sex,string breed)
            :base (age,name,sex)
        {

        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau bau");
        }
    }
}
