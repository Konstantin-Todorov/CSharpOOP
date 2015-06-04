namespace TradeAndTravel
{
    using System.Linq;
    public static class PersonExtensions
    {
        public static bool HasItemInInventor(this Person actor, ItemType itemType )
        {
            return actor.ListInventory().Any(i => i.ItemType == itemType);
        }
    }
}
