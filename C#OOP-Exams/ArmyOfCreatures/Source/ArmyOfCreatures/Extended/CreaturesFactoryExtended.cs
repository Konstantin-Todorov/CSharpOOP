using ArmyOfCreatures.Extended.Creatures;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Creatures;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Extended
{
    class CreaturesFactoryExtended : CreaturesFactory
    {
        public override Logic.Creatures.Creature CreateCreature(string name)
        {
            switch (name)
            {

                case "WolfRaider":
                    return new WolfRaider();
                case "Griffin":
                    return new Griffin();
                case "Goblin":
                    return new Goblin();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "AncientBehemoth":
                    return new AncientBehemoth();
                default:
                    return base.CreateCreature(name); 
            }
        }
       
    }

}
