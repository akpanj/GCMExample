using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCM.MenuApp.App.Constant;

namespace GCM.MenuApp.App
{
    public class Side : Dish
    {
        public Side(bool isMorning, int numberOfItems) : base(isMorning, numberOfItems) { }

        public override string Print()
        {
            if (base.GetNumberOfItems() == 0)
                return "";

            if (base.GetIsMorning())
            { return ((base.GetNumberOfItems() > 1) ? Constants.TOASTERROR : Constants.TOAST); }
            else
            { return ((base.GetNumberOfItems() > 1) ? Constants.POTATO + base.GetFormattedItems() : Constants.POTATO); }
        }
    }
}
