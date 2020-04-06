using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using Xamarin.Forms;

namespace HW6
{
    public class PageDataViewModel
    {
        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }
        public Type Type { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {
                new PageDataViewModel(typeof(ClockPage), "Clock", "Stack Layout Clock"),
                new PageDataViewModel(typeof(ColorGrid), "ColorGrid", "Grid of colors"),
                new PageDataViewModel(typeof(TargetPage), "Moving Button", "Relative Layout")
            };
        }
        public static IList<PageDataViewModel> All { private set; get; }

    }
    
}
