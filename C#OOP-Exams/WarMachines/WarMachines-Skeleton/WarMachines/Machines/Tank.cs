namespace WarMachines.Machines
{
    using Interfaces;
    using System.Text;

    public class Tank : Machine , ITank
    {
        private bool defenseMode;
        public Tank(string name, double attackPoints, double defensePoints, IPilot pilot = null)
            : base(name, 100, attackPoints, defensePoints, pilot)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get { return this.defenseMode; }
        }

        public void ToggleDefenseMode()
        {
            this.defenseMode = !defenseMode;
            if (defenseMode)
            {
                base.DefensePoints += 30;
                base.AttackPoints -= 40;
            }
            else
            {
                base.DefensePoints -= 30;
                base.AttackPoints += 40;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.AppendFormat(" *Defence: {0}", this.DefenseMode ? "ON" : "OFF");

            return result.ToString().Trim();
        }
    }
}
