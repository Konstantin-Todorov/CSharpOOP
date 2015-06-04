namespace WarMachines.Machines
{
    using System;
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        public Machine(string name, double healthPoints, double atttackPoints, double defencePoints, IPilot pilot)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;
            this.targets = new List<string>();
            this.Pilot = pilot;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
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
                //if (value == null)
                //{
                //    throw new ArgumentNullException();
                //}
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                //if (value < 0)
                //{
                //    throw new ArgumentNullException();
                //}
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            set 
            {
            //    if (value < 0)
            //    {
            //        throw new ArgumentNullException();   
            //    }
                  this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
            set 
            {
                //if (value < 0)
                //{
                //    throw new ArgumentNullException();
                //}
                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("- {0}", this.Name).AppendLine();
            result.AppendFormat(" *Type: {0}", this.GetType().Name).AppendLine();
            result.AppendFormat(" *Health: {0}", this.HealthPoints).AppendLine();
            result.AppendFormat(" *Attack: {0}", this.AttackPoints).AppendLine();
            result.AppendFormat(" *Defense: {0}", this.DefensePoints).AppendLine();
            result.AppendFormat(" *Targets: {0}", this.Targets.Count == 0 ? "None" : string.Join(", ", this.Targets)).AppendLine();

            return result.ToString();
        }
    }
}
