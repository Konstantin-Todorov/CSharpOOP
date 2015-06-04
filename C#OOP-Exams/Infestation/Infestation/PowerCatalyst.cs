namespace Infestation
{
    public class PowerCatalyst : Catalyst, ISupplement
    {
        private const int PowerState = 3;
        private const int ZeroState = 0;

        public PowerCatalyst()
            : base(PowerState, ZeroState, ZeroState) 
        {
        }
    }
}
