
using System;

namespace Dzaone_Appliance_Shop
{
    partial class Administrator_Dashboard
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Intro_text = new System.Windows.Forms.Label();
            this.administratorlogout_picture = new System.Windows.Forms.PictureBox();
            this.admin_datagridview = new System.Windows.Forms.DataGridView();
            this.admin_edit_button = new System.Windows.Forms.Button();
            this.admin_delete_button = new System.Windows.Forms.Button();
            this.admin_add_button = new System.Windows.Forms.Button();
            this.Appliance_category_cbox = new System.Windows.Forms.ComboBox();
            this.Appliance_price_box = new System.Windows.Forms.TextBox();
            this.Appliancebrandlabel = new System.Windows.Forms.Label();
            this.Appliancecategorylabel = new System.Windows.Forms.Label();
            this.Appliancequantitylabel = new System.Windows.Forms.Label();
            this.Appliancepricelabel = new System.Windows.Forms.Label();
            this.Appliancenamelabel = new System.Windows.Forms.Label();
            this.Appliance_brand_box = new System.Windows.Forms.TextBox();
            this.Appliance_quantity_box = new System.Windows.Forms.TextBox();
            this.Appliance_name_box = new System.Windows.Forms.TextBox();
            this.admin_refresh_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorlogout_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_panel
            // 
            this.picture_panel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.picture_panel.Location = new System.Drawing.Point(166, 1);
            this.picture_panel.Name = "picture_panel";
            this.picture_panel.Size = new System.Drawing.Size(5, 669);
            this.picture_panel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dzaone_Appliance_Shop.Properties.Resources.small_appliance2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Intro_text
            // 
            this.Intro_text.AutoSize = true;
            this.Intro_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intro_text.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Intro_text.Location = new System.Drawing.Point(434, 9);
            this.Intro_text.Name = "Intro_text";
            this.Intro_text.Size = new System.Drawing.Size(250, 25);
            this.Intro_text.TabIndex = 5;
            this.Intro_text.Text = "Administrator Dashboard";
            this.Intro_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // administratorlogout_picture
            // 
            this.administratorlogout_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.administratorlogout_picture.Image = global::Dzaone_Appliance_Shop.Properties.Resources.log_out__1_;
            this.administratorlogout_picture.Location = new System.Drawing.Point(21, 608);
            this.administratorlogout_picture.Name = "administratorlogout_picture";
            this.administratorlogout_picture.Size = new System.Drawing.Size(100, 50);
            this.administratorlogout_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.administratorlogout_picture.TabIndex = 8;
            this.administratorlogout_picture.TabStop = false;
            this.administratorlogout_picture.Click += new System.EventHandler(this.administratorlogout_picture_Click);
            // 
            // admin_datagridview
            // 
            this.admin_datagridview.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.admin_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_datagridview.GridColor = System.Drawing.Color.DodgerBlue;
            this.admin_datagridview.Location = new System.Drawing.Point(220, 256);
            this.admin_datagridview.Name = "admin_datagridview";
            this.admin_datagridview.RowHeadersWidth = 51;
            this.admin_datagridview.RowTemplate.Height = 24;
            this.admin_datagridview.Size = new System.Drawing.Size(850, 395);
            this.admin_datagridview.TabIndex = 37;
            // 
            // admin_edit_button
            // 
            this.admin_edit_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.admin_edit_button.ForeColor = System.Drawing.Color.White;
            this.admin_edit_button.Location = new System.Drawing.Point(533, 156);
            this.admin_edit_button.Name = "admin_edit_button";
            this.admin_edit_button.Size = new System.Drawing.Size(102, 44);
            this.admin_edit_button.TabIndex = 36;
            this.admin_edit_button.Text = "EDIT";
            this.admin_edit_button.UseVisualStyleBackColor = false;
            // 
            // admin_delete_button
            // 
            this.admin_delete_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.admin_delete_button.ForeColor = System.Drawing.Color.White;
            this.admin_delete_button.Location = new System.Drawing.Point(748, 156);
            this.admin_delete_button.Name = "admin_delete_button";
            this.admin_delete_button.Size = new System.Drawing.Size(102, 44);
            this.admin_delete_button.TabIndex = 35;
            this.admin_delete_button.Text = "DELETE";
            this.admin_delete_button.UseVisualStyleBackColor = false;
            // 
            // admin_add_button
            // 
            this.admin_add_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.admin_add_button.ForeColor = System.Drawing.Color.White;
            this.admin_add_button.Location = new System.Drawing.Point(317, 156);
            this.admin_add_button.Name = "admin_add_button";
            this.admin_add_button.Size = new System.Drawing.Size(102, 44);
            this.admin_add_button.TabIndex = 34;
            this.admin_add_button.Text = "ADD";
            this.admin_add_button.UseVisualStyleBackColor = false;
            this.admin_add_button.Click += new System.EventHandler(this.admin_add_button_Click);
            // 
            // Appliance_category_cbox
            // 
            this.Appliance_category_cbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Appliance_category_cbox.FormattingEnabled = true;
            this.Appliance_category_cbox.Items.AddRange(new object[] {
            "Refrigerator",
            "Microwave",
            "Cooker",
            "Blender",
            "Generator"});
            this.Appliance_category_cbox.Location = new System.Drawing.Point(573, 78);
            this.Appliance_category_cbox.Name = "Appliance_category_cbox";
            this.Appliance_category_cbox.Size = new System.Drawing.Size(121, 24);
            this.Appliance_category_cbox.TabIndex = 33;
            // 
            // Appliance_price_box
            // 
            this.Appliance_price_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Appliance_price_box.Location = new System.Drawing.Point(911, 78);
            this.Appliance_price_box.Multiline = true;
            this.Appliance_price_box.Name = "Appliance_price_box";
            this.Appliance_price_box.Size = new System.Drawing.Size(159, 22);
            this.Appliance_price_box.TabIndex = 32;
            // 
            // Appliancebrandlabel
            // 
            this.Appliancebrandlabel.AutoSize = true;
            this.Appliancebrandlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appliancebrandlabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Appliancebrandlabel.Location = new System.Drawing.Point(394, 51);
            this.Appliancebrandlabel.Name = "Appliancebrandlabel";
            this.Appliancebrandlabel.Size = new System.Drawing.Size(114, 18);
            this.Appliancebrandlabel.TabIndex = 31;
            this.Appliancebrandlabel.Text = "Appliance Brand";
            // 
            // Appliancecategorylabel
            // 
            this.Appliancecategorylabel.AutoSize = true;
            this.Appliancecategorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appliancecategorylabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Appliancecategorylabel.Location = new System.Drawing.Point(570, 51);
            this.Appliancecategorylabel.Name = "Appliancecategorylabel";
            this.Appliancecategorylabel.Size = new System.Drawing.Size(68, 18);
            this.Appliancecategorylabel.TabIndex = 30;
            this.Appliancecategorylabel.Text = "Category";
            // 
            // Appliancequantitylabel
            // 
            this.Appliancequantitylabel.AutoSize = true;
            this.Appliancequantitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appliancequantitylabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Appliancequantitylabel.Location = new System.Drawing.Point(719, 51);
            this.Appliancequantitylabel.Name = "Appliancequantitylabel";
            this.Appliancequantitylabel.Size = new System.Drawing.Size(62, 18);
            this.Appliancequantitylabel.TabIndex = 29;
            this.Appliancequantitylabel.Text = "Quantity";
            // 
            // Appliancepricelabel
            // 
            this.Appliancepricelabel.AutoSize = true;
            this.Appliancepricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appliancepricelabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Appliancepricelabel.Location = new System.Drawing.Point(908, 51);
            this.Appliancepricelabel.Name = "Appliancepricelabel";
            this.Appliancepricelabel.Size = new System.Drawing.Size(42, 18);
            this.Appliancepricelabel.TabIndex = 28;
            this.Appliancepricelabel.Text = "Price";
            // 
            // Appliancenamelabel
            // 
            this.Appliancenamelabel.AutoSize = true;
            this.Appliancenamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appliancenamelabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Appliancenamelabel.Location = new System.Drawing.Point(217, 51);
            this.Appliancenamelabel.Name = "Appliancenamelabel";
            this.Appliancenamelabel.Size = new System.Drawing.Size(115, 18);
            this.Appliancenamelabel.TabIndex = 27;
            this.Appliancenamelabel.Text = "Appliance Name";
            // 
            // Appliance_brand_box
            // 
            this.Appliance_brand_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Appliance_brand_box.Location = new System.Drawing.Point(397, 81);
            this.Appliance_brand_box.Multiline = true;
            this.Appliance_brand_box.Name = "Appliance_brand_box";
            this.Appliance_brand_box.Size = new System.Drawing.Size(159, 22);
            this.Appliance_brand_box.TabIndex = 26;
            // 
            // Appliance_quantity_box
            // 
            this.Appliance_quantity_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Appliance_quantity_box.Location = new System.Drawing.Point(722, 78);
            this.Appliance_quantity_box.Multiline = true;
            this.Appliance_quantity_box.Name = "Appliance_quantity_box";
            this.Appliance_quantity_box.Size = new System.Drawing.Size(159, 22);
            this.Appliance_quantity_box.TabIndex = 25;
            // 
            // Appliance_name_box
            // 
            this.Appliance_name_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Appliance_name_box.Location = new System.Drawing.Point(220, 81);
            this.Appliance_name_box.Multiline = true;
            this.Appliance_name_box.Name = "Appliance_name_box";
            this.Appliance_name_box.Size = new System.Drawing.Size(159, 22);
            this.Appliance_name_box.TabIndex = 24;
            // 
            // admin_refresh_button
            // 
            this.admin_refresh_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.admin_refresh_button.ForeColor = System.Drawing.Color.White;
            this.admin_refresh_button.Location = new System.Drawing.Point(911, 156);
            this.admin_refresh_button.Name = "admin_refresh_button";
            this.admin_refresh_button.Size = new System.Drawing.Size(102, 44);
            this.admin_refresh_button.TabIndex = 38;
            this.admin_refresh_button.Text = "REFRESH";
            this.admin_refresh_button.UseVisualStyleBackColor = false;
            // 
            // Administrator_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 670);
            this.Controls.Add(this.admin_refresh_button);
            this.Controls.Add(this.admin_datagridview);
            this.Controls.Add(this.admin_edit_button);
            this.Controls.Add(this.admin_delete_button);
            this.Controls.Add(this.admin_add_button);
            this.Controls.Add(this.Appliance_category_cbox);
            this.Controls.Add(this.Appliance_price_box);
            this.Controls.Add(this.Appliancebrandlabel);
            this.Controls.Add(this.Appliancecategorylabel);
            this.Controls.Add(this.Appliancequantitylabel);
            this.Controls.Add(this.Appliancepricelabel);
            this.Controls.Add(this.Appliancenamelabel);
            this.Controls.Add(this.Appliance_brand_box);
            this.Controls.Add(this.Appliance_quantity_box);
            this.Controls.Add(this.Appliance_name_box);
            this.Controls.Add(this.administratorlogout_picture);
            this.Controls.Add(this.Intro_text);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picture_panel);
            this.Name = "Administrator_Dashboard";
            this.Text = "Administrator_Dashboard";
            this.Load += new System.EventHandler(this.Administrator_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorlogout_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel picture_panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Intro_text;
        private System.Windows.Forms.PictureBox administratorlogout_picture;
        private System.Windows.Forms.DataGridView admin_datagridview;
        private System.Windows.Forms.Button admin_edit_button;
        private System.Windows.Forms.Button admin_delete_button;
        private System.Windows.Forms.Button admin_add_button;
        private System.Windows.Forms.ComboBox Appliance_category_cbox;
        private System.Windows.Forms.TextBox Appliance_price_box;
        private System.Windows.Forms.Label Appliancebrandlabel;
        private System.Windows.Forms.Label Appliancecategorylabel;
        private System.Windows.Forms.Label Appliancequantitylabel;
        private System.Windows.Forms.Label Appliancepricelabel;
        private System.Windows.Forms.Label Appliancenamelabel;
        private System.Windows.Forms.TextBox Appliance_brand_box;
        private System.Windows.Forms.TextBox Appliance_quantity_box;
        private System.Windows.Forms.TextBox Appliance_name_box;
        private System.Windows.Forms.Button admin_refresh_button;
    }
}