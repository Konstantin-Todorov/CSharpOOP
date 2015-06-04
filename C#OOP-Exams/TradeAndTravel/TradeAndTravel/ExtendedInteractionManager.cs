namespace TradeAndTravel
{
    using System.Linq;
    using System.Collections.Generic;

    public class ExtendedInteractionManager : InteractionManager
    {
        public ExtendedInteractionManager() : base()
        {

        }
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    return new Weapon(itemNameString, itemLocation);
                case "wood":
                    return new Wood(itemNameString, itemLocation);
                case "iron":
                    return new Iron(itemNameString, itemLocation);
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "mine":
                    return new Town(locationName);
                case "forest":
                    return new Forest(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {

            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherInteraction(actor,commandWords[2]);
                    break;
                case"craft":
                    this.HandleCraftInteraction(actor, commandWords[2] , commandWords[3]);
                    break;
                    base.HandlePersonCommand(commandWords, actor);
            }
        }

        public void HandleCraftInteraction(Person actor, string itemTypeString,string itemName)
        {
            switch (itemTypeString)
            {
                case "weapon": this.HendleWeaponCrafting(actor, itemName);
                    break;
                case "armor": this.HendleArmorCrafting(actor, itemName);
                    break;
                default:
                    break;
            }
        }

        public void HendleWeaponCrafting(Person actor, string itemName)
        {
            var itemsRequired = new List<ItemType> { ItemType.Iron, ItemType.Wood };

            itemsRequired.All(i => actor.HasItemInInventor(i));

            if (itemsRequired.All(i => actor.HasItemInInventor(i)))//actor.HasItemInInventor(ItemType.Iron) && actor.HasItemInInventor(ItemType.Wood))
            {
                this.AddToPerson(actor, new Weapon(itemName));
            }
        }

        public void HendleArmorCrafting(Person actor, string itemName)
        {
            var itemsRequiered = ItemType.Iron;
            if (actor.HasItemInInventor(itemsRequiered))
            {
                this.AddToPerson(actor, new Armor(itemName));
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant": 
                    return new Merchant(personNameString,personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
        }

        public void HandleGatherInteraction(Person actor, string itemName)
        {
            if (actor.Location is IGatheringLocation)
            {
                var gatheringLocation = actor.Location as IGatheringLocation;
                if (actor.HasItemInInventor(gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(itemName));
                }
            }

            //if (actor.Location.LocationType == LocationType.Forest && actor.ListInventory().Any(i => i.ItemType == ItemType.Weapon))
            //{
            //    this.AddToPerson(actor, new Wood(itemName));
            //}
            //if (actor.Location.LocationType == LocationType.Mine && actor.ListInventory().Any(i => i.ItemType == ItemType.Armor))
            //{
            //    this.AddToPerson(actor, new Iron(itemName));
            //}
        }
    }
}
