namespace AcademyEcosystem
{
    public class Grass : Plant , IOrganism 
    {
        private const int GrassSize = 2;

        public Grass(Point location)
            : base(location, GrassSize)
        {
        }

        public override void Update(int time)
        {
            if (base.IsAlive)
            {
                base.Size += time;
            }
        }
    }
}
