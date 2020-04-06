using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using DateTime = System.DateTime;

namespace HW6
{
    class ColorVM
    {
        
        private Color rndColor;
        private Random rnd = new Random();
        //private DateTime dateTime;

        //public event PropertyChangedEventHandler PropertyChanged;
        

        public ColorVM()
        {
            //this.dateTime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                
                this.rndColor = Color.Aqua;
                return true;
            });
        }

        public Color RandColor
        {
            set
            {
                
                rndColor =  Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));


            }
            get { return Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)); }
        }
    }
}
