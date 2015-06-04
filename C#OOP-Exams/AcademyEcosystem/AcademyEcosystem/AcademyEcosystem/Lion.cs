namespace AcademyEcosystem
{
    public class Lion : Animal , ICarnivore
    {
        private const int LionInitialSize = 6;
        private const int NullMeatEaten = 0;

        public Lion(string name, Point location)
            : base(name, location, LionInitialSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            var meatEaten = NullMeatEaten;

            if (animal != null && animal.Size <= this.Size * 2)
            {
                meatEaten = animal.GetMeatFromKillQuantity();
                base.Size++;
            }

            return meatEaten;
        }
    }
}
