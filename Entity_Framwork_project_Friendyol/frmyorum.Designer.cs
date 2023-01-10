namespace Entity_Framwork_project_Friendyol
{
    partial class frmyorum
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
            this.comSiparisID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LİSTELE = new System.Windows.Forms.Button();
            this.EKLE = new System.Windows.Forms.Button();
            this.SİL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comYorum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comSiparisID
            // 
            this.comSiparisID.FormattingEnabled = true;
            this.comSiparisID.Location = new System.Drawing.Point(159, 20);
            this.comSiparisID.Name = "comSiparisID";
            this.comSiparisID.Size = new System.Drawing.Size(121, 28);
            this.comSiparisID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SİPARİŞID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(49, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "YORUM";
            // 
            // LİSTELE
            // 
            this.LİSTELE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LİSTELE.ForeColor = System.Drawing.Color.Red;
            this.LİSTELE.Location = new System.Drawing.Point(527, 86);
            this.LİSTELE.Name = "LİSTELE";
            this.LİSTELE.Size = new System.Drawing.Size(109, 59);
            this.LİSTELE.TabIndex = 4;
            this.LİSTELE.Text = "LİSTELE";
            this.LİSTELE.UseVisualStyleBackColor = true;
            this.LİSTELE.Click += new System.EventHandler(this.LİSTELE_Click);
            // 
            // EKLE
            // 
            this.EKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EKLE.ForeColor = System.Drawing.Color.Red;
            this.EKLE.Location = new System.Drawing.Point(666, 86);
            this.EKLE.Name = "EKLE";
            this.EKLE.Size = new System.Drawing.Size(109, 59);
            this.EKLE.TabIndex = 5;
            this.EKLE.Text = "EKLE";
            this.EKLE.UseVisualStyleBackColor = true;
            this.EKLE.Click += new System.EventHandler(this.EKLE_Click);
            // 
            // SİL
            // 
            this.SİL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SİL.ForeColor = System.Drawing.Color.Red;
            this.SİL.Location = new System.Drawing.Point(819, 86);
            this.SİL.Name = "SİL";
            this.SİL.Size = new System.Drawing.Size(109, 59);
            this.SİL.TabIndex = 6;
            this.SİL.Text = "SİL";
            this.SİL.UseVisualStyleBackColor = true;
            this.SİL.Click += new System.EventHandler(this.SİL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // comYorum
            // 
            this.comYorum.FormattingEnabled = true;
            this.comYorum.Items.AddRange(new object[] {
            "1  (çok kötü)",
            "2  (kötü)",
            "3  (orta)",
            "4  (iyi)",
            "5 (çok iyi)"});
            this.comYorum.Location = new System.Drawing.Point(159, 155);
            this.comYorum.Name = "comYorum";
            this.comYorum.Size = new System.Drawing.Size(121, 28);
            this.comYorum.TabIndex = 8;
            // 
            // frmyorum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 481);
            this.Controls.Add(this.comYorum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SİL);
            this.Controls.Add(this.EKLE);
            this.Controls.Add(this.LİSTELE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comSiparisID);
            this.Name = "frmyorum";
            this.Text = "frmyorum";
            this.Load += new System.EventHandler(this.frmyorum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comSiparisID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LİSTELE;
        private System.Windows.Forms.Button EKLE;
        private System.Windows.Forms.Button SİL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comYorum;
    }
}