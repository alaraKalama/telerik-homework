using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class InteractionManagerExtended : InteractionManager
    {
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
                    return new Mine(locationName);
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
                    this.HandleGatherInteraction(actor, commandWords[2]);
                        break;
                case "craft":
                    this.HandleCraftCommand(actor, commandWords[2], commandWords[3]);
                    break;
                
            }
            base.HandlePersonCommand(commandWords, actor);
        }

        private void HandleCraftCommand(Person actor, string itemType, string name)
        {
            switch (itemType)
            {
                case "weapon":
                    this.HandleWeaponCrafting(actor, name);
                    break;
                case "armour":
                    this.HandleArmourCrafting(actor, name);
                    break;
            }

        }

        private void HandleArmourCrafting(Person actor, string name)
        {
            //there is some stupid shit static method that nobody can use in Armour Class... :/
            var requiredItems = ItemType.Iron;
            if (actor.HasItem(requiredItems))
            {
                this.AddToPerson(actor, new Armor(name));
            }
        }

        private void HandleWeaponCrafting(Person actor, string name)
        {
            var requiredItems = new List<ItemType> { ItemType.Wood, ItemType.Armor };
            if(actor.HasItem(requiredItems[0]) && actor.HasItem(requiredItems[1]))
            {
                this.AddToPerson(actor, new Weapon(name));
            }

        }

        private void HandleGatherInteraction(Person actor, string name)
        {
            if(actor.Location is IGatheringLocation)
            {
                var gatherLoc = actor.Location as IGatheringLocation;
                if (actor.HasItem(gatherLoc.RequiredItem))
                {
                    this.AddToPerson(actor, gatherLoc.ProduceItem(name));
                }
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch(personTypeString)
            {
                case "merchant":
                    return new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
            
        }
    }


}
