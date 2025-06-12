namespace Canteen.View
{
    partial class Dashboard
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
            btnOrder = new Button();
            btnTransaction = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(28, 50);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(75, 23);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Pesanan";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnTransaction
            // 
            btnTransaction.Location = new Point(28, 106);
            btnTransaction.Name = "btnTransaction";
            btnTransaction.Size = new Size(75, 23);
            btnTransaction.TabIndex = 1;
            btnTransaction.Text = "Riwayat Transaksi";
            btnTransaction.UseVisualStyleBackColor = true;
            btnTransaction.Click += btnTransaction_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(28, 166);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(btnTransaction);
            Controls.Add(btnOrder);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOrder;
        private Button btnTransaction;
        private Button btnMenu;
    }
}