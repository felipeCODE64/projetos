namespace AplicacaoCode64
{
    partial class frmSplash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.BarraProgressoSplash = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BarraProgressoSplash
            // 
            this.BarraProgressoSplash.BackColor = System.Drawing.SystemColors.Control;
            this.BarraProgressoSplash.ForeColor = System.Drawing.SystemColors.Control;
            this.BarraProgressoSplash.Location = new System.Drawing.Point(326, 322);
            this.BarraProgressoSplash.Margin = new System.Windows.Forms.Padding(0);
            this.BarraProgressoSplash.MarqueeAnimationSpeed = 10;
            this.BarraProgressoSplash.Name = "BarraProgressoSplash";
            this.BarraProgressoSplash.Size = new System.Drawing.Size(374, 10);
            this.BarraProgressoSplash.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.BarraProgressoSplash.TabIndex = 0;
            this.BarraProgressoSplash.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 524);
            this.ControlBox = false;
            this.Controls.Add(this.BarraProgressoSplash);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar BarraProgressoSplash;
    }
}

