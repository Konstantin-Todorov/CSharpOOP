namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        private const int workDaysInWeek = 5;

        private int weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, int weekSalary, int weekHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.workHoursPerDay = value;
            }
        }

        public int WeekSalary
        {
            get { return this.weekSalary; }
            private set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.weekSalary = value; 
            }
        }
        public double MoneyPerHour()
        {
            double moneyPerDay = this.WeekSalary / workDaysInWeek;
            double moneyPerHour = moneyPerDay / this.WorkHoursPerDay;
            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} \nWeek Salary : {2} \nWork Hours Per Day : {3}"
                                , this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
