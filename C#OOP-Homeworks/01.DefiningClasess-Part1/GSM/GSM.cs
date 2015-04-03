﻿using System.Dynamic;
using System.Xml;

namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class GSM
    {
        public static string IPhone4SInfo = "iPhone 4S is a phone that has been released in 2011 with iOS version 5.0. Now iPhone" +
                                  "4S supports the newest iOS version (8.1) and still performs pretty well and fluent.";
        private const byte MIN_MODEL_LENGTH = 1;
        private const byte MAX_MODEL_LENGTH = 50;
        private const byte MIN_MANUFACTURER_LENGTH = 1;
        private const byte MAX_MANUFACTURER_LENGTH = 30;
        private Battery battery;
        private Display display;
        private string model;
        private string manufacturer;
        private string owner;
        private int price;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.PhoneBattery = battery;
        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.PhoneBattery = battery;
            this.PhoneDisplay = display;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (IsLengthValid(value, MAX_MODEL_LENGTH))
                {
                    this.model = value;
                }
                else
                    throw new ArgumentException(
                        string.Format("Invalid phone model! Model length have to be between {0} and {1} characters",
                            MIN_MODEL_LENGTH, MAX_MODEL_LENGTH));
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (IsLengthValid(value, MAX_MANUFACTURER_LENGTH))
                {
                    this.manufacturer = value;
                }
                else
                    throw new ArgumentException(
                        string.Format(
                            "Invalid manufacturer! Manufacturer length have to be between {0} and {1} characters",
                            MIN_MANUFACTURER_LENGTH, MAX_MANUFACTURER_LENGTH));
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public Battery PhoneBattery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display PhoneDisplay
        {
            get { return this.display; }
            set { this.display = value; }
        }

        private bool IsLengthValid(string str, int maxLength)
        {
            if (str.Length > maxLength || str.Length == 0)
                return false;
            else
                return true;
        }

        public override string ToString()
        {
            string model = Model.ToString();
            string manufacturer = Manufacturer.ToString();
            string price = Price.ToString();

            return model + " " + manufacturer + " " + price + " " + IPhone4SInfo;
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCalls(Call call)
        {
            int index = callHistory.IndexOf(call);
            if (index != -1)
            {
                this.callHistory.RemoveAt(index);
            }
        }

        public void ClearCallHistory()
        {
            this.callHistory = new List<Call>();
        }

        public double CalculateTotalPrice(double pricePerMinute)
        {
            double spentMoney = 0.0;
            double entireDuration = 0.0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                entireDuration += CallHistory[i].Duration;
            }
            spentMoney += (entireDuration * pricePerMinute);
            return spentMoney;
        }
    }
}
