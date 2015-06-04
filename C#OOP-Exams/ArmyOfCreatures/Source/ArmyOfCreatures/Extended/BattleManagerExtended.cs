using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended
{
    public class BattleManagerExtended : BattleManager , IBattleManager
    {
        private ICollection<ICreaturesInBattle> thirdArmtCreatures;

        public ICreaturesFactory CreaturesFactory { get; set; }

        public ILogger Logger { get; set; }


        public BattleManagerExtended(ICreaturesFactory creaturesFactory, ILogger logger)
            :base(creaturesFactory,logger)
        {
            this.CreaturesFactory = creaturesFactory;
            this.Logger = logger;
            this.thirdArmtCreatures = new List<ICreaturesInBattle>();
        }
        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            if (identifier.ArmyNumber == 3)
            {
                return this.thirdArmtCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }
            else
            {
                return base.GetByIdentifier(identifier);
            }
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            if (creaturesInBattle == null)
            {
                throw new ArgumentNullException("creaturesInBattle");
            }

            if (creatureIdentifier.ArmyNumber == 3)
            {
                this.thirdArmtCreatures.Add(creaturesInBattle);
            }
            else
            {
                 base.AddCreaturesByIdentifier(creatureIdentifier,creaturesInBattle);
            }
        }
    }
}
