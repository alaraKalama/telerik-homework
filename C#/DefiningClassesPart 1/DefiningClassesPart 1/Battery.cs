using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart_1
{

    public enum BatteryType //3.
    {
        Li_Ion, NiMH, NiCd
    }

    public class Battery //1.
    {
        private BatteryType model;
        private double hoursIdle;
        private double hoursTalk;

        //5. properties:
        public BatteryType Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        //2. constructors:
        public Battery()
        {

        }

        public Battery(BatteryType model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public Battery(BatteryType model)
        {
            this.model = model;
        }

        public string DisplayBatteryInfo(Battery battery)
        {
            string info = string.Empty;
            StringBuilder infoBuild = new StringBuilder();
            infoBuild.Append("Battery:\n");
            if (battery.HoursIdle <= 0)
            {
                throw new ArgumentNullException("Hours Idle must be greater than 0.");
            }
            else if (battery.HoursIdle != null)
            {
                infoBuild.Append("Hours Idle: " + HoursIdle.ToString() + "\n");
            }

            if (battery.HoursTalk <= 0)
            {
                throw new ArgumentNullException("Hours Talk must be greater than 0.");
            }
            else if (battery.HoursTalk != null)
            {
                infoBuild.Append("Hours Talk: " + HoursTalk.ToString() + "\n");
            }

            if (battery.Model != null)
            {
                infoBuild.Append(battery.Model);
            }

            info = infoBuild.ToString();
            return info;
        }
    }
}
