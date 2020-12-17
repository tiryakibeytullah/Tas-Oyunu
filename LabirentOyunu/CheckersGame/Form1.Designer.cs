namespace CheckersGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.G = new System.Windows.Forms.Panel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.lblAnaTasSayisi = new System.Windows.Forms.Label();
            this.lblDuvarSayisi = new System.Windows.Forms.Label();
            this.lblYesilTasSayisi = new System.Windows.Forms.Label();
            this.btnAnaTas = new System.Windows.Forms.Button();
            this.btnYesilTas = new System.Windows.Forms.Button();
            this.btnDuvarEkle = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.Gray;
            this.G.Location = new System.Drawing.Point(10, 10);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(484, 484);
            this.G.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "b.png");
            this.ımageList1.Images.SetKeyName(1, "d.png");
            this.ımageList1.Images.SetKeyName(2, "g.png");
            this.ımageList1.Images.SetKeyName(3, "r.png");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "b.png");
            this.ımageList2.Images.SetKeyName(1, "d.png");
            this.ımageList2.Images.SetKeyName(2, "g.png");
            this.ımageList2.Images.SetKeyName(3, "r.png");
            // 
            // lblAnaTasSayisi
            // 
            this.lblAnaTasSayisi.AutoSize = true;
            this.lblAnaTasSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblAnaTasSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnaTasSayisi.ForeColor = System.Drawing.Color.White;
            this.lblAnaTasSayisi.Location = new System.Drawing.Point(550, 70);
            this.lblAnaTasSayisi.Name = "lblAnaTasSayisi";
            this.lblAnaTasSayisi.Size = new System.Drawing.Size(0, 24);
            this.lblAnaTasSayisi.TabIndex = 4;
            // 
            // lblDuvarSayisi
            // 
            this.lblDuvarSayisi.AutoSize = true;
            this.lblDuvarSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblDuvarSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuvarSayisi.ForeColor = System.Drawing.Color.White;
            this.lblDuvarSayisi.Location = new System.Drawing.Point(657, 70);
            this.lblDuvarSayisi.Name = "lblDuvarSayisi";
            this.lblDuvarSayisi.Size = new System.Drawing.Size(0, 24);
            this.lblDuvarSayisi.TabIndex = 5;
            // 
            // lblYesilTasSayisi
            // 
            this.lblYesilTasSayisi.AutoSize = true;
            this.lblYesilTasSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblYesilTasSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesilTasSayisi.ForeColor = System.Drawing.Color.White;
            this.lblYesilTasSayisi.Location = new System.Drawing.Point(757, 70);
            this.lblYesilTasSayisi.Name = "lblYesilTasSayisi";
            this.lblYesilTasSayisi.Size = new System.Drawing.Size(0, 24);
            this.lblYesilTasSayisi.TabIndex = 6;
            // 
            // btnAnaTas
            // 
            this.btnAnaTas.BackColor = System.Drawing.Color.Transparent;
            this.btnAnaTas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnaTas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnaTas.ForeColor = System.Drawing.Color.Black;
            this.btnAnaTas.ImageIndex = 3;
            this.btnAnaTas.ImageList = this.ımageList1;
            this.btnAnaTas.Location = new System.Drawing.Point(512, 96);
            this.btnAnaTas.Name = "btnAnaTas";
            this.btnAnaTas.Size = new System.Drawing.Size(98, 67);
            this.btnAnaTas.TabIndex = 3;
            this.btnAnaTas.Text = "Ana Taş Ekle";
            this.btnAnaTas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnaTas.UseVisualStyleBackColor = false;
            this.btnAnaTas.Click += new System.EventHandler(this.btnAnaTas_Click);
            // 
            // btnYesilTas
            // 
            this.btnYesilTas.BackColor = System.Drawing.Color.Transparent;
            this.btnYesilTas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesilTas.ForeColor = System.Drawing.Color.Black;
            this.btnYesilTas.ImageIndex = 2;
            this.btnYesilTas.ImageList = this.ımageList1;
            this.btnYesilTas.Location = new System.Drawing.Point(718, 96);
            this.btnYesilTas.Name = "btnYesilTas";
            this.btnYesilTas.Size = new System.Drawing.Size(99, 67);
            this.btnYesilTas.TabIndex = 2;
            this.btnYesilTas.Text = "Yeşil Taş Ekle";
            this.btnYesilTas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYesilTas.UseVisualStyleBackColor = false;
            this.btnYesilTas.Click += new System.EventHandler(this.btnYesilTas_Click);
            // 
            // btnDuvarEkle
            // 
            this.btnDuvarEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnDuvarEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuvarEkle.ForeColor = System.Drawing.Color.Black;
            this.btnDuvarEkle.ImageIndex = 1;
            this.btnDuvarEkle.ImageList = this.ımageList2;
            this.btnDuvarEkle.Location = new System.Drawing.Point(616, 96);
            this.btnDuvarEkle.Name = "btnDuvarEkle";
            this.btnDuvarEkle.Size = new System.Drawing.Size(96, 67);
            this.btnDuvarEkle.TabIndex = 1;
            this.btnDuvarEkle.Text = "Duvar Ekle";
            this.btnDuvarEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDuvarEkle.UseVisualStyleBackColor = false;
            this.btnDuvarEkle.Click += new System.EventHandler(this.btnDuvarEkle_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(624, 10);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 31);
            this.lblLevel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(764, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(515, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seçili taşın Ana taşa uzaklığı : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CheckersGame.Properties.Resources.wallpaper2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblYesilTasSayisi);
            this.Controls.Add(this.lblDuvarSayisi);
            this.Controls.Add(this.lblAnaTasSayisi);
            this.Controls.Add(this.btnAnaTas);
            this.Controls.Add(this.btnYesilTas);
            this.Controls.Add(this.btnDuvarEkle);
            this.Controls.Add(this.G);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckersGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel G;
        private System.Windows.Forms.Button btnDuvarEkle;
        private System.Windows.Forms.Button btnYesilTas;
        private System.Windows.Forms.Button btnAnaTas;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Label lblAnaTasSayisi;
        private System.Windows.Forms.Label lblDuvarSayisi;
        private System.Windows.Forms.Label lblYesilTasSayisi;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

