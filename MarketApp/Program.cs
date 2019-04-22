using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp
{
    class Program
    {
        static void Main()
        {
            UIService uiService = new UIService();
           var choice= uiService.LoginChoice();
            if (choice == 1)
            {
                Products.ShowProducts();
            }
            if (choice == 2)
            {
                Console.WriteLine("Choose how to sort the items.");
                Console.WriteLine("1) For sorting by Company Name.");
                Console.WriteLine("2) For sorting by Price.");
                Console.WriteLine("3) For sorting by Item Type.");
                var userInputForSorting = Console.ReadLine();
                List<Food> sortedProducts;
                if (userInputForSorting == "1")
                {
                    IEnumerable<Food> query = Products.products.OrderBy(x => x.Company);
                    sortedProducts = query.ToList();
                    Console.WriteLine("Please enter the name or type of the product.");
                    var newUserInput = Console.ReadLine();
                    foreach (var item in sortedProducts)
                    {
                        if (newUserInput == item.Company || newUserInput == item.Type.ToString())
                        {
                            Console.WriteLine($"The Id is:{item.Id}.The company name is:{item.Company}. The type of food is: {item.Type}.Price {item.Price}.");


                        }
                    }
                }
                else if (userInputForSorting == "2")
                {
                    IEnumerable<Food> query = Products.products.OrderBy(x => x.Price);
                    sortedProducts = query.ToList();
                    Console.WriteLine("Please enter the name or type of the product.");
                    var newUserInput = Console.ReadLine();
                    foreach (var item in sortedProducts)
                    {
                        if (newUserInput == item.Company || newUserInput == item.Type.ToString())
                        {
                            Console.WriteLine($"The Id is:{item.Id}.The company name is:{item.Company}. The type of food is: {item.Type}.Price {item.Price}.");


                        }
                    }
                }
                else if (userInputForSorting == "3")
                {
                    Console.WriteLine("Type 1 for ascending or 2 for descending");
                    var ascOrDescUserInput = Console.ReadLine();
                    
                    IEnumerable<Food> query = Products.products.OrderByDescending(x => x.Type);
                    sortedProducts = query.ToList();
                    foreach (var item in sortedProducts)
                    {
                        Console.WriteLine($"{item.Type}");
                    }

                    //Console.WriteLine("Please enter the name or type of the product.");
                    //var newUserInput = Console.ReadLine();
                    //foreach (var item in sortedProducts)
                    //{
                    //    if (newUserInput == item.Company || newUserInput == item.Type.ToString())
                    //    {
                    //        Console.WriteLine($"The Id is:{item.Id}.The company name is:{item.Company}. The type of food is: {item.Type}.Price {item.Price}.");


                    //    }
                    //}
                }
                


                Console.WriteLine("Please enter the name or type of the product.");
                var userInput = Console.ReadLine();
                foreach (var item in Products.products)
                {
                    if(userInput== item.Company || userInput == item.Type.ToString())
                    {
                        Console.WriteLine($"The Id is:{item.Id}.The company name is:{item.Company}. The type of food is: {item.Type}.");
                    }
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Please enter the ID number of the product.");
                var userInput = Console.ReadLine();
                bool parsedInput = int.TryParse(userInput, out int parsedUserInput);
                foreach (var item in Products.products)
                {
                    if (parsedUserInput == item.Id)
                    {
                        Console.WriteLine($"The Id is:{item.Id}.The company name is:{item.Company}. The type of food is: {item.Type}.");
                    }
                    
                }
            }
            //else Console.WriteLine("There is no such item!");
            else if (choice == 4)
            {
                Console.WriteLine("Please enter the price range.");
                Console.WriteLine("Please enter the starting poing of the price...");
                var startPrice = Console.ReadLine();
                bool parsingInputStartPrice = int.TryParse(startPrice, out int parsedStartPrice);  //pocetna vrednost
                Console.WriteLine("Please enter the ending poing of the price...");
                var endPrice = Console.ReadLine();
                bool parsingInputEndPrice = int.TryParse(endPrice, out int parsedEndPrice);   //zavrsna vrednost

                foreach (var item in Products.products)
                {
                    if (item.Price > parsedStartPrice && item.Price < parsedEndPrice)
                    {
                        Console.WriteLine($"The Id is:{item.Id}.The company name is:{item.Company}. The type of food is: {item.Type}.");
                    }
                    else
                    {
                        Console.WriteLine("Item is out of price range.");
                     break;
                    }
                }
                
            }
        }
    }
}
