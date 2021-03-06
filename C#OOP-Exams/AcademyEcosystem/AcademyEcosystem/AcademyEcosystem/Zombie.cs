﻿namespace AcademyEcosystem
{
    public class Zombie : Animal
    {
        private const int ZombieSize = 0;

        public Zombie(string name, Point location)
            : base(name,location, ZombieSize)
        {
        }

        public override int GetMeatFromKillQuantity()
        {
            return 10;
        }
    }
}
