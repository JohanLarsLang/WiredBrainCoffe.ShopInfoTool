using System;
using System.Linq;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoffee.ShopInfoTool
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Wirded Brain Coffe - Shop Info Tool!");

			Console.WriteLine("Write help to list available coffe shop commands, write exit to quit the program");

			var coffeeShopDataProvider = new CoffeeShopDataProvider();

			while (true)
			{
				var line = Console.ReadLine();

				if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
				{
					break;
				}

				var coffeeShops = coffeeShopDataProvider.LoadCoffeShops();

				var commandHandler = 
				string.Equals("help", line, StringComparison.OrdinalIgnoreCase)
				?  new HelpCommandHandler(coffeeShops) as ICommandHandler
				: new CoffeShopCommandHandler(coffeeShops, line);
				
				commandHandler.HandleCommand();

			}
		}
	}
}
