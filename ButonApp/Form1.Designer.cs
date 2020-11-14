namespace ButonApp
{
    partial class Form1
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
            this.time = new System.Windows.Forms.Timer(this.components);
            this.game = new System.Windows.Forms.Timer(this.components);
            this.pnlPuan = new System.Windows.Forms.Panel();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.pnlPuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // game
            // 
            this.game.Interval = 1000;
            this.game.Tick += new System.EventHandler(this.game_Tick);
            // 
            // pnlPuan
            // 
            this.pnlPuan.Controls.Add(this.lblSure);
            this.pnlPuan.Controls.Add(this.lblPuan);
            this.pnlPuan.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPuan.Location = new System.Drawing.Point(939, 0);
            this.pnlPuan.Name = "pnlPuan";
            this.pnlPuan.Size = new System.Drawing.Size(120, 554);
            this.pnlPuan.TabIndex = 0;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(6, 114);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 17);
            this.lblSure.TabIndex = 1;
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(3, 27);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(0, 17);
            this.lblPuan.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 554);
            this.Controls.Add(this.pnlPuan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPuan.ResumeLayout(false);
            this.pnlPuan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Timer game;
        private System.Windows.Forms.Panel pnlPuan;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblPuan;
    }
}

