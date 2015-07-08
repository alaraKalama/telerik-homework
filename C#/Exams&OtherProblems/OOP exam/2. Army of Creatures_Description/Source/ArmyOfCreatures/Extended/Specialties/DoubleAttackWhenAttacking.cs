

namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Specialties;

    public class DoubleAttackWhenAttacking : SpecialityExtension
    {
        private int rounds;

        public DoubleAttackWhenAttacking(int rounds)
        {
            this.Rounds = rounds;
        }

        public int Rounds
        {
            get { return this.rounds; }
            set
            {
               // Validator.ValidateRange(value, 0);
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.rounds = value;
            }
        }

        public override void ApplyWhenAttacking(Logic.Battles.ICreaturesInBattle attackerWithSpecialty, Logic.Battles.ICreaturesInBattle defender)
        {
            Validator.CheckIfNull(attackerWithSpecialty);
            Validator.CheckIfNull(defender);

            if(this.Rounds < 0)
            {
                return;
            }
            this.rounds--;
        }

        public override void ChangeAttackWhenAttacking(Logic.Battles.ICreaturesInBattle attackerWithSpecialty, Logic.Battles.ICreaturesInBattle defender)
        {
            Validator.CheckIfNull(attackerWithSpecialty);
            Validator.CheckIfNull(defender);
            attackerWithSpecialty.CurrentAttack *= 2;
            base.ChangeAttackWhenAttacking(attackerWithSpecialty, defender);
        }

         

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
