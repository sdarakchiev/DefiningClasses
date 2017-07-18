using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Call
    {
        private string dialedNumber;
        private DateTime dateTime;

        //private string date = DateTime.Now.Date.ToString();
        //private string time = DateTime.Now.ToString("hh:mm:ss");
        private int duration;

        public Call(string dialedNumber, DateTime dateTime, int duration)
        {
            this.dialedNumber = dialedNumber;
            this.dateTime = dateTime;
            this.duration = duration;
        }

        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            set
            {
                if (dialedNumber.Length < 1 && dialedNumber.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Invalid number");
                }
                this.dialedNumber = value;
            }
        }
        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }
        
        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input");
                }
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Dialed number: {0}; Date: {1}; Duration: {3}", dialedNumber, dateTime, duration);
        }
    }
}
