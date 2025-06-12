using System.Drawing;
using Canteen.Model;
using Canteen.Service;

namespace Canteen.Controller
{
    public class ProductController : ProductService 
    {
        public enum category { All, Food, Drink }
        private readonly SqlHelper helper;

        public ProductController(Action action = null)
        {
            helper = new SqlHelper();
        }

        public List<Menu> GetAllMenu()
        {
            List<Foods> foods = GetMenuByCategory<Foods>(1);
            List<Drinks> drinks = GetMenuByCategory<Drinks>(2);

            List<Menu> menus = new List<Menu>();
            menus.AddRange(foods);
            menus.AddRange(drinks);

            return menus;
        }

        public List<FlowLayoutPanel> ShowMenu(category category)
        {
            List<Menu> menus = category switch
            {
                category.All => GetAllMenu(),
                category.Food => GetMenuByCategory<Foods>(1).Cast<Menu>().ToList(),
                category.Drink => GetMenuByCategory<Drinks>(2).Cast<Menu>().ToList(),
                _ => null
            };

            return ShowMenu(menus);
        }

        public List<T> GetMenuByCategory<T>(int categoryId) where T : class, new()
        {
            return helper.ReadAllData<T>($"SELECT \"Id\", \"Name\", \"Price\", \"ImageLocation\" FROM Menu WHERE categoryId = {categoryId};");
        }

        public bool InsertMenu(string name, int price, string imageLocation)
        {
            foreach(Menu menu in GetAllMenu())
            {
                if (menu.Name == name) return false;
            }

            return helper.EditData(
                $"INSERT INTO menu (\"Name\", \"Price\", \"ImageLocation\") " +
                $"VALUES ('{name}', {price}, '{imageLocation}')"
                );
        }

        public bool DeleteMenu(int id)
        {
            return helper.EditData($"DELETE FROM menu WHERE id = {id}");
        }
    }
}
