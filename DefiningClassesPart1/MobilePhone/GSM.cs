using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        private static GSM iPhone4S;

        public GSM (string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM (string model, string manufacturer, double price) : this(model, manufacturer)
        {
            this.price = price;
        }

        public GSM (string model, string manufacturer, double price, Battery battery, Display display) : this(model, manufacturer, price)
        {
            this.battery = battery;
            this.display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The model cannot be null or empty");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the manufacturer cannot be null or empty");
                }
                this.manufacturer = value;
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price cannot be less than zero");
                }
                this.price = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return new GSM("IPhone 4S", "Apple", 199, new Battery("1432", 199, 200, BatteryType.LiIon), new Display (3.5, 16000000));
            }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public void AddCall (Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall (Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearHistory()
        {
            CallHistory.Clear();
        }


        public double CallPrice(double pricePerMinute)
        {
            double totalPrice = 0;
            double durationInMinutes = 0;
            double callPrice = 0;
            foreach (var call in callHistory)
            {
                int duration = call.Duration;
                durationInMinutes = (double)(duration) / 60;
                callPrice = pricePerMinute * durationInMinutes;
                totalPrice += callPrice;
            }
            return totalPrice;
        }
        public override string ToString()
        {
            return String.Format("Manufacturer: {0}\nModel: {1}\nPrice: {2}\nBattery: {3}\nDisplay: {4}", manufacturer, model, price, battery, display);
        }

    }
}
