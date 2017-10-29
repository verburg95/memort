namespace Project_SoftwareOntwikkeling
{
    partial class Savegame
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
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.txtbox_savegame = new System.Windows.Forms.TextBox();
            this.txtbox_loadgame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_loadgame = new System.Windows.Forms.Label();
            this.Opslaandialog = new System.Windows.Forms.SaveFileDialog();
            this.Ladendialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(140, 175);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Opslaan";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(612, 175);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Laden";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txtbox_savegame
            // 
            this.txtbox_savegame.Location = new System.Drawing.Point(140, 79);
            this.txtbox_savegame.Name = "txtbox_savegame";
            this.txtbox_savegame.Size = new System.Drawing.Size(160, 22);
            this.txtbox_savegame.TabIndex = 2;
            this.txtbox_savegame.Text = "Voer naam in";
            // 
            // txtbox_loadgame
            // 
            this.txtbox_loadgame.Location = new System.Drawing.Point(612, 79);
            this.txtbox_loadgame.Name = "txtbox_loadgame";
            this.txtbox_loadgame.Size = new System.Drawing.Size(160, 22);
            this.txtbox_loadgame.TabIndex = 3;
            this.txtbox_loadgame.Text = "Voer naam in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Voer de naam van de game in die u wilt opslaan";
            // 
            // lbl_loadgame
            // 
            this.lbl_loadgame.AutoSize = true;
            this.lbl_loadgame.Location = new System.Drawing.Point(550, 36);
            this.lbl_loadgame.Name = "lbl_loadgame";
            this.lbl_loadgame.Size = new System.Drawing.Size(295, 17);
            this.lbl_loadgame.TabIndex = 5;
            this.lbl_loadgame.Text = "Voer de naam van de game in die u wilt laden";
            // 
            // Opslaandialog
            // 
            this.Opslaandialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Opslaandialog_FileOk);
            // 
            // Ladendialog
            // 
            this.Ladendialog.FileName = "openFileDialog1";
            // 
            // Savegame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 243);
            this.Controls.Add(this.lbl_loadgame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_loadgame);
            this.Controls.Add(this.txtbox_savegame);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Name = "Savegame";
            this.Text = "Savegame";
            this.Load += new System.EventHandler(this.Savegame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox txtbox_savegame;
        private System.Windows.Forms.TextBox txtbox_loadgame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_loadgame;
        private System.Windows.Forms.SaveFileDialog Opslaandialog;
        private System.Windows.Forms.OpenFileDialog Ladendialog;
    }
}