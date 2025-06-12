using Canteen.View;
using Canteen.Model;
using Canteen.Service;

namespace Canteen.Controller
{
    public class OrderController
    {
        private SqlHelper helper;
        private OrderMenu view;
        private ProductController cMenu;

        public enum category { All, Food, Drink };

        public OrderController(OrderMenu view)
        {
            this.view = view;
            this.helper = new SqlHelper();
            this.cMenu = new ProductController();
        }

        public List<FlowLayoutPanel> ShowMenu(category category)
        {
            var menuService = new MenuPanelService();
            List<Menu> menus = category switch
            {
                category.All => cMenu.GetAllMenu(),
                category.Food => cMenu.GetMenuByCategory<Foods>(1).Cast<Menu>().ToList(),
                category.Drink => cMenu.GetMenuByCategory<Drinks>(2).Cast<Menu>().ToList(),
                _ => null
            };

            return menuService.ShowMenu(menus);
        }
    }
}