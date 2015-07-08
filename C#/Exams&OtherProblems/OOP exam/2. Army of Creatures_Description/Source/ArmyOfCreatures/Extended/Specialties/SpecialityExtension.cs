

namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    
    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;

    public abstract class SpecialityExtension : Specialty
    {
        public virtual void ChangeAttackWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {

        }

        
    }
}
