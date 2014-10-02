using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCM.MenuApp.App.Constant;

namespace GCM.MenuApp.App
{
    public class Entree : Dish
    {
        public Entree(bool isMorning, int numberOfItems) : base(isMorning, numberOfItems) { }  // uses abstract constructor

        public override string Print()
        {
            if (base.GetNumberOfItems() == 0)
                return "";

            if (base.GetIsMorning())
            { return ((base.GetNumberOfItems() > 1) ? Constants.EGGSERROR : Constants.EGGS); }
            else
            { return ((base.GetNumberOfItems() > 1) ? Constants.STEAKERROR : Constants.STEAK); }

        }
    }
}
