
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;
    using WarMachines.Common;

    public class Pilot : IPilot
    {
        //fields:
        private string name;
        private ICollection<IMachine> machines;

        //constructor:
        public Pilot(string name)
        {
            this.Name = name;
            this.Machines = new List<IMachine>();
        }

        //properties:
        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.ValidateName(value, "Null or empty name cannot be added!");
                this.name = value;
            }
        }
        public ICollection<IMachine> Machines
        {
            get { return this.machines; }
            set { this.machines = value; }
        }

        
        //interface methods:
        public void AddMachine(IMachine machine)
        {
            Validator.ValidateIfNull(machine, "Null machine cannot be added!");
            this.Machines.Add(machine);
        }

        public string Report()
        {
            //sort machines when reporting
            var sortedMachines = this.machines.OrderBy(m => m.HealthPoints)
                                              .ThenBy(m => m.Name);
            var machinesCount = this.machines.Count;
            string machCountsString = string.Empty;
            if (machinesCount > 0)
            {
                machCountsString = machinesCount.ToString();
            }
            else
            {
                machCountsString = "no machines";
            }

            string machSuffix = string.Empty;
            if(machinesCount == 1)
            {
                machSuffix = "machine";
            }
            else if(machinesCount > 1)
            {
                machSuffix = "machines";
            }

            var report = new StringBuilder();
            report.AppendLine(this.Name + " - " + machCountsString + " " + machSuffix);

            foreach(var machine in sortedMachines)
            {
                report.Append(machine.ToString());
            }
            return report.ToString().Trim();
        }

        
    }
}
