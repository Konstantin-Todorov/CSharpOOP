namespace WarMachines.Machines
{
    using Interfaces;
    using System.Collections.Generic;
    using System;
    using System.Text;
    using System.Linq;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string name )
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name=value; 
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();

            report.AppendFormat("{0} - {1}", this.Name, this.machines.Count == 0 ? "no machine" 
                                                        : this.machines.Count == 1 ? "1 machine" 
                                                        : this.machines.Count + " machines")
                                                        .AppendLine();

            var orderMachines = this.machines.OrderBy(m => m.HealthPoints)
                                              .ThenBy(m => m.Name);
            
            foreach (var machine in machines)
            {
                report.AppendLine(machine.ToString());
            }

            return report.ToString().Trim();
        }
    }
}
