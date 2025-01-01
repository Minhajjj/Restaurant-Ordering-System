namespace test.Forms
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnLogin = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Small Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(331, 145);
            label1.Name = "label1";
            label1.Size = new Size(101, 35);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(278, 282);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 1;
            label2.Text = "User Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Small Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(294, 345);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Display Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(258, 219);
            label4.Name = "label4";
            label4.Size = new Size(174, 35);
            label4.TabIndex = 3;
            label4.Text = "Phone Number :";
            // 
            // txtName
            // 
            txtName.Location = new Point(514, 145);
            txtName.Name = "txtName";
            txtName.Size = new Size(389, 31);
            txtName.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(503, 219);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(389, 31);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(503, 282);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(389, 31);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(503, 347);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(389, 31);
            txtPassword.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Franklin Gothic Demi", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnSave.Location = new Point(636, 435);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Font = new Font("Franklin Gothic Demi", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.Location = new Point(1624, 435);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 37);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1050, 421);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(395, 400);
            label6.Name = "label6";
            label6.Size = new Size(655, 21);
            label6.TabIndex = 11;
            label6.Text = "Your Password Must contain atleast a Capital letter alphabet,  two digits and atleast a symbol. ";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1772, 496);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnLogin);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtPhoneNumber;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnLogin;
        private Label label5;
        private Label label6;
    }
}