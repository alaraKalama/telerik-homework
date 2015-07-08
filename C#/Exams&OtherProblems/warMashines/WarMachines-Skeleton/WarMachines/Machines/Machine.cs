namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using WarMachines.Interfaces;
    using WarMachines.Common;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        protected Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.ValidateName(value, "Null ot empty name cannot be added!");
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                Validator.ValidateIfNull(value, "Null pilot cannot be created!");
                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints {get; protected set;}
       

        public IList<string> Targets
        {
           get
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            Validator.ValidateName(target);
            this.targets.Add(target);
        }

        public override string ToString()
        {
            var targetsAsString = this.targets.Count > 0 ? String.Join(", ", this.targets) : "None";
            StringBuilder result = new StringBuilder();
            result.AppendLine("- " + this.Name);
            result.AppendLine(" *Type: " + this.GetType().Name);
            result.AppendLine(" *Health: " + this.HealthPoints);
            result.AppendLine(" *Attack: " + this.AttackPoints);
            result.AppendLine(" *Defense: " + this.DefensePoints);
            result.AppendLine(" *Targets: " + targetsAsString);

            return result.ToString();
        }
    }
}
