
namespace Dzaone_Appliance_Shop
{
    partial class Customer_Dashboard
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
            this.picture_panel = new System.Windows.Forms.Panel();
            this.customerlogout_picture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerlogout_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_panel
            // 
            this.picture_panel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.picture_panel.Location = new System.Drawing.Point(141, 0);
            this.picture_panel.Name = "picture_panel";
            this.picture_panel.Size = new System.Drawing.Size(5, 652);
            this.picture_panel.TabIndex = 2;
            // 
            // customerlogout_picture
            // 
            this.customerlogout_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerlogout_picture.Image = global::Dzaone_Appliance_Shop.Properties.Resources.log_out__1_;
            this.customerlogout_picture.Location = new System.Drawing.Point(12, 591);
            this.customerlogout_picture.Name = "customerlogout_picture";
            this.customerlogout_picture.Size = new System.Drawing.Size(100, 50);
            this.customerlogout_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerlogout_picture.TabIndex = 7;
            this.customerlogout_picture.TabStop = false;
            this.customerlogout_picture.Click += new System.EventHandler(this.customerlogout_picture_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dzaone_Appliance_Shop.Properties.Resources.small_appliance2;
            this.pictureBox2.Location = new System.Drawing.Point(16, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Customer_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.customerlogout_picture);
            this.Controls.Add(this.picture_panel);
            this.Name = "Customer_Dashboard";
            this.Text = "Customer_Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.customerlogout_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel picture_panel;
        private System.Windows.Forms.PictureBox customerlogout_picture;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}