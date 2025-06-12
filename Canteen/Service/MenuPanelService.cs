using Canteen.Model;

namespace Canteen.Service
{
    public class MenuPanelService
    {
        //public List<FlowLayoutPanel> ShowMenu(category category)
        //{
        //    int top;
        //    int right = 0;
        //    int left = 10, bottom = 10;

        //    List<FlowLayoutPanel> menus = new List<FlowLayoutPanel>();

        //    switch (category)
        //    {
        //        case category.All:
        //            for (int i = 0; i < GetAllMenu().Count; i++)
        //            {
        //                top = i < 4 ? 10 : 0;
        //                menus.Add(PanelMenu(GetAllMenu()[i], new Padding(left, top, right, bottom)));
        //            }
        //            break;
        //        case category.Food:
        //            for (int i = 0; i < GetMenuByCategory<Foods>(1).Count; i++)
        //            {
        //                top = i < 4 ? 10 : 0;
        //                menus.Add(PanelMenu(GetMenuByCategory<Foods>(1)[i], new Padding(left, top, right, bottom)));
        //            }
        //            break;
        //        case category.Drink:
        //            for (int i = 0; i < GetMenuByCategory<Foods>(2).Count; i++)
        //            {
        //                top = i < 4 ? 10 : 0;
        //                menus.Add(PanelMenu(GetMenuByCategory<Foods>(2)[i], new Padding(left, top, right, bottom)));
        //            }
        //            break;
        //    }

        //    return menus;
        //}

        public FlowLayoutPanel PanelMenu(Menu menu, Padding pad)
        {
            string path = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName + @"\Image\" + menu.ImageLocation;

            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Size = new Size(200, 220),
                BackColor = ColorTranslator.FromHtml("#DEDEDE"),
                Margin = pad,
                Controls =
                {
                    new PictureBox
                    {
                        Size = new Size(180,180),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Image = Image.FromFile(path),
                        Margin = new Padding(10, 10, 10, 5),
                        Enabled = false,
                    },
                    new Label
                    {
                        Text = menu.Name,
                        Size = new Size(300, 32),
                        Margin = new Padding(10,5,10,5),
                        Enabled = false,
                    }
                }
            };

            panel.Click += (sender, e) => { };

            return panel;
        }

        public List<FlowLayoutPanel> ShowMenu(List<Menu> menuList)
        {
            int top;
            int right = 0;
            int left = 10, bottom = 10;
            List<FlowLayoutPanel> menus = new List<FlowLayoutPanel>();

            for (int i = 0; i < menuList.Count; i++)
            {
                top = i < 4 ? 10 : 0;
                FlowLayoutPanel panel = PanelMenu(menuList[i], new Padding(left, top, right, bottom));
                menus.Add(panel);
            }

            return menus;
        }
    }
}
