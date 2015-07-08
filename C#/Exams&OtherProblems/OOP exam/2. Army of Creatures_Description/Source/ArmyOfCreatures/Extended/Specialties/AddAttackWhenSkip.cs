

namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Specialties;

    public class AddAttackWhenSkip : Specialty
    {
        private int attackToAdd;

        public AddAttackWhenSkip(int points)
        {
            this.AttackToAdd = points;
        }

        public int AttackToAdd
        {
            get { return this.attackToAdd; }
            private set
            {
                Validator.ValidateRange(value, 0, 10, "Attack points to add must be between 1 and 10!");
                
                this.attackToAdd = value;
            }
        }

        public override void ApplyOnSkip(Logic.Battles.ICreaturesInBattle skipCreature)
        {
            Validator.CheckIfNull(skipCreature);
            skipCreature.PermanentAttack += this.attackToAdd;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.AttackToAdd);
        }
    }
}
