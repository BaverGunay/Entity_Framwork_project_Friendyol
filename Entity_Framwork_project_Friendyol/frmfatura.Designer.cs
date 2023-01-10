namespace Entity_Framwork_project_Friendyol
{
    partial class frmfatura
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
            this.comMUSTERID = new System.Windows.Forms.ComboBox();
            this.comSIPARISID = new System.Windows.Forms.ComboBox();
            this.comFIRMAID = new System.Windows.Forms.ComboBox();
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
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SİPARİŞID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "FİRMAID";
            // 
            // comMUSTERID
            // 
            this.comMUSTERID.FormattingEnabled = true;
            this.comMUSTERID.Location = new System.Drawing.Point(157, 9);
            this.comMUSTERID.Name = "comMUSTERID";
            this.comMUSTERID.Size = new System.Drawing.Size(121, 28);
            this.comMUSTERID.TabIndex = 3;
            // 
            // comSIPARISID
            // 
            this.comSIPARISID.FormattingEnabled = true;
            this.comSIPARISID.Location = new System.Drawing.Point(157, 78);
            this.comSIPARISID.Name = "comSIPARISID";
            this.comSIPARISID.Size = new System.Drawing.Size(121, 28);
            this.comSIPARISID.TabIndex = 4;
            // 
            // comFIRMAID
            // 
            this.comFIRMAID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comFIRMAID.FormattingEnabled = true;
            this.comFIRMAID.Location = new System.Drawing.Point(157, 149);
            this.comFIRMAID.Name = "comFIRMAID";
            this.comFIRMAID.Size = new System.Drawing.Size(121, 28);
            this.comFIRMAID.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(847, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnLİSTELE
            // 
            this.btnLİSTELE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLİSTELE.ForeColor = System.Drawing.Color.Red;
            this.btnLİSTELE.Location = new System.Drawing.Point(392, 235);
            this.btnLİSTELE.Name = "btnLİSTELE";
            this.btnLİSTELE.Size = new System.Drawing.Size(105, 56);
            this.btnLİSTELE.TabIndex = 7;
            this.btnLİSTELE.Text = "LİSTELE";
            this.btnLİSTELE.UseVisualStyleBackColor = true;
            this.btnLİSTELE.Click += new System.EventHandler(this.btnLİSTELE_Click);
            // 
            // btnEKLE
            // 
            this.btnEKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEKLE.ForeColor = System.Drawing.Color.Red;
            this.btnEKLE.Location = new System.Drawing.Point(523, 235);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(107, 56);
            this.btnEKLE.TabIndex = 8;
            this.btnEKLE.Text = "EKLE";
            this.btnEKLE.UseVisualStyleBackColor = true;
            this.btnEKLE.Click += new System.EventHandler(this.btnEKLE_Click);
            // 
            // btnSİL
            // 
            this.btnSİL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSİL.ForeColor = System.Drawing.Color.Red;
            this.btnSİL.Location = new System.Drawing.Point(657, 235);
            this.btnSİL.Name = "btnSİL";
            this.btnSİL.Size = new System.Drawing.Size(94, 56);
            this.btnSİL.TabIndex = 9;
            this.btnSİL.Text = "SİL";
            this.btnSİL.UseVisualStyleBackColor = true;
            this.btnSİL.Click += new System.EventHandler(this.btnSİL_Click);
            // 
            // frmfatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 496);
            this.Controls.Add(this.btnSİL);
            this.Controls.Add(this.btnEKLE);
            this.Controls.Add(this.btnLİSTELE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comFIRMAID);
            this.Controls.Add(this.comSIPARISID);
            this.Controls.Add(this.comMUSTERID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmfatura";
            this.Text = "frmfatura";
            this.Load += new System.EventHandler(this.frmfatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comMUSTERID;
        private System.Windows.Forms.ComboBox comSIPARISID;
        private System.Windows.Forms.ComboBox comFIRMAID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLİSTELE;
        private System.Windows.Forms.Button btnEKLE;
        private System.Windows.Forms.Button btnSİL;
    }
}