namespace Infestation
{
    public class HoldingPenWithSuplements : HoldingPen
    {
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            var unitType = commandWords[1];
            var unitID = commandWords[2];
            Unit unitToBeAdded = null;
            switch (unitType)
            {
                case "Marine":
                    unitToBeAdded = new Marine(unitID);
                    break;

                case "Parasite":
                    unitToBeAdded = new Parasite(unitID);
                    break;

                case "Queen":
                    unitToBeAdded = new Queen(unitID);
                    break;

                case "Tank":
                    unitToBeAdded = new Tank(unitID);
                    break;

                default: base.ExecuteInsertUnitCommand(commandWords); break;
            }
            if (unitToBeAdded != null)
            {
                this.InsertUnit(unitToBeAdded);
            }
        }
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            var supplementType = commandWords[1];
            ISupplement supplement = null ;
            switch (supplementType) 
            {
                case "PowerCatalyst": supplement = new PowerCatalyst(); break;
                case "HealthCatalyst": supplement = new HealthCatalyst(); break;
                case "AggressionCatalyst": supplement = new AggressionCatalyst(); break;
                case "Weapon": supplement = new Weapon();  break;
                default:
                    break;
            }

            var unitID = commandWords[2];
            var unit = this.GetUnit(unitID);
            if (unit != null)
            {
                unit.AddSupplement(supplement);
            }
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            if (interaction.InteractionType == InteractionType.Infest)
            {
                var unit = this.GetUnit(interaction.TargetUnit.Id);
                unit.AddSupplement(new InfestationSpores());
            }
            else
            {
                base.ProcessSingleInteraction(interaction);
            }
        }
    }
}
