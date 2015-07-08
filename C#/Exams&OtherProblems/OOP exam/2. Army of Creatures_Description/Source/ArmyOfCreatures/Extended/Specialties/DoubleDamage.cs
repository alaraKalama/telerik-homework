

namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;
    using ArmyOfCreatures.Logic.Creatures;

    public class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            this.Rounds = rounds;
        }

        public int Rounds
        {
            get { return this.rounds; }
            set
            {
                Validator.ValidateRange(value, 0, 10, "Rounds should be between 1 and 10!");
                this.rounds = value;
            }
        }

        public override decimal ChangeDamageWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty, 
            ICreaturesInBattle defender, 
            decimal currentDamage)
        {
            Validator.CheckIfNull(attackerWithSpecialty);
            Validator.CheckIfNull(defender);

            return currentDamage * 2;
        }

        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
            Validator.CheckIfNull(attackerWithSpecialty);
            Validator.CheckIfNull(defender);

            if (this.rounds <= 0)
            {
                return;
            }

            this.rounds--;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }

        
           
        
    }
}
