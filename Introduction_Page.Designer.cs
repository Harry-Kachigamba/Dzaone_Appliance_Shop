
namespace Dzaone_Appliance_Shop
{
    partial class Introduction_Page
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
            this.components = new System.ComponentModel.Container();
            this.Intro_text = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Progress_label = new System.Windows.Forms.Label();
            this.Percentage = new System.Windows.Forms.Label();
            this.intro_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Intro_text
            // 
            this.Intro_text.AutoSize = true;
            this.Intro_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intro_text.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Intro_text.Location = new System.Drawing.Point(122, 24);
            this.Intro_text.Name = "Intro_text";
            this.Intro_text.Size = new System.Drawing.Size(506, 51);
            this.Intro_text.TabIndex = 0;
            this.Intro_text.Text = "Dzaone Appliance Shop";
            this.Intro_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(28, 313);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(594, 10);
            this.progressBar.TabIndex = 2;
            // 
            // Progress_label
            // 
            this.Progress_label.AutoSize = true;
            this.Progress_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progress_label.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Progress_label.Location = new System.Drawing.Point(28, 290);
            this.Progress_label.Name = "Progress_label";
            this.Progress_label.Size = new System.Drawing.Size(80, 20);
            this.Progress_label.TabIndex = 3;
            this.Progress_label.Text = "Loading...";
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Percentage.Location = new System.Drawing.Point(116, 290);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(24, 20);
            this.Percentage.TabIndex = 4;
            this.Percentage.Text = "%";
            // 
            // intro_timer
            // 
            this.intro_timer.Tick += new System.EventHandler(this.intro_timer_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Dzaone_Appliance_Shop.Properties.Resources.small_appliance1;
            this.pictureBox3.Location = new System.Drawing.Point(175, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(298, 201);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // Introduction_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(660, 335);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Progress_label);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Intro_text);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Introduction_Page";
            this.Text = "Introduction";
            this.Load += new System.EventHandler(this.Introduction_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Intro_text;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label Progress_label;
        private System.Windows.Forms.Label Percentage;
        private System.Windows.Forms.Timer intro_timer;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

