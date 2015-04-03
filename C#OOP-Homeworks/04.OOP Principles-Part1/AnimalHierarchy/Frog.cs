namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Frog : Animal
    {
        public Frog(int age, string name )
                :base(age,name,'M')
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine("Kwak");
        }
    }
}
