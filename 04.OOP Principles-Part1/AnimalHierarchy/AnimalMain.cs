//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AnimalMain
    {
        static void Main()
        {
            Dog[] dogs = new Dog[]
            {
                new Dog(7, "Lancelot", 'M', "Retriever"),
                new Dog(5, "Sharo", 'F', "Sheperd"),
                new Dog(4, "Doge", 'F', "Labrador"),
                new Dog(9, "Mark", 'M', "Pincher")
            };

            Frog[] frogs = new Frog[]
            {
                new Frog(2, "Jabok"),
                new Frog(6, "Jabe"),
                new Frog(15,"Froggy"),
                new Frog(22,"Jabichka")
            };

            Cat[] cats = new Cat[] 
            {
                new Cat(5,"Suzana", 'M'),
                new Cat(10, "Maca", 'F'),
                new Cat(7, "Garfield", 'M'),
                new Cat(2, "Ivanka", 'M')
            };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten(2, "Katq"),
                new Kitten(2 , "Izabell"),
                new Kitten( 1,"Kleopatra")
            
            };

            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat(2,"Kotak"),
                new Tomcat(4,"Shisho"),
                new Tomcat( 8,"Barogazaro")
            };

            double dogsAverageAge = Animal.AverageAge(dogs);
            double frogsAverageAge = Animal.AverageAge(frogs);
            double catsAverageAge = Animal.AverageAge(cats);
            double kittensAverageAge = Animal.AverageAge(kittens);
            double tomcatsAverageAge = Animal.AverageAge(tomcats);

            Console.WriteLine("Average age of the dogs: {0:F2}", dogsAverageAge);
            Console.WriteLine("Average age of the frogs: {0:F2}", frogsAverageAge);
            Console.WriteLine("Average age of the cats: {0:F2}", catsAverageAge);
            Console.WriteLine("Average age of the kittens: {0:F2}", kittensAverageAge);
            Console.WriteLine("Average age of the tomcats: {0:F2}", tomcatsAverageAge);

            Console.WriteLine( new String('*', 30) );
            Console.Write("The cat says : ");
            cats[2].MakeSound();
            Console.Write("The dog says : ");
            dogs[2].MakeSound();
            Console.Write("The frog says : ");
            frogs[2].MakeSound();

        }
    }
}
