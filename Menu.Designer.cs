namespace test.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            GridDishes = new DataGridView();
            colAction = new DataGridViewButtonColumn();
            dishPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dishNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dishesBindingSource = new BindingSource(components);
            cmbxCategory = new ComboBox();
            BtnDisplayCart = new Button();
            label2 = new Label();
            lblWelcome = new Label();
            btnMember = new Button();
            ((System.ComponentModel.ISupportInitialize)GridDishes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dishesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(28, 148);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 0;
            label1.Text = "Menu Categories :";
            // 
            // GridDishes
            // 
            GridDishes.AutoGenerateColumns = false;
            GridDishes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridDishes.BackgroundColor = Color.Cyan;
            GridDishes.BorderStyle = BorderStyle.Fixed3D;
            GridDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDishes.Columns.AddRange(new DataGridViewColumn[] { colAction, dishPriceDataGridViewTextBoxColumn, dishNameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            GridDishes.Cursor = Cursors.Hand;
            GridDishes.DataSource = dishesBindingSource;
            GridDishes.GridColor = Color.FromArgb(128, 255, 255);
            GridDishes.Location = new Point(199, 204);
            GridDishes.Name = "GridDishes";
            GridDishes.RowHeadersWidth = 62;
            GridDishes.RowTemplate.Height = 33;
            GridDishes.Size = new Size(1420, 255);
            GridDishes.TabIndex = 2;
            GridDishes.CellContentClick += GridDishes_CellContentClick;
            // 
            // colAction
            // 
            colAction.HeaderText = "action";
            colAction.MinimumWidth = 8;
            colAction.Name = "colAction";
            colAction.SortMode = DataGridViewColumnSortMode.Programmatic;
            colAction.Text = "Add To Cart";
            colAction.ToolTipText = "Add to cart";
            colAction.UseColumnTextForButtonValue = true;
            // 
            // dishPriceDataGridViewTextBoxColumn
            // 
            dishPriceDataGridViewTextBoxColumn.DataPropertyName = "DishPrice";
            dishPriceDataGridViewTextBoxColumn.HeaderText = "DishPrice";
            dishPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            dishPriceDataGridViewTextBoxColumn.Name = "dishPriceDataGridViewTextBoxColumn";
            // 
            // dishNameDataGridViewTextBoxColumn
            // 
            dishNameDataGridViewTextBoxColumn.DataPropertyName = "DishName";
            dishNameDataGridViewTextBoxColumn.HeaderText = "DishName";
            dishNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            dishNameDataGridViewTextBoxColumn.Name = "dishNameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // dishesBindingSource
            // 
            dishesBindingSource.DataSource = typeof(Models.Dishes);
            // 
            // cmbxCategory
            // 
            cmbxCategory.FormattingEnabled = true;
            cmbxCategory.Items.AddRange(new object[] { "Desi", "Chinese", "Italian", "French", "Beverages" });
            cmbxCategory.Location = new Point(210, 148);
            cmbxCategory.Name = "cmbxCategory";
            cmbxCategory.Size = new Size(387, 33);
            cmbxCategory.TabIndex = 3;
            cmbxCategory.SelectedIndexChanged += cmbxCategory_SelectedIndexChanged_1;
            // 
            // BtnDisplayCart
            // 
            BtnDisplayCart.BackColor = Color.Lime;
            BtnDisplayCart.Font = new Font("Sitka Small Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BtnDisplayCart.Location = new Point(1533, 482);
            BtnDisplayCart.Name = "BtnDisplayCart";
            BtnDisplayCart.Size = new Size(196, 43);
            BtnDisplayCart.TabIndex = 4;
            BtnDisplayCart.Text = "Go to Cart";
            BtnDisplayCart.UseVisualStyleBackColor = false;
            BtnDisplayCart.Click += BtnDisplayCart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Mistral", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(692, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 114);
            label2.TabIndex = 5;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcome.Location = new Point(47, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 38);
            lblWelcome.TabIndex = 6;
            // 
            // btnMember
            // 
            btnMember.BackColor = Color.Lime;
            btnMember.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnMember.Location = new Point(1533, 84);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(196, 39);
            btnMember.TabIndex = 7;
            btnMember.Text = "Get Membership";
            btnMember.UseVisualStyleBackColor = false;
            btnMember.Click += btnMember_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1761, 537);
            Controls.Add(btnMember);
            Controls.Add(lblWelcome);
            Controls.Add(label2);
            Controls.Add(BtnDisplayCart);
            Controls.Add(cmbxCategory);
            Controls.Add(GridDishes);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)GridDishes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dishesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView GridDishes;
        private ComboBox cmbxCategory;
        private BindingSource dishesBindingSource;
        private DataGridViewButtonColumn colAction;
        private DataGridViewTextBoxColumn dishPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dishNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private Button BtnDisplayCart;
        private Label label2;
        private Label lblWelcome;
        private Button btnMember;
    }
}