namespace WarMachines.Machines
{
    using Interfaces;
    using System.Text;

    public class Fighter : Machine, IFighter
    {
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defencePoints, bool stealthMode, IPilot pilot = null)
            : base(name, 200, attackPoints, defencePoints, pilot)
        {
            this.ToggleStealthMode();
        }

        public bool StealthMode
        {
            get { return this.stealthMode; }
        }
        public void ToggleStealthMode()
        {
            this.stealthMode = !stealthMode;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.AppendFormat(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF").AppendLine();

            return result.ToString().Trim();
        }
    }
}
