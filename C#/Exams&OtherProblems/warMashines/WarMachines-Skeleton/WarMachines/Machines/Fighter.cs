using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public class Fighter : Machine, IMachine, IFighter
    {
        public const double FighterInitialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            :base (name, attackPoints, defensePoints, FighterInitialHealthPoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }
       

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var stealthMode = this.StealthMode ? "ON" : "OFF";
            var baseString = base.ToString();
            var result = new StringBuilder();
            result.Append(baseString);
            result.AppendLine(" *Stealth: " + stealthMode);
            return result.ToString();
        }
    }
}
