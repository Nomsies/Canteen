using System.Drawing;
using Canteen.Controller;

namespace Canteen.View
{
    public partial class OrderMenu : Form
    {
        private readonly ProductController _control = new ProductController();
        public OrderMenu()
        {
            InitializeComponent();
            LoadMenu();
        }

        private void LoadMenu()
        {
            foreach (var menu in _control.ShowMenu(ProductController.category.All))
                menuPanel.Controls.Add(menu);

            ChangePanelSize();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            menuPanel.Controls.Clear();
            LoadMenu();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            menuPanel.Controls.Clear();
            foreach (var menu in _control.ShowMenu(ProductController.category.Food))
                menuPanel.Controls.Add(menu);

            ChangePanelSize();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            menuPanel.Controls.Clear();
            foreach (var menu in _control.ShowMenu(ProductController.category.Drink))
                menuPanel.Controls.Add(menu);
            ChangePanelSize();
        }

        private void MenuForm_Resize(object sender, EventArgs e)
        {
            int totalWidth = this.ClientSize.Width;
            int totalHeight = this.ClientSize.Height;
            int margin = 10;

            int menuPanelWidth = ((2 * totalWidth) / 3) - (2 * margin);
            int menuPanelHeight = totalHeight - (totalHeight * 4 / 20) - margin;

            int cartBtnHeight = (totalHeight / 7) - (3 * margin);

            int detailPanelWidth = (totalWidth / 3) - margin;
            int detailPanelHeight = totalHeight - (cartBtnHeight + 3 * margin);


            menuPanel.Size = new Size(menuPanelWidth, menuPanelHeight);
            menuPanel.Location = new Point(10, totalHeight * 4 / 20);

            detailPanel.Size = new Size(detailPanelWidth, detailPanelHeight);
            detailPanel.Location = new Point(menuPanelWidth + 20, 10);

            btnCart.Size = new Size(detailPanelWidth, cartBtnHeight);
            btnCart.Location = new Point(menuPanelWidth + 20, detailPanelHeight + 2 * margin);

            ChangePanelSize();
        }

        private void ChangePanelSize()
        {

            int margin = 10;
            int panelWidth = ((menuPanel.ClientSize.Width - margin) / 4) - (margin);
            //if (menuPanel.VerticalScroll.Visible)
            //    panelWidth = ((menuPanel.ClientSize.Width - margin) / 4) - (margin);
            //else 
            //    panelWidth = (menuPanel.ClientSize.Width / 4) - (margin);

            var panels = menuPanel.Controls.OfType<Panel>().ToList();

            if (panels.Count == 0) return;

            foreach (var panel in panels)
            {
                panel.Size = new Size(panelWidth, panelWidth + 20);
                
                PictureBox pictureBox = panel.Controls.OfType<PictureBox>().SingleOrDefault();
                pictureBox.Size = new Size(panelWidth - (2 * margin), panelWidth - (2 * margin));
                
                var labels = panel.Controls.OfType<Label>().ToList();
                foreach (var label in labels) label.Size = new Size(panelWidth, 24);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //byte[] image = File.ReadAllBytes("C:\\Users\\thope\\Pictures\\TugasJarkom\\PingPC-0.png");
        //    //label1.Text = Convert.ToBase64String(image);
        //    //Clipboard.SetText(label1.Text);
        //}
    }
}
