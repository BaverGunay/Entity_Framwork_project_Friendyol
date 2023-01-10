namespace Entity_Framwork_project_Friendyol
{
    partial class frmkargo
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
            this.LİSTELE = new System.Windows.Forms.Button();
            this.EKLE = new System.Windows.Forms.Button();
            this.SİL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKargoAD = new System.Windows.Forms.TextBox();
            this.txtKargoTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KARGO ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "KARGO TEL";
            // 
            // LİSTELE
            // 
            this.LİSTELE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LİSTELE.ForeColor = System.Drawing.Color.Red;
            this.LİSTELE.Location = new System.Drawing.Point(355, 65);
            this.LİSTELE.Name = "LİSTELE";
            this.LİSTELE.Size = new System.Drawing.Size(113, 84);
            this.LİSTELE.TabIndex = 2;
            this.LİSTELE.Text = "LİSTELE";
            this.LİSTELE.UseVisualStyleBackColor = true;
            this.LİSTELE.Click += new System.EventHandler(this.LİSTELE_Click);
            // 
            // EKLE
            // 
            this.EKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EKLE.ForeColor = System.Drawing.Color.Red;
            this.EKLE.Location = new System.Drawing.Point(518, 65);
            this.EKLE.Name = "EKLE";
            this.EKLE.Size = new System.Drawing.Size(104, 84);
            this.EKLE.TabIndex = 3;
            this.EKLE.Text = "EKLE";
            this.EKLE.UseVisualStyleBackColor = true;
            this.EKLE.Click += new System.EventHandler(this.EKLE_Click);
            // 
            // SİL
            // 
            this.SİL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SİL.ForeColor = System.Drawing.Color.Red;
            this.SİL.Location = new System.Drawing.Point(683, 65);
            this.SİL.Name = "SİL";
            this.SİL.Size = new System.Drawing.Size(105, 84);
            this.SİL.TabIndex = 4;
            this.SİL.Text = "SİL";
            this.SİL.UseVisualStyleBackColor = true;
            this.SİL.Click += new System.EventHandler(this.SİL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtKargoAD
            // 
            this.txtKargoAD.Location = new System.Drawing.Point(142, 34);
            this.txtKargoAD.Name = "txtKargoAD";
            this.txtKargoAD.Size = new System.Drawing.Size(170, 26);
            this.txtKargoAD.TabIndex = 6;
            // 
            // txtKargoTel
            // 
            this.txtKargoTel.Location = new System.Drawing.Point(142, 129);
            this.txtKargoTel.Name = "txtKargoTel";
            this.txtKargoTel.Size = new System.Drawing.Size(170, 26);
            this.txtKargoTel.TabIndex = 7;
            // 
            // frmkargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKargoTel);
            this.Controls.Add(this.txtKargoAD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SİL);
            this.Controls.Add(this.EKLE);
            this.Controls.Add(this.LİSTELE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmkargo";
            this.Text = "frmkargo";
            this.Load += new System.EventHandler(this.frmkargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LİSTELE;
        private System.Windows.Forms.Button EKLE;
        private System.Windows.Forms.Button SİL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKargoAD;
        private System.Windows.Forms.TextBox txtKargoTel;
    }
}