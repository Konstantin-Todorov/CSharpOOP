﻿namespace Infestation
{
    using System.Collections.Generic;
    using System.Linq;

    public abstract class InfestUnit : Unit
    {
        public InfestUnit(string id, UnitClassification unitType, int health, int power, int aggression)
            :base(id,unitType,health,power,aggression)
        {
        }

        //protected override bool CanAttackUnit(UnitInfo unit)
        //{
        //    return this != unit;
        //}

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            return attackableUnits.OrderByDescending(x => x.Health).FirstOrDefault();
        }
        protected override bool CanAttackUnit(UnitInfo unit)
        {
            if (unit.Id != this.Id && InfestationRequirements.RequiredClassificationToInfest(unit.UnitClassification) == this.UnitClassification) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;  
        }
    }
}
