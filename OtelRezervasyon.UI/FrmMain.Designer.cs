namespace OtelRezervasyon.UI
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.otelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizyonMisyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıslemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tumRaporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.otelToolStripMenuItem,
            this.vizyonMisyonToolStripMenuItem,
            this.ıslemlerToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.toolStripMenuItem1.Text = "Dosya";
            // 
            // otelToolStripMenuItem
            // 
            this.otelToolStripMenuItem.Name = "otelToolStripMenuItem";
            this.otelToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.otelToolStripMenuItem.Text = "Otel";
            // 
            // vizyonMisyonToolStripMenuItem
            // 
            this.vizyonMisyonToolStripMenuItem.Name = "vizyonMisyonToolStripMenuItem";
            this.vizyonMisyonToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.vizyonMisyonToolStripMenuItem.Text = "Vizyon Misyon";
            // 
            // ıslemlerToolStripMenuItem
            // 
            this.ıslemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem,
            this.odemeToolStripMenuItem});
            this.ıslemlerToolStripMenuItem.Name = "ıslemlerToolStripMenuItem";
            this.ıslemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.ıslemlerToolStripMenuItem.Text = "Islemler";
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.acToolStripMenuItem.Text = "Giriş İşlemleri";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // odemeToolStripMenuItem
            // 
            this.odemeToolStripMenuItem.Name = "odemeToolStripMenuItem";
            this.odemeToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.odemeToolStripMenuItem.Text = "Ödeme-Çıkış İşlemleri";
            this.odemeToolStripMenuItem.Click += new System.EventHandler(this.odemeToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tumRaporlarToolStripMenuItem});
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // tumRaporlarToolStripMenuItem
            // 
            this.tumRaporlarToolStripMenuItem.Name = "tumRaporlarToolStripMenuItem";
            this.tumRaporlarToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.tumRaporlarToolStripMenuItem.Text = "Tüm Raporlar";
            this.tumRaporlarToolStripMenuItem.Click += new System.EventHandler(this.tumRaporlarToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizyonMisyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıslemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tumRaporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odemeToolStripMenuItem;
    }
}