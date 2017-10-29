namespace Project_SoftwareOntwikkeling
{
    partial class Hoofdmenu
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
            this.btn_start = new System.Windows.Forms.Button();
            this.picturebox_achtergrond = new System.Windows.Forms.PictureBox();
            this.picturebox_naam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_achtergrond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_naam)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(2, 98);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(204, 97);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // picturebox_achtergrond
            // 
            this.picturebox_achtergrond.Image = global::Project_SoftwareOntwikkeling.Properties.Resources.Waterfall;
            this.picturebox_achtergrond.Location = new System.Drawing.Point(212, 0);
            this.picturebox_achtergrond.Name = "picturebox_achtergrond";
            this.picturebox_achtergrond.Size = new System.Drawing.Size(775, 437);
            this.picturebox_achtergrond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picturebox_achtergrond.TabIndex = 1;
            this.picturebox_achtergrond.TabStop = false;
            // 
            // picturebox_naam
            // 
            this.picturebox_naam.Location = new System.Drawing.Point(2, 0);
            this.picturebox_naam.Name = "picturebox_naam";
            this.picturebox_naam.Size = new System.Drawing.Size(204, 92);
            this.picturebox_naam.TabIndex = 2;
            this.picturebox_naam.TabStop = false;
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 432);
            this.Controls.Add(this.picturebox_naam);
            this.Controls.Add(this.picturebox_achtergrond);
            this.Controls.Add(this.btn_start);
            this.Name = "Hoofdmenu";
            this.Text = "Hoofdmenu";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_achtergrond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_naam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox picturebox_achtergrond;
        private System.Windows.Forms.PictureBox picturebox_naam;
    }
}