using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart_1
{
    public class Call
    {
        //fields
        public DateTime date;
        public string phoneNumber;
        public int duration;
       
        //properties
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
       
        //constructors
        public Call()
        {

        }

        public Call(DateTime date, string phoneNumber, int duration)
        {
            this.date = date;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }

        //methods
        public string DisplayCallInfo(Call call)
        {
            string info = string.Empty;
            StringBuilder infoBuild = new StringBuilder();
            string toDate = this.date.ToString();
            string durationString = this.duration.ToString();
            infoBuild.Append(toDate + ", ");
            infoBuild.Append(this.phoneNumber + ", ");
            infoBuild.Append(durationString + " sec");
            info = infoBuild.ToString();
            return info;
        }

    }
}
