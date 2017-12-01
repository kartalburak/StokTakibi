namespace WF_StokPresentation
{
    partial class CariSorgulama
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
            this.dgvCariler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtunvanagore = new System.Windows.Forms.TextBox();
            this.rbalicilar = new System.Windows.Forms.RadioButton();
            this.rbsaticilar = new System.Windows.Forms.RadioButton();
            this.rbTumCariler = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCariler
            // 
            this.dgvCariler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariler.Location = new System.Drawing.Point(60, 122);
            this.dgvCariler.Name = "dgvCariler";
            this.dgvCariler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCariler.Size = new System.Drawing.Size(618, 334);
            this.dgvCariler.TabIndex = 0;
            this.dgvCariler.DoubleClick += new System.EventHandler(this.dgvCariler_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari ünvanına göre Arama";
            // 
            // txtunvanagore
            // 
            this.txtunvanagore.Location = new System.Drawing.Point(60, 79);
            this.txtunvanagore.Name = "txtunvanagore";
            this.txtunvanagore.Size = new System.Drawing.Size(129, 20);
            this.txtunvanagore.TabIndex = 2;
            this.txtunvanagore.TextChanged += new System.EventHandler(this.txtunvanagore_TextChanged);
            // 
            // rbalicilar
            // 
            this.rbalicilar.AutoSize = true;
            this.rbalicilar.Location = new System.Drawing.Point(270, 79);
            this.rbalicilar.Name = "rbalicilar";
            this.rbalicilar.Size = new System.Drawing.Size(55, 17);
            this.rbalicilar.TabIndex = 3;
            this.rbalicilar.TabStop = true;
            this.rbalicilar.Text = "Alıcılar";
            this.rbalicilar.UseVisualStyleBackColor = true;
            this.rbalicilar.CheckedChanged += new System.EventHandler(this.rbalicilar_CheckedChanged);
            // 
            // rbsaticilar
            // 
            this.rbsaticilar.AutoSize = true;
            this.rbsaticilar.Location = new System.Drawing.Point(361, 79);
            this.rbsaticilar.Name = "rbsaticilar";
            this.rbsaticilar.Size = new System.Drawing.Size(62, 17);
            this.rbsaticilar.TabIndex = 4;
            this.rbsaticilar.TabStop = true;
            this.rbsaticilar.Text = "Satıcılar";
            this.rbsaticilar.UseVisualStyleBackColor = true;
            this.rbsaticilar.CheckedChanged += new System.EventHandler(this.rbsaticilar_CheckedChanged);
            // 
            // rbTumCariler
            // 
            this.rbTumCariler.AutoSize = true;
            this.rbTumCariler.Location = new System.Drawing.Point(452, 79);
            this.rbTumCariler.Name = "rbTumCariler";
            this.rbTumCariler.Size = new System.Drawing.Size(78, 17);
            this.rbTumCariler.TabIndex = 5;
            this.rbTumCariler.TabStop = true;
            this.rbTumCariler.Text = "Tüm Cariler";
            this.rbTumCariler.UseVisualStyleBackColor = true;
            this.rbTumCariler.CheckedChanged += new System.EventHandler(this.rbTumCariler_CheckedChanged);
            // 
            // CariSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 520);
            this.Controls.Add(this.rbTumCariler);
            this.Controls.Add(this.rbsaticilar);
            this.Controls.Add(this.rbalicilar);
            this.Controls.Add(this.txtunvanagore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCariler);
            this.Name = "CariSorgulama";
            this.Text = "CariSorgulama";
            this.Load += new System.EventHandler(this.CariSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCariler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtunvanagore;
        private System.Windows.Forms.RadioButton rbalicilar;
        private System.Windows.Forms.RadioButton rbsaticilar;
        private System.Windows.Forms.RadioButton rbTumCariler;
    }
}