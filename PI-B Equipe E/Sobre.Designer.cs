namespace PI_B_Equipe_E
{
    partial class Sobre
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PIC_about = new System.Windows.Forms.PictureBox();
            this.LBL_sobre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_about)).BeginInit();
            this.SuspendLayout();
            // 
            // PIC_about
            // 
            this.PIC_about.Image = global::PI_B_Equipe_E.Properties.Resources.Alssys1;
            this.PIC_about.Location = new System.Drawing.Point(3, 39);
            this.PIC_about.Name = "PIC_about";
            this.PIC_about.Size = new System.Drawing.Size(352, 312);
            this.PIC_about.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_about.TabIndex = 0;
            this.PIC_about.TabStop = false;
            // 
            // LBL_sobre
            // 
            this.LBL_sobre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBL_sobre.Location = new System.Drawing.Point(361, 39);
            this.LBL_sobre.Name = "LBL_sobre";
            this.LBL_sobre.Size = new System.Drawing.Size(596, 312);
            this.LBL_sobre.TabIndex = 1;
            this.LBL_sobre.Text = "label1";
            this.LBL_sobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.LBL_sobre);
            this.Controls.Add(this.PIC_about);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(960, 419);
            this.Name = "Sobre";
            this.Size = new System.Drawing.Size(960, 419);
            this.Load += new System.EventHandler(this.Sobre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_about)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PIC_about;
        private System.Windows.Forms.Label LBL_sobre;
    }
}
