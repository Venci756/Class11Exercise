using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp
{
    public static class Products
    {
        public static List<Food> products = new List<Food>()
        {
            new Food()
            {
                Id=1,
                Price=200,
                Company="Meat Company",
                Type=Type.Meat
            },
            new Food()
            {
                Id=2,
                Price=200,
                Company="Fruit Company",
                Type=Type.Fruit
            },
            new Food()
            {
                Id=3,
                Price=300,
                Company="Vegetable Company",
                Type=Type.Vegetable
            },
            new Food()
            {
                Id=4,
                Price=200,
                Company="Bevarage Company",
                Type=Type.Beverage
            },
            new Food()
            {
                Id=5,
                Price=250,
                Company="A Meat Company",
                Type=Type.Meat
            },
            new Food()
            {
                Id=5,
                Price=450,
                Company="B Meat Company",
                Type=Type.Meat
            },
        };
        public static void ShowProducts()
        {
            //Console.WriteLine("Choose how to sort the items.");
            //Console.WriteLine("1) For sorting by Company Name.");
            //Console.WriteLine("2) For sorting by Price.");
            //Console.WriteLine("3) For sorting by Item Type.");
            //var userInput = Console.ReadLine();
            //if (userInput)
                foreach (var item in products)
            {
                Console.WriteLine($"Product ID:{item.Id}. Product price: {item.Price}. Company: {item.Company}. Product type: {item.Type}.");
            }
        }
    }
}
