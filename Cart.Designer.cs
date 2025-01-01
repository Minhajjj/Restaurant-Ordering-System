namespace test.Forms
{
    partial class Cart
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            label2 = new Label();
            CartGridView = new DataGridView();
            dishPricetxt = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewButtonColumn();
            dishNametxt = new DataGridViewTextBoxColumn();
            categorytxt = new DataGridViewTextBoxColumn();
            dishesBindingSource = new BindingSource(components);
            btnClearCart = new Button();
            btnUpdateCart = new Button();
            Paymentbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CartGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Script MT Bold", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Moccasin;
            label2.Location = new Point(755, 20);
            label2.Name = "label2";
            label2.Size = new Size(287, 67);
            label2.TabIndex = 1;
            label2.Text = "Your Cart :";
            // 
            // CartGridView
            // 
            CartGridView.AutoGenerateColumns = false;
            CartGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CartGridView.BackgroundColor = Color.DeepSkyBlue;
            CartGridView.BorderStyle = BorderStyle.Fixed3D;
            CartGridView.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            CartGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartGridView.Columns.AddRange(new DataGridViewColumn[] { dishPricetxt, colAction, dishNametxt, categorytxt });
            CartGridView.Cursor = Cursors.Hand;
            CartGridView.DataSource = dishesBindingSource;
            CartGridView.GridColor = Color.Khaki;
            CartGridView.Location = new Point(189, 90);
            CartGridView.Name = "CartGridView";
            CartGridView.RowHeadersWidth = 62;
            CartGridView.RowTemplate.Height = 33;
            CartGridView.Size = new Size(1359, 325);
            CartGridView.TabIndex = 2;
            CartGridView.CellContentClick += CartGridView_CellContentClick;
            // 
            // dishPricetxt
            // 
            dishPricetxt.DataPropertyName = "DishPrice";
            dishPricetxt.HeaderText = "DishPrice";
            dishPricetxt.MinimumWidth = 8;
            dishPricetxt.Name = "dishPricetxt";
            // 
            // colAction
            // 
            colAction.HeaderText = "Action";
            colAction.MinimumWidth = 8;
            colAction.Name = "colAction";
            colAction.Text = "Remove items";
            colAction.UseColumnTextForButtonValue = true;
            // 
            // dishNametxt
            // 
            dishNametxt.DataPropertyName = "DishName";
            dishNametxt.HeaderText = "DishName";
            dishNametxt.MinimumWidth = 8;
            dishNametxt.Name = "dishNametxt";
            // 
            // categorytxt
            // 
            categorytxt.DataPropertyName = "Category";
            categorytxt.HeaderText = "Category";
            categorytxt.MinimumWidth = 8;
            categorytxt.Name = "categorytxt";
            // 
            // dishesBindingSource
            // 
            dishesBindingSource.DataSource = typeof(Models.Dishes);
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.LawnGreen;
            btnClearCart.Font = new Font("Franklin Gothic Demi", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearCart.Location = new Point(1613, 445);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(112, 34);
            btnClearCart.TabIndex = 3;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnUpdateCart
            // 
            btnUpdateCart.Location = new Point(0, 0);
            btnUpdateCart.Name = "btnUpdateCart";
            btnUpdateCart.Size = new Size(75, 23);
            btnUpdateCart.TabIndex = 8;
            // 
            // Paymentbtn
            // 
            Paymentbtn.BackColor = Color.Yellow;
            Paymentbtn.Font = new Font("Franklin Gothic Demi Cond", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Paymentbtn.Location = new Point(1483, 445);
            Paymentbtn.Name = "Paymentbtn";
            Paymentbtn.Size = new Size(112, 34);
            Paymentbtn.TabIndex = 7;
            Paymentbtn.Text = "Payment";
            Paymentbtn.UseVisualStyleBackColor = false;
            Paymentbtn.Click += Paymentbtn_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1747, 491);
            Controls.Add(Paymentbtn);
            Controls.Add(btnUpdateCart);
            Controls.Add(btnClearCart);
            Controls.Add(CartGridView);
            Controls.Add(label2);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)CartGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView CartGridView;
        private BindingSource dishesBindingSource;
        private Button btnClearCart;
        private Button btnUpdateCart;
        private Button Paymentbtn;
        private DataGridViewTextBoxColumn dishPricetxt;
        private DataGridViewButtonColumn colAction;
        private DataGridViewTextBoxColumn dishNametxt;
        private DataGridViewTextBoxColumn categorytxt;
    }
}