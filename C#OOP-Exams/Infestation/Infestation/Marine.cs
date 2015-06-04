namespace Infestation
{
    using System.Collections.Generic;
    using System.Linq;

    public class Marine : Human
    {
        public Marine(string id)
            :base(id)
        {
            this.AddSupplement(new WeaponrySkill());
        }

        //public override void AddSupplement(ISupplement newSupplement)
        //{
        //    base.AddSupplement(WeaponrySkill);
        //}
        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (unit.Power <= unit.Aggression)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            return attackableUnits.OrderByDescending(u => u.Health)
                           .FirstOrDefault();
        }
    }
}
