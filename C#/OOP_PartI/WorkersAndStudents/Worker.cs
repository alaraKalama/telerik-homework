using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersAndStudents
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
 
        public Worker(string firstname, string lastname, decimal weekSalary, decimal workHoursPerDay)
            :base(firstname, lastname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set 
            {
                ValidateSalary(value);
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set 
            {
                ValidateHours(value);
                this.workHoursPerDay = value; 
            }
        }
            
        private void ValidateSalary(decimal weekSalary)
        {
            if(weekSalary <= 0)
            {
                throw new ArgumentException("Slavery is forbidden!");
            }
        }

        private void ValidateHours(decimal workHours)
        {
            if(workHours > 8)
            {
                throw new ArgumentException("This is overtime work.");
            }
        }

        public decimal MoneyPerHour()
        {
            return this.weekSalary / (5 * this.workHoursPerDay);
        }

        public override string ToString()
        {
           // return this.Fullname + " - " + this.MoneyPerHour().ToString();
            return String.Format("{0} - {1:F2} BGN/hour", this.Fullname, this.MoneyPerHour());
        }
        
    }
}
