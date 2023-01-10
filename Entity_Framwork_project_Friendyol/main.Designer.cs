namespace Entity_Framwork_project_Friendyol
{
    partial class main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yorumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablolarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablolarToolStripMenuItem
            // 
            this.tablolarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunToolStripMenuItem,
            this.siparisToolStripMenuItem,
            this.markaToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.siparişToolStripMenuItem,
            this.yorumToolStripMenuItem,
            this.kargoToolStripMenuItem,
            this.faturaToolStripMenuItem,
            this.firmaBilgisiToolStripMenuItem});
            this.tablolarToolStripMenuItem.Name = "tablolarToolStripMenuItem";
            this.tablolarToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.tablolarToolStripMenuItem.Text = "tablolar";
            // 
            // urunToolStripMenuItem
            // 
            this.urunToolStripMenuItem.Name = "urunToolStripMenuItem";
            this.urunToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.urunToolStripMenuItem.Text = "kategori";
            this.urunToolStripMenuItem.Click += new System.EventHandler(this.urunToolStripMenuItem_Click);
            // 
            // siparisToolStripMenuItem
            // 
            this.siparisToolStripMenuItem.Name = "siparisToolStripMenuItem";
            this.siparisToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.siparisToolStripMenuItem.Text = "urun";
            this.siparisToolStripMenuItem.Click += new System.EventHandler(this.siparisToolStripMenuItem_Click);
            // 
            // markaToolStripMenuItem
            // 
            this.markaToolStripMenuItem.Name = "markaToolStripMenuItem";
            this.markaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.markaToolStripMenuItem.Text = "marka";
            this.markaToolStripMenuItem.Click += new System.EventHandler(this.markaToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.müşteriToolStripMenuItem.Text = "müşteri";
            this.müşteriToolStripMenuItem.Click += new System.EventHandler(this.müşteriToolStripMenuItem_Click);
            // 
            // siparişToolStripMenuItem
            // 
            this.siparişToolStripMenuItem.Name = "siparişToolStripMenuItem";
            this.siparişToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.siparişToolStripMenuItem.Text = "sipariş";
            this.siparişToolStripMenuItem.Click += new System.EventHandler(this.siparişToolStripMenuItem_Click);
            // 
            // yorumToolStripMenuItem
            // 
            this.yorumToolStripMenuItem.Name = "yorumToolStripMenuItem";
            this.yorumToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.yorumToolStripMenuItem.Text = "yorum";
            this.yorumToolStripMenuItem.Click += new System.EventHandler(this.yorumToolStripMenuItem_Click);
            // 
            // kargoToolStripMenuItem
            // 
            this.kargoToolStripMenuItem.Name = "kargoToolStripMenuItem";
            this.kargoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kargoToolStripMenuItem.Text = "kargo";
            this.kargoToolStripMenuItem.Click += new System.EventHandler(this.kargoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.faturaToolStripMenuItem.Text = "fatura";
            this.faturaToolStripMenuItem.Click += new System.EventHandler(this.faturaToolStripMenuItem_Click);
            // 
            // firmaBilgisiToolStripMenuItem
            // 
            this.firmaBilgisiToolStripMenuItem.Name = "firmaBilgisiToolStripMenuItem";
            this.firmaBilgisiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.firmaBilgisiToolStripMenuItem.Text = "firma Bilgisi";
            this.firmaBilgisiToolStripMenuItem.Click += new System.EventHandler(this.firmaBilgisiToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 639);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablolarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yorumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaBilgisiToolStripMenuItem;
    }
}

