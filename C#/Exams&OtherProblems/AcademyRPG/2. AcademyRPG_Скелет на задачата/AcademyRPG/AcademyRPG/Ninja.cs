using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        private const int NinjaInitialHitPoint = 1;
        private const int NinjaInitialAttackPoints = 0;
        private int attackPoints;

        public Ninja(string name, Point position, int owner)
            :base(name, position, owner)
        {
            this.attackPoints = NinjaInitialAttackPoints;
            this.HitPoints = NinjaInitialHitPoint;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {

            int maxHitPoints = availableTargets.Max(t => t.HitPoints);
            var target = availableTargets.FirstOrDefault(t => t.Owner != 0 && t.Owner != this.Owner && t.HitPoints == maxHitPoints);
           // for (int i = 0; i < availableTargets.Count; i++)
            //{
               // int maxHitPoints = 0;
                //if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                //{
                  //  if(availableTargets[i].HitPoints > maxHitPoints)
                    //{
                      //  maxHitPoints = availableTargets[i].HitPoints;
                        //return i;
                    //}
                    
              //  }
            //}
            if (target != null)
                return availableTargets.IndexOf(target);

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.attackPoints += resource.Quantity;
                return true;
            }
            else if (resource.Type == ResourceType.Stone)
            {
                this.attackPoints += (resource.Quantity * 2);
                return true;
            }

            return false;
        }
    }
}
