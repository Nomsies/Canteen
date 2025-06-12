namespace Canteen.View
{
    partial class OrderMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPanel = new FlowLayoutPanel();
            detailPanel = new Panel();
            btnBuy = new Button();
            btnCart = new Button();
            btnAll = new Button();
            btnFood = new Button();
            btnDrink = new Button();
            label1 = new Label();
            detailPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.AutoScroll = true;
            menuPanel.BackColor = SystemColors.AppWorkspace;
            menuPanel.Location = new Point(12, 74);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(568, 369);
            menuPanel.TabIndex = 0;
            // 
            // detailPanel
            // 
            detailPanel.BackColor = SystemColors.AppWorkspace;
            detailPanel.Controls.Add(btnBuy);
            detailPanel.Location = new Point(593, 10);
            detailPanel.Margin = new Padding(10);
            detailPanel.Name = "detailPanel";
            detailPanel.Size = new Size(198, 366);
            detailPanel.TabIndex = 1;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(10, 315);
            btnBuy.Margin = new Padding(10);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(178, 41);
            btnBuy.TabIndex = 0;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            // 
            // btnCart
            // 
            btnCart.Location = new Point(593, 389);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(198, 54);
            btnCart.TabIndex = 2;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(48, 45);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(75, 23);
            btnAll.TabIndex = 3;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // btnFood
            // 
            btnFood.Location = new Point(254, 45);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(75, 23);
            btnFood.TabIndex = 4;
            btnFood.Text = "Food";
            btnFood.UseVisualStyleBackColor = true;
            btnFood.Click += btnFood_Click;
            // 
            // btnDrink
            // 
            btnDrink.Location = new Point(469, 45);
            btnDrink.Name = "btnDrink";
            btnDrink.Size = new Size(75, 23);
            btnDrink.TabIndex = 5;
            btnDrink.Text = "Drink";
            btnDrink.UseVisualStyleBackColor = true;
            btnDrink.Click += btnDrink_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 10);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDrink);
            Controls.Add(btnFood);
            Controls.Add(btnAll);
            Controls.Add(btnCart);
            Controls.Add(detailPanel);
            Controls.Add(menuPanel);
            Name = "MenuForm";
            Text = "MenuForm";
            Resize += MenuForm_Resize;
            detailPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel detailPanel;
        private Button btnBuy;
        private Button btnCart;
        private Button btnAll;
        private Button btnFood;
        private Button btnDrink;
        private FlowLayoutPanel menuPanel;
        private Label label1;
    }
}