using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCM.MenuApp.App.Constant;

namespace GCM.MenuApp.App
{
    public class Dessert : Dish
    {
        public Dessert(bool isMorning, int numberOfItems) : base(isMorning, numberOfItems) { }
        
        public override string Print()
        {
            if (base.GetNumberOfItems() == 0)
                return "";

            if (base.GetIsMorning())
                { return Constants.ERROR; }
            else
            { return ((base.GetNumberOfItems() > 1) ? Constants.ERROR : Constants.CAKE); }     
        }
    }
}
