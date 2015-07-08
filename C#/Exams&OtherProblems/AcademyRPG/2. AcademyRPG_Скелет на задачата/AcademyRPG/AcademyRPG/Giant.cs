using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private const int giantInitialAttackPoints = 150;
        private const int giantInitialDefensePoints = 80;
        private const int giantInitialHitPoints = 200;
        private const int attackPointsToAddWhenGatherStone = 100;

        private int attackPoint;
        private bool GatheredStone;

        public Giant(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = giantInitialHitPoints;
            this.attackPoint = giantInitialAttackPoints;
            GatheredStone = false;
        }

        public int AttackPoints
        {
            get { return this.attackPoint; }
        }

        public int DefensePoints
        {
            get { return giantInitialDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {

            if (resource.Type == ResourceType.Stone)
            {
                if (!GatheredStone)
                {
                    GatheredStone = true;
                    this.attackPoint += attackPointsToAddWhenGatherStone;
                }
                return true;
            }

            return false;
        }
    }
}
