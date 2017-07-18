using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        public Battery (string model)
        {
            this.model = model;
        }
        public Battery (string model, int hoursIdle, int hoursTalk, BatteryType batteryType) : this (model)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Te model cannot be null");
                }
                this.model = value;
            }
        }
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The hours idle should be positive number");
                }
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The hours talk should be positive number");
                    this.hoursTalk = value;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("Battery type: {0}; Hours idle: {1}; Hours talk: {2}", batteryType, hoursIdle, hoursTalk);
        }
    }
}
