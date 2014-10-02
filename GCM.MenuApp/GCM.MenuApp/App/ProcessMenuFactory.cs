using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCM.MenuApp.App
{
    public class ProcessMenuFactory
    {
        private List<string> DishesList;
        private string TimeOfDay;
        private bool IsMorning = false;
        private const char Delimiter = ',';

        public ProcessMenuFactory(string input)
        {
            var i = input.IndexOf(Delimiter);

            TimeOfDay = (i == -1) ? input : input.Substring(0, i).ToLower(); //get time of day

            DishesList = input.Substring(i + 1).Split(Delimiter).ToList();

        }

        public string GetMenu()
        {
            if (String.IsNullOrEmpty(DishesList[0]))
                return "error";

            List<App.Dish> dishes = new List<Dish>();
            if (TimeOfDay == App.Constant.Constants.MORNING)
                IsMorning = true;

            // Sort List with group by to get count of items
            try
            {
                //Create new List to use Group By and Sort
                var sortedList = DishesList.GroupBy(g => g)
                 .Select(g => new
                 {
                     dishId = Int32.Parse(g.Key),
                     count = g.Count()
                 })
                 .OrderBy(x => x.dishId);

                foreach (var item in sortedList)
                {
                    if (item.dishId == DishType.Entree)
                        dishes.Add(new Entree(IsMorning, item.count));
                    else if (item.dishId == DishType.Side)
                        dishes.Add(new Side(IsMorning, item.count));
                    else if (item.dishId == DishType.Drink)
                        dishes.Add(new Drink(IsMorning, item.count));
                    else if (item.dishId == DishType.Dessert)
                        dishes.Add(new Dessert(IsMorning, item.count));
                    else dishes.Add(new UnknownDish());
                }
            }
            catch (Exception)
            {
                return "Not a valid input";
            }

            return PrintDish(dishes);
        }

        //Print result
        private string PrintDish(List<App.Dish> dishes)
        {
            StringBuilder returnString = new StringBuilder();

            foreach (App.Dish x in dishes)
            {

                if (returnString.Length > 0)
                {
                    returnString.Append(Delimiter);
                    returnString.Append(" ");
                }

                returnString.Append(x.Print());
                if (x.Print().IndexOf(App.Constant.Constants.ERROR) > 0)
                    break;


            }

            return returnString.ToString();
        }

    }
}
