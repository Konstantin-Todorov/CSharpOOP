namespace AcademyEcosystem
{
    public class Boar : Animal , IHerbivore , ICarnivore
    {
        private const int BoarInitialSize = 4;
        private const int NullMeatEaten = 0;
        private const int NullQuantitiEaten = 0;
        private const int BoarBiteSize = 2;

        private int biteSize;

        public Boar(string name, Point location)
            : base(name,location, BoarInitialSize)
        {
            this.biteSize = BoarBiteSize;
        }

        public int TryEatAnimal(Animal animal)
        {
            int meatEaten = NullMeatEaten; 
            
            if (animal != null && animal.Size <= this.Size)
            {
                meatEaten = animal.GetMeatFromKillQuantity();
            }

            return meatEaten;
        }

        public int EatPlant(Plant plant)
        {
            int quantityEaten = NullQuantitiEaten;
            
            if (plant != null)
            {
                quantityEaten = plant.GetEatenQuantity(this.biteSize);
                base.Size++;
            }

            return quantityEaten;
        }
    }
}
