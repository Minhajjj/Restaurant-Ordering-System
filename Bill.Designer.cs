namespace test.Forms
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            label1 = new Label();
            Billpanel = new Panel();
            lbltotal = new Label();
            Paybtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Brush Script MT", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(847, 58);
            label1.Name = "label1";
            label1.Size = new Size(249, 69);
            label1.TabIndex = 0;
            label1.Text = "Your Bill :";
            // 
            // Billpanel
            // 
            Billpanel.BackColor = Color.Transparent;
            Billpanel.Font = new Font("Imprint MT Shadow", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Billpanel.ForeColor = SystemColors.ButtonHighlight;
            Billpanel.Location = new Point(51, 127);
            Billpanel.Name = "Billpanel";
            Billpanel.Size = new Size(1623, 259);
            Billpanel.TabIndex = 1;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.BackColor = Color.Transparent;
            lbltotal.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotal.ForeColor = SystemColors.ButtonFace;
            lbltotal.Location = new Point(74, 411);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(236, 25);
            lbltotal.TabIndex = 2;
            lbltotal.Text = "Total Bill : PKR 0.00";
            // 
            // Paybtn
            // 
            Paybtn.BackColor = Color.Lime;
            Paybtn.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Paybtn.Location = new Point(1584, 433);
            Paybtn.Name = "Paybtn";
            Paybtn.Size = new Size(129, 49);
            Paybtn.TabIndex = 3;
            Paybtn.Text = "Pay Now";
            Paybtn.UseVisualStyleBackColor = false;
            Paybtn.Click += Paybtn_Click;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1760, 494);
            Controls.Add(Paybtn);
            Controls.Add(lbltotal);
            Controls.Add(Billpanel);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Bill";
            ShowInTaskbar = false;
            Text = "Bill";
            Load += Bill_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel Billpanel;
        private Label lbltotal;
        private Button Paybtn;
    }
}