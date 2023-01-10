namespace Entity_Framwork_project_Friendyol
{
    partial class frmfirmaBilgisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAD_SOYAD = new System.Windows.Forms.TextBox();
            this.txtADRES = new System.Windows.Forms.TextBox();
            this.txtTELEFON = new System.Windows.Forms.TextBox();
            this.txtEMAİL = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLİSTELE = new System.Windows.Forms.Button();
            this.btnEKLE = new System.Windows.Forms.Button();
            this.btnSİL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "EMAİL";
            // 
            // txtAD_SOYAD
            // 
            this.txtAD_SOYAD.Location = new System.Drawing.Point(145, 18);
            this.txtAD_SOYAD.Name = "txtAD_SOYAD";
            this.txtAD_SOYAD.Size = new System.Drawing.Size(100, 26);
            this.txtAD_SOYAD.TabIndex = 4;
            // 
            // txtADRES
            // 
            this.txtADRES.Location = new System.Drawing.Point(145, 64);
            this.txtADRES.Name = "txtADRES";
            this.txtADRES.Size = new System.Drawing.Size(100, 26);
            this.txtADRES.TabIndex = 5;
            // 
            // txtTELEFON
            // 
            this.txtTELEFON.Location = new System.Drawing.Point(145, 114);
            this.txtTELEFON.Name = "txtTELEFON";
            this.txtTELEFON.Size = new System.Drawing.Size(100, 26);
            this.txtTELEFON.TabIndex = 6;
            // 
            // txtEMAİL
            // 
            this.txtEMAİL.Location = new System.Drawing.Point(145, 171);
            this.txtEMAİL.Name = "txtEMAİL";
            this.txtEMAİL.Size = new System.Drawing.Size(100, 26);
            this.txtEMAİL.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(869, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnLİSTELE
            // 
            this.btnLİSTELE.Location = new System.Drawing.Point(582, 269);
            this.btnLİSTELE.Name = "btnLİSTELE";
            this.btnLİSTELE.Size = new System.Drawing.Size(118, 82);
            this.btnLİSTELE.TabIndex = 9;
            this.btnLİSTELE.Text = "LİSTELE";
            this.btnLİSTELE.UseVisualStyleBackColor = true;
            this.btnLİSTELE.Click += new System.EventHandler(this.btnLİSTELE_Click);
            // 
            // btnEKLE
            // 
            this.btnEKLE.Location = new System.Drawing.Point(455, 171);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(116, 89);
            this.btnEKLE.TabIndex = 10;
            this.btnEKLE.Text = "EKLE";
            this.btnEKLE.UseVisualStyleBackColor = true;
            this.btnEKLE.Click += new System.EventHandler(this.btnEKLE_Click);
            // 
            // btnSİL
            // 
            this.btnSİL.Location = new System.Drawing.Point(703, 171);
            this.btnSİL.Name = "btnSİL";
            this.btnSİL.Size = new System.Drawing.Size(110, 89);
            this.btnSİL.TabIndex = 11;
            this.btnSİL.Text = "SİL";
            this.btnSİL.UseVisualStyleBackColor = true;
            this.btnSİL.Click += new System.EventHandler(this.btnSİL_Click);
            // 
            // frmfirmaBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 516);
            this.Controls.Add(this.btnSİL);
            this.Controls.Add(this.btnEKLE);
            this.Controls.Add(this.btnLİSTELE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEMAİL);
            this.Controls.Add(this.txtTELEFON);
            this.Controls.Add(this.txtADRES);
            this.Controls.Add(this.txtAD_SOYAD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmfirmaBilgisi";
            this.Text = "frmfirmaBilgisi";
            this.Load += new System.EventHandler(this.frmfirmaBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAD_SOYAD;
        private System.Windows.Forms.TextBox txtADRES;
        private System.Windows.Forms.TextBox txtTELEFON;
        private System.Windows.Forms.TextBox txtEMAİL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLİSTELE;
        private System.Windows.Forms.Button btnEKLE;
        private System.Windows.Forms.Button btnSİL;
    }
}