using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace HW6
{
    class ClockVM
    {
        private DateTime dateTime;
        

        public event PropertyChangedEventHandler PropertyChanged;

        public ClockVM()
        {
            this.dateTime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                this.dateTime = DateTime.Now;
                
                return true;

            });
        }

        public DateTime DateTime
        {
            set
            {
                if (dateTime != value)
                {
                    dateTime = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
            get
            {
                return dateTime;
            }
        }

        //public DateTime Hour
        //{
        //    set
        //    {
        //        if (dateTime != value)
        //        {
        //            dateTime = value;

        //            if (PropertyChanged != null)
        //            {
        //                PropertyChanged(this, new PropertyChangedEventArgs("Hour"));
        //            }
        //        }
        //    }
        //    get
        //    {
        //        return dateTime.Hour;
        //    }
        //}
        //public int Minute
        //{
        //    set
        //    {
        //        if (minute != value)
        //        {
        //            minute = value;

        //            if (PropertyChanged != null)
        //            {
        //                PropertyChanged(this, new PropertyChangedEventArgs("Minute"));
        //            }
        //        }
        //    }
        //    get
        //    {
        //        return minute;
        //    }
        //}
        //public int Second
        //{
        //    set
        //    {
        //        if (second != value)
        //        {
        //            second = value;

        //            if (PropertyChanged != null)
        //            {
        //                PropertyChanged(this, new PropertyChangedEventArgs("Second"));
        //            }
        //        }
        //    }
        //    get
        //    {
        //        return second;
        //    }
        //}
    }

}

