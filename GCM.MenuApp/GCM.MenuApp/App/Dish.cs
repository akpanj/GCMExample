using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCM.MenuApp.App
{
    public abstract class Dish
    {
        private bool IsMorning;
        private int NumberOfitems;

        protected Dish(bool isMorning, int numberOfItems)
        {
            IsMorning = isMorning;
            NumberOfitems = numberOfItems;
        }

        protected Dish()
        {
            IsMorning = false;
            NumberOfitems = 0;
        }

        protected bool GetIsMorning()
        {
            return IsMorning;
        }

        protected int GetNumberOfItems()
        {
            return NumberOfitems;
        }

        protected string GetFormattedItems()
        {
            return String.Format("(x{0})", NumberOfitems.ToString());
        }
        abstract public string Print();

    }
}
