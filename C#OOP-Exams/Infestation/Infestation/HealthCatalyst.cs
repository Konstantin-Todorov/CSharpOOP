namespace Infestation
{
    public class HealthCatalyst : Catalyst, ISupplement
    {
        private const int PowerState = 3;
        private const int ZeroState = 0;

        public HealthCatalyst()
            : base(ZeroState, PowerState, ZeroState)
        {
        }
    }
}
