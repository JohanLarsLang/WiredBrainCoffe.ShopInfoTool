using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
	public class CoffeeShopDataProvider
	{
		public IEnumerable<CoffeeShop> LoadCoffeShops()
		{
			yield return new CoffeeShop { Location = "Gothenburg", BeanInStockInKg = 106 };
			yield return new CoffeeShop { Location = "Orebro", BeanInStockInKg = 66 };
			yield return new CoffeeShop { Location = "Stockholm", BeanInStockInKg = 26 };
		}
	}
}
