using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart_1
{
    public enum ManufacturerCo
    {
        Apple, Microsoft, HP, Samsung, Nokia, Sony, LG, HTC, Google, Motorola
    }
    public class GSM //1.Define class
    {
        //fields:
        public static GSM iPhone4S = new GSM( "iPhone4S",
            ManufacturerCo.Apple,
            350,
            new Battery(BatteryType.Li_Ion, 12, 8),
            new Display(3.5, 1600)
            );
        private string model;
        private ManufacturerCo manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        public List<Call> callHistory = new List<Call>();


        //5. properties:
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public ManufacturerCo Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery GSMBattery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display GSMDisplay
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        //2. constructors:
        public GSM(string model, ManufacturerCo manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public GSM(string model, ManufacturerCo manufacturer, double price, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.battery = battery;
            this.display = display;
            
        }

        public GSM(string model, ManufacturerCo manufacturer, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
        }

        public GSM(string model, ManufacturerCo manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        //4. methods
        public string DisplayInfo(GSM phone)
        {
            StringBuilder infoBuild = new StringBuilder();
            if (phone.Manufacturer != null)
            {
                infoBuild.Append(phone.Manufacturer + "\n");
            }
            if (phone.Model != null)
            {
                infoBuild.Append(phone.Model + "\n");
            }
            if (phone.Price != 0)
            {
                infoBuild.Append("price: $" + phone.Price +"\n");
            }
            if (phone.Owner != null)
            {
                infoBuild.Append(phone.Owner + "\n");
            }
            if (phone.GSMBattery != null)
            {
                infoBuild.Append(phone.battery.DisplayBatteryInfo(GSMBattery) + "\n");
            }
            if (phone.GSMDisplay != null)
            {
                infoBuild.Append(phone.display.DisplayDisplayInfo(GSMDisplay) + "\n");
            }
            string info;
            if (infoBuild != null)
            {
                 info = infoBuild.ToString();
            }
            else
            {
                info = "There is no information about this phone.";
            }

            return info;
        }

        public void AddCall (Call call)
        {
            callHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
           

            if (!this.callHistory.Contains(call))
            {
                throw new ArgumentException("There no such performed call in your history.");
            }
            else
            {
                callHistory.Remove(call);
            }
        }

        public void RemoveLongestCall()
        {
            int longestduration = 0;
            Call longestCall = null;
            foreach (Call calls in callHistory)
            {
                if (calls.duration > longestduration)
                {
                    longestduration = calls.duration;
                    longestCall = calls;
                }
            }
            callHistory.Remove(longestCall);
        }

        public void DisplayHistory(GSM phone)
        {
            StringBuilder history = new StringBuilder();
            history.Append("Calls History:\n");
            foreach(Call call in callHistory)
            {
                string callString = call.DisplayCallInfo(call);
                history.Append(callString + "\n");
            }

           Console.WriteLine(history.ToString());
        }
        public void ClearHistory ()
        {
            this.callHistory.Clear();
        }

        public decimal CallsPrice()
        {
            decimal pricePerMinute = 0.37m;
            decimal totalPrice = 0m;
            foreach(Call call in this.callHistory)
            {
                totalPrice += pricePerMinute * call.Duration / 60;
            }

            return totalPrice;
        }



    }
}
