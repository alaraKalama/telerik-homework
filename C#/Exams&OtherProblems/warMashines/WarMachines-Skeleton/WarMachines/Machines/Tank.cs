using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;
    using WarMachines.Machines;
    public class Tank : Machine, IMachine, ITank
    {
        private const double TankInitialHealthPoints = 100;
        private const double AttackPointsToSubstractInDefenceMode = 40;
        private const int DefencePointsToAddInDefenceMode = 30;

        //constructor
        public Tank(string name, double attackPoints, double defensePoints)
            :base (name, attackPoints, defensePoints, TankInitialHealthPoints)
        {
            this.ToggleDefenseMode();
        }


        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if(this.DefenseMode)
            {
                this.AttackPoints -= AttackPointsToSubstractInDefenceMode;
                this.DefensePoints += DefencePointsToAddInDefenceMode;
            }
            else
            {
                this.AttackPoints += AttackPointsToSubstractInDefenceMode;
                this.DefensePoints -= DefencePointsToAddInDefenceMode;
            }
        }

        public override string ToString()
        {
            var defenseMode = this.DefenseMode ? "ON" : "OFF";
            var baseString = base.ToString();
            var result = new StringBuilder();
            result.Append(baseString);
            result.AppendLine(" *Defense: " + defenseMode);
            return result.ToString();
        }
    }
}
