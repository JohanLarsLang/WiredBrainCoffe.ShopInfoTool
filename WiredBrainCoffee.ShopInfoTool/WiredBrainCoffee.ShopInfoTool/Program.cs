using System;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoffee.ShopInfoTool
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Wirded Brain Coffe - Shop Info Tool!");

			Console.WriteLine("Write help to list available commands");

			var coffeeShopDataProvider = new CoffeeShopDataProvider();

			while (true)
			{
				var line = Console.ReadLine();

				var coffeeShops = coffeeShopDataProvider.LoadCoffeShops();

				if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
				{
					Console.WriteLine("> Available coffee shops commands:");

					foreach (var coffeshop in coffeeShops)
					{
						Console.WriteLine($"> {coffeshop.Location}");
					}
				}


			}
		}
	}
}
