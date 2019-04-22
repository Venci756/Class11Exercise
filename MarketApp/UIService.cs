using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp
{
    public class UIService
    {
        // private LogicService _logicService = new LogicService();
        public int LoginChoice()
        {
            int choice = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Get all items");
                Console.WriteLine("2) Filter Items by Company or Type");
                Console.WriteLine("3) Get items by ID");
                Console.WriteLine("4) Get items in price range");
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (isNumber && choice >= 1 && choice <= 4)
                {
                    break;
                }
                Console.WriteLine("The input should be number and from the options that are given. Press anything to try again...");
                Console.ReadLine();
            }
            return choice;
        }
    }
}
