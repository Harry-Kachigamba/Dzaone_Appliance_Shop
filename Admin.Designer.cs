
namespace Dzaone_Appliance_Shop
{
    partial class Admin
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
            this.Admin_text = new System.Windows.Forms.Label();
            this.Admin_password_label = new System.Windows.Forms.Label();
            this.Admin_textbox = new System.Windows.Forms.TextBox();
            this.Admin_Login_button = new System.Windows.Forms.Button();
            this.Admin_cancel_label = new System.Windows.Forms.LinkLabel();
            this.Adminpicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Adminpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_text
            // 
            this.Admin_text.AutoSize = true;
            this.Admin_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_text.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Admin_text.Location = new System.Drawing.Point(263, 33);
            this.Admin_text.Name = "Admin_text";
            this.Admin_text.Size = new System.Drawing.Size(243, 44);
            this.Admin_text.TabIndex = 2;
            this.Admin_text.Text = "Admin Login";
            this.Admin_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Admin_password_label
            // 
            this.Admin_password_label.AutoSize = true;
            this.Admin_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_password_label.Location = new System.Drawing.Point(182, 290);
            this.Admin_password_label.Name = "Admin_password_label";
            this.Admin_password_label.Size = new System.Drawing.Size(92, 24);
            this.Admin_password_label.TabIndex = 7;
            this.Admin_password_label.Text = "Password";
            // 
            // Admin_textbox
            // 
            this.Admin_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Admin_textbox.Location = new System.Drawing.Point(294, 285);
            this.Admin_textbox.Multiline = true;
            this.Admin_textbox.Name = "Admin_textbox";
            this.Admin_textbox.Size = new System.Drawing.Size(330, 32);
            this.Admin_textbox.TabIndex = 8;
            // 
            // Admin_Login_button
            // 
            this.Admin_Login_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Admin_Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin_Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Admin_Login_button.Location = new System.Drawing.Point(326, 348);
            this.Admin_Login_button.Name = "Admin_Login_button";
            this.Admin_Login_button.Size = new System.Drawing.Size(130, 45);
            this.Admin_Login_button.TabIndex = 9;
            this.Admin_Login_button.Text = "Login";
            this.Admin_Login_button.UseVisualStyleBackColor = false;
            this.Admin_Login_button.Click += new System.EventHandler(this.Admin_Login_button_Click);
            // 
            // Admin_cancel_label
            // 
            this.Admin_cancel_label.AutoSize = true;
            this.Admin_cancel_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin_cancel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_cancel_label.Location = new System.Drawing.Point(365, 414);
            this.Admin_cancel_label.Name = "Admin_cancel_label";
            this.Admin_cancel_label.Size = new System.Drawing.Size(61, 20);
            this.Admin_cancel_label.TabIndex = 10;
            this.Admin_cancel_label.TabStop = true;
            this.Admin_cancel_label.Text = "Cancel";
            this.Admin_cancel_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Admin_cancel_label_LinkClicked);
            // 
            // Adminpicture
            // 
            this.Adminpicture.Image = global::Dzaone_Appliance_Shop.Properties.Resources.login__1_1;
            this.Adminpicture.Location = new System.Drawing.Point(230, 93);
            this.Adminpicture.Name = "Adminpicture";
            this.Adminpicture.Size = new System.Drawing.Size(318, 119);
            this.Adminpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Adminpicture.TabIndex = 4;
            this.Adminpicture.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Admin_cancel_label);
            this.Controls.Add(this.Admin_Login_button);
            this.Controls.Add(this.Admin_textbox);
            this.Controls.Add(this.Admin_password_label);
            this.Controls.Add(this.Adminpicture);
            this.Controls.Add(this.Admin_text);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.Adminpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin_text;
        private System.Windows.Forms.PictureBox Adminpicture;
        private System.Windows.Forms.Label Admin_password_label;
        private System.Windows.Forms.TextBox Admin_textbox;
        private System.Windows.Forms.Button Admin_Login_button;
        private System.Windows.Forms.LinkLabel Admin_cancel_label;
    }
}