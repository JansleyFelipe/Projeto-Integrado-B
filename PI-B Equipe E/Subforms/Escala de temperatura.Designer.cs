namespace PI_B_Equipe_E
{
    partial class Escala_de_temperatura
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
            this.LBLresposta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTvalescala = new System.Windows.Forms.TextBox();
            this.CBOescalas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LBLresposta
            // 
            this.LBLresposta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLresposta.BackColor = System.Drawing.Color.White;
            this.LBLresposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLresposta.Location = new System.Drawing.Point(352, 16);
            this.LBLresposta.Name = "LBLresposta";
            this.LBLresposta.Size = new System.Drawing.Size(274, 266);
            this.LBLresposta.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.label6.Location = new System.Drawing.Point(21, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Insira a temperatura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.label5.Location = new System.Drawing.Point(21, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Escolha a escala de entrada:";
            // 
            // TXTvalescala
            // 
            this.TXTvalescala.Location = new System.Drawing.Point(25, 132);
            this.TXTvalescala.Name = "TXTvalescala";
            this.TXTvalescala.Size = new System.Drawing.Size(300, 27);
            this.TXTvalescala.TabIndex = 7;
            this.TXTvalescala.TextChanged += new System.EventHandler(this.TXTvalescala_TextChanged);
            this.TXTvalescala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTvalescala_KeyPress);
            // 
            // CBOescalas
            // 
            this.CBOescalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOescalas.FormattingEnabled = true;
            this.CBOescalas.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin",
            "Fahrenheit"});
            this.CBOescalas.Location = new System.Drawing.Point(25, 49);
            this.CBOescalas.Name = "CBOescalas";
            this.CBOescalas.Size = new System.Drawing.Size(300, 29);
            this.CBOescalas.TabIndex = 6;
            this.CBOescalas.SelectedIndexChanged += new System.EventHandler(this.CBOescalas_SelectedIndexChanged);
            // 
            // Escala_de_temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBLresposta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTvalescala);
            this.Controls.Add(this.CBOescalas);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1123, 419);
            this.Name = "Escala_de_temperatura";
            this.Size = new System.Drawing.Size(1123, 419);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLresposta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTvalescala;
        private System.Windows.Forms.ComboBox CBOescalas;
    }
}
