using Canteen.View;
using Canteen.Model;
using Canteen.Service;

namespace Canteen.Controller
{
    public class OrderController : ProductService
    {
        private OrderMenu view;
        private ProductController cProduct;

        private List<Menu> orderMenu = new List<Menu>();

        public enum category { All, Food, Drink };

        public OrderController(OrderMenu view)
        {
            this.view = view;
            this.cProduct = new ProductController();
        }

        public List<FlowLayoutPanel> ShowMenu(category category)
        {
            List<Menu> menus = category switch
            {
                category.All => cProduct.GetAllMenu(),
                category.Food => cProduct.GetMenuByCategory<Foods>(1).Cast<Menu>().ToList(),
                category.Drink => cProduct.GetMenuByCategory<Drinks>(2).Cast<Menu>().ToList(),
                _ => null
            };

            return ShowMenu(menus);
        }

        public override void ShowDetailMenu(Menu menu)
        {
            string path = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName + @"\Image\" + menu.ImageLocation;

            Size pSize = view.panel.ClientSize;
            Size imageSize = new Size(pSize.Width - 60, pSize.Width - 60);
            Size labelSize = new Size(pSize.Width, 32);
            Size buttonSize = new Size(pSize.Width - 30, 32);
            int margin = 10;

            view.panel.Controls.Clear();

            Button btnBuy = new Button
            {
                Text = "Add to Cart",
                Size = buttonSize,
                Location = new Point(15, pSize.Height - 47)
            };

            btnBuy.Click += (sender, e) => { orderMenu.Add(menu); };

            view.panel.Controls.AddRange([
                new PictureBox
                {
                    Image = Image.FromFile(path),
                    Size = imageSize,
                    Location = new Point(30,30),
                    SizeMode = PictureBoxSizeMode.Zoom,
                },
                new Label
                {
                    Text = menu.Name,
                    Font = new Font("Segoe UI", 18, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(0, 30 + imageSize.Height + margin),
                    Size = labelSize
                },
                new Label{
                    Text = "Rp " + menu.Price.ToString(),
                    Font = new Font("Segoe UI", 18, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(0, 30 + imageSize.Height + (2 * margin) + labelSize.Height),
                    Size = labelSize
                },
                btnBuy
            ]);
        }
    }
}