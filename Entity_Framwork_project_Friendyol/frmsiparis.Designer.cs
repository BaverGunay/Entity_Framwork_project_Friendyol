namespace Entity_Framwork_project_Friendyol
{
    partial class frmsiparis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonLIST = new System.Windows.Forms.Button();
            this.buttonTMZL = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.btnSepetEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDETAYSIL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SEC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.URUN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URUN_AD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIYAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtADET = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comUrun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comMusteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLIST
            // 
            this.buttonLIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLIST.ForeColor = System.Drawing.Color.Red;
            this.buttonLIST.Location = new System.Drawing.Point(8, 342);
            this.buttonLIST.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLIST.Name = "buttonLIST";
            this.buttonLIST.Size = new System.Drawing.Size(122, 52);
            this.buttonLIST.TabIndex = 27;
            this.buttonLIST.Text = "LISTELE";
            this.buttonLIST.UseVisualStyleBackColor = true;
            this.buttonLIST.Click += new System.EventHandler(this.buttonLIST_Click);
            // 
            // buttonTMZL
            // 
            this.buttonTMZL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTMZL.ForeColor = System.Drawing.Color.Red;
            this.buttonTMZL.Location = new System.Drawing.Point(8, 278);
            this.buttonTMZL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTMZL.Name = "buttonTMZL";
            this.buttonTMZL.Size = new System.Drawing.Size(122, 54);
            this.buttonTMZL.TabIndex = 26;
            this.buttonTMZL.Text = "TEMIZLE";
            this.buttonTMZL.UseVisualStyleBackColor = true;
            this.buttonTMZL.Click += new System.EventHandler(this.buttonTMZL_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 483);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(1127, 231);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.ForeColor = System.Drawing.Color.Red;
            this.btnSiparisVer.Location = new System.Drawing.Point(929, 290);
            this.btnSiparisVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(142, 71);
            this.btnSiparisVer.TabIndex = 24;
            this.btnSiparisVer.Text = "SIPARIS VER";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // btnSepetEkle
            // 
            this.btnSepetEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepetEkle.ForeColor = System.Drawing.Color.Red;
            this.btnSepetEkle.Location = new System.Drawing.Point(187, 278);
            this.btnSepetEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSepetEkle.Name = "btnSepetEkle";
            this.btnSepetEkle.Size = new System.Drawing.Size(142, 54);
            this.btnSepetEkle.TabIndex = 23;
            this.btnSepetEkle.Text = "SEPETE EKLE";
            this.btnSepetEkle.UseVisualStyleBackColor = true;
            this.btnSepetEkle.Click += new System.EventHandler(this.btnSepetEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(607, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "  SİPARİŞLER  ";
            // 
            // buttonDETAYSIL
            // 
            this.buttonDETAYSIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDETAYSIL.ForeColor = System.Drawing.Color.Red;
            this.buttonDETAYSIL.Location = new System.Drawing.Point(715, 290);
            this.buttonDETAYSIL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDETAYSIL.Name = "buttonDETAYSIL";
            this.buttonDETAYSIL.Size = new System.Drawing.Size(147, 71);
            this.buttonDETAYSIL.TabIndex = 28;
            this.buttonDETAYSIL.Text = "SEPETİ TEMİZLE";
            this.buttonDETAYSIL.UseVisualStyleBackColor = true;
            this.buttonDETAYSIL.Click += new System.EventHandler(this.buttonDETAYSIL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEC,
            this.URUN_ID,
            this.URUN_AD,
            this.FIYAT,
            this.ADET});
            this.dataGridView1.Location = new System.Drawing.Point(333, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(769, 198);
            this.dataGridView1.TabIndex = 21;
            // 
            // SEC
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            this.SEC.DefaultCellStyle = dataGridViewCellStyle2;
            this.SEC.HeaderText = "SEC";
            this.SEC.MinimumWidth = 8;
            this.SEC.Name = "SEC";
            this.SEC.Width = 150;
            // 
            // URUN_ID
            // 
            this.URUN_ID.HeaderText = "URUN_ID";
            this.URUN_ID.MinimumWidth = 8;
            this.URUN_ID.Name = "URUN_ID";
            this.URUN_ID.Width = 150;
            // 
            // URUN_AD
            // 
            this.URUN_AD.HeaderText = "URUN_AD";
            this.URUN_AD.MinimumWidth = 8;
            this.URUN_AD.Name = "URUN_AD";
            this.URUN_AD.Width = 150;
            // 
            // FIYAT
            // 
            this.FIYAT.HeaderText = "FIYAT";
            this.FIYAT.MinimumWidth = 8;
            this.FIYAT.Name = "FIYAT";
            this.FIYAT.Width = 150;
            // 
            // ADET
            // 
            this.ADET.HeaderText = "ADET";
            this.ADET.MinimumWidth = 8;
            this.ADET.Name = "ADET";
            this.ADET.Width = 150;
            // 
            // txtADET
            // 
            this.txtADET.Location = new System.Drawing.Point(110, 217);
            this.txtADET.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtADET.Name = "txtADET";
            this.txtADET.Size = new System.Drawing.Size(54, 26);
            this.txtADET.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(4, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "ADET";
            // 
            // comUrun
            // 
            this.comUrun.FormattingEnabled = true;
            this.comUrun.Location = new System.Drawing.Point(110, 129);
            this.comUrun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comUrun.Name = "comUrun";
            this.comUrun.Size = new System.Drawing.Size(180, 28);
            this.comUrun.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(4, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "ÜRÜN";
            // 
            // comMusteri
            // 
            this.comMusteri.FormattingEnabled = true;
            this.comMusteri.Location = new System.Drawing.Point(110, 58);
            this.comMusteri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comMusteri.Name = "comMusteri";
            this.comMusteri.Size = new System.Drawing.Size(180, 28);
            this.comMusteri.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "MÜŞTERİ";
            // 
            // frmsiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1127, 714);
            this.Controls.Add(this.buttonLIST);
            this.Controls.Add(this.buttonTMZL);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.btnSepetEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDETAYSIL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtADET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comUrun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comMusteri);
            this.Controls.Add(this.label1);
            this.Name = "frmsiparis";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frnsiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLIST;
        private System.Windows.Forms.Button buttonTMZL;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Button btnSepetEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDETAYSIL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUN_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUN_AD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIYAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADET;
        private System.Windows.Forms.TextBox txtADET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comMusteri;
        private System.Windows.Forms.Label label1;
    }
}