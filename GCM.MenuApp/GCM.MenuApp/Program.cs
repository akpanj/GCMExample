using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCM.MenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine;
            App.ProcessMenuFactory processMenu;
            Console.WriteLine (" Please enter the input as (morning,1,2,3,4) ");
            inputLine = Console.ReadLine();
            do 
            {
                if (ValidateInput(inputLine))
                {
                    processMenu = new App.ProcessMenuFactory(inputLine);
                    Console.WriteLine(processMenu.GetMenu());
                }
                else {
                    Console.WriteLine("Invalid Input");

                }
                Console.WriteLine();
                Console.WriteLine("Please enter the input as (morning,1,3,4)");
                inputLine = Console.ReadLine();
 
            } while(!String.IsNullOrEmpty(inputLine));

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
        private static bool ValidateInput(string input)
        {
            var i = input.IndexOf(',');
            
            var TimeOfDay = (i == -1) ? input : input.Substring(0, i).ToLower(); //get time of day
            var count = input.Count(c => c == ',');
 
            if (((TimeOfDay == "morning") || (TimeOfDay == "night")) && count > 0)
                return true;
            return false;
        }
    }
}
