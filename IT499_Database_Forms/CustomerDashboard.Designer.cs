namespace IT499_Database_Forms
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.btn_Billing = new System.Windows.Forms.Button();
            this.btn_CompletedWorkOrders = new System.Windows.Forms.Button();
            this.btn_InProgressWorkOrder = new System.Windows.Forms.Button();
            this.btn_NewWorkOrder = new System.Windows.Forms.Button();
            this.lbl_MannTitle = new System.Windows.Forms.Label();
            this.pic_MannImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MannImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Billing
            // 
            this.btn_Billing.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Billing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Billing.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Billing.Location = new System.Drawing.Point(607, 524);
            this.btn_Billing.Name = "btn_Billing";
            this.btn_Billing.Size = new System.Drawing.Size(205, 85);
            this.btn_Billing.TabIndex = 22;
            this.btn_Billing.Text = "Billing";
            this.btn_Billing.UseVisualStyleBackColor = false;
            // 
            // btn_CompletedWorkOrders
            // 
            this.btn_CompletedWorkOrders.BackColor = System.Drawing.Color.Lime;
            this.btn_CompletedWorkOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CompletedWorkOrders.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CompletedWorkOrders.Location = new System.Drawing.Point(607, 342);
            this.btn_CompletedWorkOrders.Name = "btn_CompletedWorkOrders";
            this.btn_CompletedWorkOrders.Size = new System.Drawing.Size(205, 85);
            this.btn_CompletedWorkOrders.TabIndex = 21;
            this.btn_CompletedWorkOrders.Text = "Completed\r\nWork Orders";
            this.btn_CompletedWorkOrders.UseVisualStyleBackColor = false;
            // 
            // btn_InProgressWorkOrder
            // 
            this.btn_InProgressWorkOrder.BackColor = System.Drawing.Color.Red;
            this.btn_InProgressWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_InProgressWorkOrder.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InProgressWorkOrder.Location = new System.Drawing.Point(607, 433);
            this.btn_InProgressWorkOrder.Name = "btn_InProgressWorkOrder";
            this.btn_InProgressWorkOrder.Size = new System.Drawing.Size(205, 85);
            this.btn_InProgressWorkOrder.TabIndex = 20;
            this.btn_InProgressWorkOrder.Text = "In-Progress\r\nWork Order";
            this.btn_InProgressWorkOrder.UseVisualStyleBackColor = false;
            // 
            // btn_NewWorkOrder
            // 
            this.btn_NewWorkOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_NewWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewWorkOrder.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewWorkOrder.Location = new System.Drawing.Point(607, 251);
            this.btn_NewWorkOrder.Name = "btn_NewWorkOrder";
            this.btn_NewWorkOrder.Size = new System.Drawing.Size(205, 85);
            this.btn_NewWorkOrder.TabIndex = 19;
            this.btn_NewWorkOrder.Text = "New \r\nWork Order";
            this.btn_NewWorkOrder.UseVisualStyleBackColor = false;
            // 
            // lbl_MannTitle
            // 
            this.lbl_MannTitle.AutoSize = true;
            this.lbl_MannTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MannTitle.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MannTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_MannTitle.Name = "lbl_MannTitle";
            this.lbl_MannTitle.Size = new System.Drawing.Size(308, 195);
            this.lbl_MannTitle.TabIndex = 17;
            this.lbl_MannTitle.Text = "Mann\r\nMaintenance\r\nServices";
            this.lbl_MannTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_MannImage
            // 
            this.pic_MannImage.BackColor = System.Drawing.Color.Transparent;
            this.pic_MannImage.Image = ((System.Drawing.Image)(resources.GetObject("pic_MannImage.Image")));
            this.pic_MannImage.Location = new System.Drawing.Point(12, 207);
            this.pic_MannImage.Name = "pic_MannImage";
            this.pic_MannImage.Size = new System.Drawing.Size(508, 500);
            this.pic_MannImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MannImage.TabIndex = 18;
            this.pic_MannImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 53);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Dashboard";
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1441, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Billing);
            this.Controls.Add(this.btn_CompletedWorkOrders);
            this.Controls.Add(this.btn_InProgressWorkOrder);
            this.Controls.Add(this.btn_NewWorkOrder);
            this.Controls.Add(this.lbl_MannTitle);
            this.Controls.Add(this.pic_MannImage);
            this.Name = "CustomerDashboard";
            this.Text = "Customer Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pic_MannImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Billing;
        private System.Windows.Forms.Button btn_CompletedWorkOrders;
        private System.Windows.Forms.Button btn_InProgressWorkOrder;
        private System.Windows.Forms.Button btn_NewWorkOrder;
        private System.Windows.Forms.Label lbl_MannTitle;
        private System.Windows.Forms.PictureBox pic_MannImage;
        private System.Windows.Forms.Label label1;
    }
}