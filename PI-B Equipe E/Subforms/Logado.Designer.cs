namespace PI_B_Equipe_E
{
    partial class Logado
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
            this.components = new System.ComponentModel.Container();
            this.PIC_logof = new System.Windows.Forms.PictureBox();
            this.LBL_loged = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TTP_ajuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_logof)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PIC_logof
            // 
            this.PIC_logof.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIC_logof.Image = global::PI_B_Equipe_E.Properties.Resources.exit;
            this.PIC_logof.Location = new System.Drawing.Point(233, 4);
            this.PIC_logof.Margin = new System.Windows.Forms.Padding(4);
            this.PIC_logof.Name = "PIC_logof";
            this.PIC_logof.Size = new System.Drawing.Size(60, 46);
            this.PIC_logof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_logof.TabIndex = 0;
            this.PIC_logof.TabStop = false;
            this.PIC_logof.Click += new System.EventHandler(this.PIC_logof_Click);
            // 
            // LBL_loged
            // 
            this.LBL_loged.AutoSize = true;
            this.LBL_loged.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBL_loged.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.LBL_loged.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBL_loged.Location = new System.Drawing.Point(239, 0);
            this.LBL_loged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_loged.Name = "LBL_loged";
            this.LBL_loged.Size = new System.Drawing.Size(58, 19);
            this.LBL_loged.TabIndex = 1;
            this.LBL_loged.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_loged);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 55);
            this.panel1.TabIndex = 2;
            // 
            // TTP_ajuda
            // 
            this.TTP_ajuda.ShowAlways = true;
            // 
            // Logado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PIC_logof);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(297, 112);
            this.MinimumSize = new System.Drawing.Size(297, 112);
            this.Name = "Logado";
            this.Size = new System.Drawing.Size(297, 112);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_logof)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PIC_logof;
        private System.Windows.Forms.Label LBL_loged;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip TTP_ajuda;
    }
}
