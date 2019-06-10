using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
	public class CoffeeShopDataProvider
	{
		public IEnumerable<CoffeeShop> LoadCoffeShops()
		{
			yield return new CoffeeShop { Location = "Gothenburg", BeanInStockInKg = 106, PaperCupsInStock = 343 };
			yield return new CoffeeShop { Location = "Orebro", BeanInStockInKg = 66, PaperCupsInStock = 123 };
			yield return new CoffeeShop { Location = "Stockholm", BeanInStockInKg = 26, PaperCupsInStock = 456 };
		}
	}
}
