namespace Infestation
{
    public class AggressionCatalyst : Catalyst, ISupplement
    {
        private const int PowerState = 3;
        private const int ZeroState = 0;

        public AggressionCatalyst()
            : base(ZeroState, ZeroState, PowerState)
        {
        }
    }
}
