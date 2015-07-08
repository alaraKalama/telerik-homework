namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Extended.Creatures;
    
    class CreaturesFactoryExtended : CreaturesFactory
    {
        public override Logic.Creatures.Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "Angel":
                case "Archangel":
                case "ArchDevil":
                case "Behemoth":
                case "Devil":
                    return base.CreateCreature(name);
                case "Goblin":
                    return new Goblin();
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "WolfRaider":
                    return new WolfRaider();
                case "Griffin":
                    return new Griffin();
                case "CyclopsKing":
                    return new CyclopsKing();
                default:
                    throw new ArgumentException(
                        string.Format(CultureInfo.InvariantCulture, "Invalid creature type \"{0}\"!", name));
            }
        }
    }
}
