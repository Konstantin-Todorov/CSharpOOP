namespace AcademyEcosystem
{
    public class Wolf : Animal , ICarnivore
    {
        private const int NullMeatEaten = 0;
        private const int WolfSize = 4;

        public Wolf(string name, Point location)
            : base(name, location, WolfSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            int meatEaten = NullMeatEaten;

            if (animal != null && (animal.Size <= this.Size || animal.State == AnimalState.Sleeping))
            {
                meatEaten = animal.GetMeatFromKillQuantity();
            }

            return meatEaten;
        }
    }
}
