using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    class GSM
    {
        public const double PRICE_PER_MINUTE = 0.37;
        //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        private static GSM iphone4s;
        private decimal? price;
        private string owner;
        private string manufacturer;
        private string model;
        private Battery batteryType;
        private Display displayType;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, double price):this(model,manufacturer)
        {
            this.Price = (decimal)price;
        }
        public GSM(string model, string manufacturer, double price, string owner):this(model,manufacturer,price)
        {
            this.Owner = owner;
        }
        public GSM(string model, string manufacturer, double price, string owner, Battery batteryType)
            : this(model, manufacturer, price,owner)
        {
            this.batteryType = batteryType;
        }
        public GSM(string model, string manufacturer, double price, string owner, Battery batteryType, Display displayType)
            : this(model, manufacturer, price, owner,batteryType)
        {
            this.displayType = displayType;
        }

        public static GSM Iphone4s
        {
            get
            {
                return iphone4s = new GSM("Iphone4s", "Apple", 655.5, "AppleINC", new Battery(BatteryModel.LiPoly, 50, 100), new Display(15, 16000000));
            }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value > 0) { this.price = value; }
                else
                {
                    throw new IndexOutOfRangeException("The price must be positive number.");
                }
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
        public Display DisplayType
        {
            get { return this.displayType; }
            set { this.displayType = value; }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }
        public void RemoveCall(Call call)
        {
            this.callHistory.Remove(call);
        }
        public void ClearHistory(Call call)
        {
            this.callHistory.Clear();
        }
        public decimal CalculatePrice(double price)
        {
            int sumOfSeconds = 0;
            foreach (var item in CallHistory)
            {
                sumOfSeconds += item.Seconds;
            }
            decimal result = (decimal)price * sumOfSeconds;
            return result;
        }

        public override string ToString()
        {
            if (this.BatteryType != null && this.DisplayType != null)
            {
                return String.Format("Model: {0}\n" +
                                    "Manufacturer: {1}\n" +
                                    "Price: {2}\n" +
                                    "Owner: {3}\n" +
                                    "Battery: \n{4}\n" +
                                    "Display: \n{5}\n",
                                    this.Model, this.Manufacturer, this.Price, this.Owner,
                                    this.BatteryType.ToString(), this.DisplayType.ToString());
            }
            else if (this.BatteryType == null && this.DisplayType != null)
            {
                return String.Format("Model: {0}\n" +
                                    "Manufacturer: {1}\n" +
                                    "Price: {2}\n" +
                                    "Owner: {3}\n" +
                                    "Display: \n{4}\n",
                                    this.Model, this.Manufacturer, this.Price, this.Owner, this.DisplayType);
            }
            else if (this.BatteryType != null && this.DisplayType == null)
            {
                return String.Format("Model: {0}\n" +
                                    "Manufacturer: {1}\n" +
                                    "Price: {2}\n" +
                                    "Owner: {3}\n" +
                                    "Battery: \n{4}\n",
                                    this.Model, this.Manufacturer, this.Price, this.Owner, this.BatteryType);
            }
            else
            {
                return String.Format("Model: {0}\n" +
                    "Manufacturer: {1}\n" +
                    "Price: {2}\n" +
                    "Owner: {3}\n",
                    this.Model, this.Manufacturer, this.Price, this.Owner);
            }

        }

    }
}
