namespace PI_B_Equipe_E
{
    partial class CalculadoraDeDatas
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
            this.DTP_nascimento = new System.Windows.Forms.DateTimePicker();
            this.BTN_idade = new System.Windows.Forms.Button();
            this.LBL_idade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTP_nascimento
            // 
            this.DTP_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_nascimento.Location = new System.Drawing.Point(34, 24);
            this.DTP_nascimento.Name = "DTP_nascimento";
            this.DTP_nascimento.Size = new System.Drawing.Size(193, 27);
            this.DTP_nascimento.TabIndex = 0;
            this.DTP_nascimento.Value = new System.DateTime(2017, 9, 22, 0, 0, 0, 0);
            // 
            // BTN_idade
            // 
            this.BTN_idade.Location = new System.Drawing.Point(34, 57);
            this.BTN_idade.Name = "BTN_idade";
            this.BTN_idade.Size = new System.Drawing.Size(193, 51);
            this.BTN_idade.TabIndex = 1;
            this.BTN_idade.Text = "Calcular idade";
            this.BTN_idade.UseVisualStyleBackColor = true;
            this.BTN_idade.Click += new System.EventHandler(this.BTN_idade_Click);
            // 
            // LBL_idade
            // 
            this.LBL_idade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_idade.Location = new System.Drawing.Point(34, 111);
            this.LBL_idade.Name = "LBL_idade";
            this.LBL_idade.Size = new System.Drawing.Size(193, 145);
            this.LBL_idade.TabIndex = 2;
            // 
            // CalculadoraDeDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_idade);
            this.Controls.Add(this.BTN_idade);
            this.Controls.Add(this.DTP_nascimento);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(793, 419);
            this.MinimumSize = new System.Drawing.Size(793, 419);
            this.Name = "CalculadoraDeDatas";
            this.Size = new System.Drawing.Size(793, 419);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_nascimento;
        private System.Windows.Forms.Button BTN_idade;
        private System.Windows.Forms.Label LBL_idade;
    }
}
