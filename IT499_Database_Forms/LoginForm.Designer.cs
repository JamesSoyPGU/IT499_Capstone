namespace IT499_Database_Forms
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_MannTitle = new System.Windows.Forms.Label();
            this.btn_NewCustomer = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Login_Title = new System.Windows.Forms.Label();
            this.pic_MannImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MannImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(791, 367);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(139, 60);
            this.btn_Submit.TabIndex = 41;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // lbl_MannTitle
            // 
            this.lbl_MannTitle.AutoSize = true;
            this.lbl_MannTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MannTitle.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MannTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_MannTitle.Name = "lbl_MannTitle";
            this.lbl_MannTitle.Size = new System.Drawing.Size(308, 195);
            this.lbl_MannTitle.TabIndex = 39;
            this.lbl_MannTitle.Text = "Mann\r\nMaintenance\r\nServices";
            this.lbl_MannTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_NewCustomer
            // 
            this.btn_NewCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NewCustomer.BackColor = System.Drawing.Color.Red;
            this.btn_NewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewCustomer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewCustomer.Location = new System.Drawing.Point(732, 540);
            this.btn_NewCustomer.Name = "btn_NewCustomer";
            this.btn_NewCustomer.Size = new System.Drawing.Size(262, 69);
            this.btn_NewCustomer.TabIndex = 38;
            this.btn_NewCustomer.Text = "New Customer";
            this.btn_NewCustomer.UseVisualStyleBackColor = false;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.BackColor = System.Drawing.Color.LightCyan;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(778, 269);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(172, 30);
            this.txt_Password.TabIndex = 37;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_UserName.BackColor = System.Drawing.Color.LightCyan;
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(778, 224);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(172, 30);
            this.txt_UserName.TabIndex = 36;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(675, 274);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 23);
            this.lbl_Password.TabIndex = 35;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(661, 223);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(111, 23);
            this.lbl_UserName.TabIndex = 34;
            this.lbl_UserName.Text = "User Name:";
            // 
            // lbl_Login_Title
            // 
            this.lbl_Login_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Login_Title.AutoSize = true;
            this.lbl_Login_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Login_Title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Title.Location = new System.Drawing.Point(740, 47);
            this.lbl_Login_Title.Name = "lbl_Login_Title";
            this.lbl_Login_Title.Size = new System.Drawing.Size(223, 55);
            this.lbl_Login_Title.TabIndex = 33;
            this.lbl_Login_Title.Text = "Login Page";
            // 
            // pic_MannImage
            // 
            this.pic_MannImage.BackColor = System.Drawing.Color.Transparent;
            this.pic_MannImage.Image = ((System.Drawing.Image)(resources.GetObject("pic_MannImage.Image")));
            this.pic_MannImage.Location = new System.Drawing.Point(12, 207);
            this.pic_MannImage.Name = "pic_MannImage";
            this.pic_MannImage.Size = new System.Drawing.Size(508, 500);
            this.pic_MannImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MannImage.TabIndex = 40;
            this.pic_MannImage.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1432, 718);
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
            this.Text = "Login Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pic_MannImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_MannTitle;
        private System.Windows.Forms.Button btn_NewCustomer;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Login_Title;
        private System.Windows.Forms.PictureBox pic_MannImage;
    }
}

