using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCM.MenuApp.App
{
    public class UnknownDish : Dish
    {
        public UnknownDish(){}

        public override string Print()
        {
            return Constant.Constants.ERROR;
        }
    }
}
