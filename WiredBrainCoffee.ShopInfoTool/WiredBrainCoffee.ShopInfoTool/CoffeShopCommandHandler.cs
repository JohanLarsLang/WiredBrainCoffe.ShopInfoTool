using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.ShopInfoTool
{
	internal class CoffeShopCommandHandler : ICommandHandler
	{
		private IEnumerable<CoffeeShop> coffeeShops;
		private string line;

		public CoffeShopCommandHandler(IEnumerable<CoffeeShop> coffeeShops, string line)
		{
			this.coffeeShops = coffeeShops;
			this.line = line;
		}

		public void HandleCommand()
		{
			var foundCoffeShops = coffeeShops
		.Where(x => x.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase))
		.ToList();

			if (foundCoffeShops.Count == 0)
			{
				Console.WriteLine($"> Command '{line}' not found");
			}
			else if (foundCoffeShops.Count == 1)
			{
				var coffeShop = foundCoffeShops.Single();
				Console.WriteLine($"> Location: {coffeShop.Location}");
				Console.WriteLine($"> Beans in stock in kg: {coffeShop.BeanInStockInKg}");
				Console.WriteLine($"> Paper cups in stock: {coffeShop.PaperCupsInStock}");
			}
			else
			{
				Console.WriteLine($"Mulitiple matching coffeshop commands found:");
				foreach (var coffeType in coffeeShops)
				{
					Console.WriteLine($"> {coffeType.Location}");
				}
			}
		}
	}
}