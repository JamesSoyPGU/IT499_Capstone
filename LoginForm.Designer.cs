namespace IT499_WBDatabase
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbl_Login_Title = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_NewCustomer = new System.Windows.Forms.Button();
            this.lbl_MannTitle = new System.Windows.Forms.Label();
            this.pic_MannImage = new System.Windows.Forms.PictureBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MannImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Login_Title
            // 
            this.lbl_Login_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Login_Title.AutoSize = true;
            this.lbl_Login_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Login_Title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Title.Location = new System.Drawing.Point(668, 47);
            this.lbl_Login_Title.Name = "lbl_Login_Title";
            this.lbl_Login_Title.Size = new System.Drawing.Size(223, 55);
            this.lbl_Login_Title.TabIndex = 1;
            this.lbl_Login_Title.Text = "Login Page";
            this.lbl_Login_Title.Click += new System.EventHandler(this.lbl_Login_Title_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(589, 223);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(111, 23);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "User Name:";
            this.lbl_UserName.Click += new System.EventHandler(this.lbl_UserName_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(603, 274);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 23);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password:";
            this.lbl_Password.Click += new System.EventHandler(this.lbl_Password_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_UserName.BackColor = System.Drawing.Color.LightCyan;
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(706, 224);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(172, 30);
            this.txt_UserName.TabIndex = 4;
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt_UserName_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(706, 269);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(172, 30);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // btn_NewCustomer
            // 
            this.btn_NewCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NewCustomer.BackColor = System.Drawing.Color.Red;
            this.btn_NewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewCustomer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewCustomer.Location = new System.Drawing.Point(660, 540);
            this.btn_NewCustomer.Name = "btn_NewCustomer";
            this.btn_NewCustomer.Size = new System.Drawing.Size(262, 69);
            this.btn_NewCustomer.TabIndex = 7;
            this.btn_NewCustomer.Text = "New Customer";
            this.btn_NewCustomer.UseVisualStyleBackColor = false;
            this.btn_NewCustomer.Click += new System.EventHandler(this.btn_NewCustomer_Click);
            // 
            // lbl_MannTitle
            // 
            this.lbl_MannTitle.AutoSize = true;
            this.lbl_MannTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MannTitle.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MannTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_MannTitle.Name = "lbl_MannTitle";
            this.lbl_MannTitle.Size = new System.Drawing.Size(308, 195);
            this.lbl_MannTitle.TabIndex = 8;
            this.lbl_MannTitle.Text = "Mann\r\nMaintenance\r\nServices";
            this.lbl_MannTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_MannTitle.Click += new System.EventHandler(this.lbl_Mann_Title_Click);
            // 
            // pic_MannImage
            // 
            this.pic_MannImage.BackColor = System.Drawing.Color.Transparent;
            this.pic_MannImage.Image = ((System.Drawing.Image)(resources.GetObject("pic_MannImage.Image")));
            this.pic_MannImage.Location = new System.Drawing.Point(23, 207);
            this.pic_MannImage.Name = "pic_MannImage";
            this.pic_MannImage.Size = new System.Drawing.Size(508, 500);
            this.pic_MannImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MannImage.TabIndex = 9;
            this.pic_MannImage.TabStop = false;
            this.pic_MannImage.Click += new System.EventHandler(this.pic_MannImage_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(719, 367);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(139, 60);
            this.btn_Submit.TabIndex = 32;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1491, 758);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_MannTitle);
            this.Controls.Add(this.btn_NewCustomer);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_Login_Title);
            this.Controls.Add(this.pic_MannImage);
            this.Name = "LoginForm";
            this.Text = "Login Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_MannImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Login_Title;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_NewCustomer;
        private System.Windows.Forms.Label lbl_MannTitle;
        private System.Windows.Forms.PictureBox pic_MannImage;
        private System.Windows.Forms.Button btn_Submit;
    }
}

