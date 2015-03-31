namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cat : Animal
    {
        public Cat(int age,string name , char sex)
            : base (age,name,sex)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
