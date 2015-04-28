using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    class Battery
    {
        private BatteryModel model;
        private double hoursIdle;
        private double hoursTalk;

        public Battery(BatteryModel model, double hoursIdle, double hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value > 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The idle hours must have positive value!");
                }
            }
        }
        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value > 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The talk hours must have positive value!");
                }
            }
        }
        public BatteryModel Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public override string ToString()
        {
            return String.Format("Model: {0}, Idle Hours: {1}, Talk Hours: {2}", this.Model, this.HoursIdle, this.HoursTalk);
        }
    }

    public enum BatteryModel
    {
        LiIon,
        LiPoly,
        NiMH,
        NiCd
    }
}
