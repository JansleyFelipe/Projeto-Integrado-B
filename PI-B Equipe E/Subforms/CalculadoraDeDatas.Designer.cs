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
            this.TBC_menudatas = new System.Windows.Forms.TabControl();
            this.TBP_idade = new System.Windows.Forms.TabPage();
            this.BTN_limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBP_tempoentredatas = new System.Windows.Forms.TabPage();
            this.BTN_limpar2 = new System.Windows.Forms.Button();
            this.LBL_tempoentredatas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_datafinal = new System.Windows.Forms.DateTimePicker();
            this.DTP_datainicial = new System.Windows.Forms.DateTimePicker();
            this.TBP_voltarnotempo = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.BTN_limpar3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.BTN_voltarnotempo = new System.Windows.Forms.Button();
            this.LBL_voltarnotempo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXB_meses = new System.Windows.Forms.TextBox();
            this.TXB_semanas = new System.Windows.Forms.TextBox();
            this.TXB_dias = new System.Windows.Forms.TextBox();
            this.DTP_data = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TBP_detalhesdata = new System.Windows.Forms.TabPage();
            this.BTN_limpar4 = new System.Windows.Forms.Button();
            this.LBL_informacoes = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DTP_datainfo = new System.Windows.Forms.DateTimePicker();
            this.TBP_outroscalendarios = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LTB_outroscalendarios = new System.Windows.Forms.ListBox();
            this.CMB_datas = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TBC_menudatas.SuspendLayout();
            this.TBP_idade.SuspendLayout();
            this.TBP_tempoentredatas.SuspendLayout();
            this.TBP_voltarnotempo.SuspendLayout();
            this.TBP_detalhesdata.SuspendLayout();
            this.TBP_outroscalendarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTP_nascimento
            // 
            this.DTP_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_nascimento.Location = new System.Drawing.Point(7, 55);
            this.DTP_nascimento.Name = "DTP_nascimento";
            this.DTP_nascimento.Size = new System.Drawing.Size(193, 27);
            this.DTP_nascimento.TabIndex = 0;
            this.DTP_nascimento.Value = new System.DateTime(2017, 9, 22, 0, 0, 0, 0);
            // 
            // BTN_idade
            // 
            this.BTN_idade.Location = new System.Drawing.Point(7, 88);
            this.BTN_idade.Name = "BTN_idade";
            this.BTN_idade.Size = new System.Drawing.Size(193, 51);
            this.BTN_idade.TabIndex = 1;
            this.BTN_idade.Text = "Calcular idade";
            this.BTN_idade.UseVisualStyleBackColor = true;
            this.BTN_idade.Click += new System.EventHandler(this.BTN_idade_Click);
            // 
            // LBL_idade
            // 
            this.LBL_idade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_idade.BackColor = System.Drawing.Color.Gray;
            this.LBL_idade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_idade.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_idade.ForeColor = System.Drawing.Color.White;
            this.LBL_idade.Location = new System.Drawing.Point(7, 142);
            this.LBL_idade.Name = "LBL_idade";
            this.LBL_idade.Size = new System.Drawing.Size(772, 191);
            this.LBL_idade.TabIndex = 2;
            this.LBL_idade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBC_menudatas
            // 
            this.TBC_menudatas.Controls.Add(this.TBP_idade);
            this.TBC_menudatas.Controls.Add(this.TBP_tempoentredatas);
            this.TBC_menudatas.Controls.Add(this.TBP_voltarnotempo);
            this.TBC_menudatas.Controls.Add(this.TBP_detalhesdata);
            this.TBC_menudatas.Controls.Add(this.TBP_outroscalendarios);
            this.TBC_menudatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBC_menudatas.Location = new System.Drawing.Point(0, 0);
            this.TBC_menudatas.Margin = new System.Windows.Forms.Padding(0);
            this.TBC_menudatas.Name = "TBC_menudatas";
            this.TBC_menudatas.Padding = new System.Drawing.Point(0, 0);
            this.TBC_menudatas.SelectedIndex = 0;
            this.TBC_menudatas.Size = new System.Drawing.Size(793, 419);
            this.TBC_menudatas.TabIndex = 3;
            // 
            // TBP_idade
            // 
            this.TBP_idade.BackColor = System.Drawing.Color.DimGray;
            this.TBP_idade.Controls.Add(this.BTN_limpar);
            this.TBP_idade.Controls.Add(this.label1);
            this.TBP_idade.Controls.Add(this.LBL_idade);
            this.TBP_idade.Controls.Add(this.DTP_nascimento);
            this.TBP_idade.Controls.Add(this.BTN_idade);
            this.TBP_idade.Location = new System.Drawing.Point(4, 30);
            this.TBP_idade.Name = "TBP_idade";
            this.TBP_idade.Padding = new System.Windows.Forms.Padding(3);
            this.TBP_idade.Size = new System.Drawing.Size(785, 385);
            this.TBP_idade.TabIndex = 0;
            this.TBP_idade.Text = "Cálculo de idade";
            // 
            // BTN_limpar
            // 
            this.BTN_limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_limpar.Location = new System.Drawing.Point(10, 337);
            this.BTN_limpar.Name = "BTN_limpar";
            this.BTN_limpar.Size = new System.Drawing.Size(190, 42);
            this.BTN_limpar.TabIndex = 4;
            this.BTN_limpar.Text = "Limpar";
            this.BTN_limpar.UseVisualStyleBackColor = true;
            this.BTN_limpar.Click += new System.EventHandler(this.BTN_limpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe sua data de nascimento";
            // 
            // TBP_tempoentredatas
            // 
            this.TBP_tempoentredatas.BackColor = System.Drawing.Color.DimGray;
            this.TBP_tempoentredatas.Controls.Add(this.BTN_limpar2);
            this.TBP_tempoentredatas.Controls.Add(this.LBL_tempoentredatas);
            this.TBP_tempoentredatas.Controls.Add(this.label5);
            this.TBP_tempoentredatas.Controls.Add(this.label4);
            this.TBP_tempoentredatas.Controls.Add(this.label3);
            this.TBP_tempoentredatas.Controls.Add(this.label2);
            this.TBP_tempoentredatas.Controls.Add(this.DTP_datafinal);
            this.TBP_tempoentredatas.Controls.Add(this.DTP_datainicial);
            this.TBP_tempoentredatas.Location = new System.Drawing.Point(4, 30);
            this.TBP_tempoentredatas.Name = "TBP_tempoentredatas";
            this.TBP_tempoentredatas.Padding = new System.Windows.Forms.Padding(3);
            this.TBP_tempoentredatas.Size = new System.Drawing.Size(785, 385);
            this.TBP_tempoentredatas.TabIndex = 1;
            this.TBP_tempoentredatas.Text = "Tempo entre datas";
            // 
            // BTN_limpar2
            // 
            this.BTN_limpar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_limpar2.Location = new System.Drawing.Point(44, 321);
            this.BTN_limpar2.Name = "BTN_limpar2";
            this.BTN_limpar2.Size = new System.Drawing.Size(173, 39);
            this.BTN_limpar2.TabIndex = 7;
            this.BTN_limpar2.Text = "Limpar";
            this.BTN_limpar2.UseVisualStyleBackColor = true;
            this.BTN_limpar2.Click += new System.EventHandler(this.BTN_limpar2_Click);
            // 
            // LBL_tempoentredatas
            // 
            this.LBL_tempoentredatas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_tempoentredatas.BackColor = System.Drawing.Color.Gray;
            this.LBL_tempoentredatas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_tempoentredatas.ForeColor = System.Drawing.Color.White;
            this.LBL_tempoentredatas.Location = new System.Drawing.Point(44, 133);
            this.LBL_tempoentredatas.Name = "LBL_tempoentredatas";
            this.LBL_tempoentredatas.Size = new System.Drawing.Size(445, 184);
            this.LBL_tempoentredatas.TabIndex = 6;
            this.LBL_tempoentredatas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label5.Location = new System.Drawing.Point(441, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "é de:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label4.Location = new System.Drawing.Point(296, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "e";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(44, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "O tempo entre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(44, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe as datas de inicio e fim";
            // 
            // DTP_datafinal
            // 
            this.DTP_datafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_datafinal.Location = new System.Drawing.Point(321, 82);
            this.DTP_datafinal.Name = "DTP_datafinal";
            this.DTP_datafinal.Size = new System.Drawing.Size(113, 27);
            this.DTP_datafinal.TabIndex = 1;
            this.DTP_datafinal.ValueChanged += new System.EventHandler(this.Data_ValueChanged);
            // 
            // DTP_datainicial
            // 
            this.DTP_datainicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_datainicial.Location = new System.Drawing.Point(177, 82);
            this.DTP_datainicial.Name = "DTP_datainicial";
            this.DTP_datainicial.Size = new System.Drawing.Size(113, 27);
            this.DTP_datainicial.TabIndex = 0;
            this.DTP_datainicial.ValueChanged += new System.EventHandler(this.Data_ValueChanged);
            // 
            // TBP_voltarnotempo
            // 
            this.TBP_voltarnotempo.BackColor = System.Drawing.Color.DimGray;
            this.TBP_voltarnotempo.Controls.Add(this.label10);
            this.TBP_voltarnotempo.Controls.Add(this.BTN_limpar3);
            this.TBP_voltarnotempo.Controls.Add(this.label11);
            this.TBP_voltarnotempo.Controls.Add(this.BTN_voltarnotempo);
            this.TBP_voltarnotempo.Controls.Add(this.LBL_voltarnotempo);
            this.TBP_voltarnotempo.Controls.Add(this.label9);
            this.TBP_voltarnotempo.Controls.Add(this.label8);
            this.TBP_voltarnotempo.Controls.Add(this.label7);
            this.TBP_voltarnotempo.Controls.Add(this.TXB_meses);
            this.TBP_voltarnotempo.Controls.Add(this.TXB_semanas);
            this.TBP_voltarnotempo.Controls.Add(this.TXB_dias);
            this.TBP_voltarnotempo.Controls.Add(this.DTP_data);
            this.TBP_voltarnotempo.Controls.Add(this.label6);
            this.TBP_voltarnotempo.Location = new System.Drawing.Point(4, 30);
            this.TBP_voltarnotempo.Name = "TBP_voltarnotempo";
            this.TBP_voltarnotempo.Size = new System.Drawing.Size(785, 385);
            this.TBP_voltarnotempo.TabIndex = 2;
            this.TBP_voltarnotempo.Text = "Voltando no tempo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label10.Location = new System.Drawing.Point(306, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Voltamos a data de:";
            // 
            // BTN_limpar3
            // 
            this.BTN_limpar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_limpar3.Location = new System.Drawing.Point(596, 274);
            this.BTN_limpar3.Name = "BTN_limpar3";
            this.BTN_limpar3.Size = new System.Drawing.Size(157, 40);
            this.BTN_limpar3.TabIndex = 11;
            this.BTN_limpar3.Text = "Limpar";
            this.BTN_limpar3.UseVisualStyleBackColor = true;
            this.BTN_limpar3.Click += new System.EventHandler(this.BTN_limpar3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label11.Location = new System.Drawing.Point(24, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Voltar:";
            // 
            // BTN_voltarnotempo
            // 
            this.BTN_voltarnotempo.Location = new System.Drawing.Point(28, 230);
            this.BTN_voltarnotempo.Name = "BTN_voltarnotempo";
            this.BTN_voltarnotempo.Size = new System.Drawing.Size(195, 41);
            this.BTN_voltarnotempo.TabIndex = 9;
            this.BTN_voltarnotempo.Text = "Voltar no tempo";
            this.BTN_voltarnotempo.UseVisualStyleBackColor = true;
            this.BTN_voltarnotempo.Click += new System.EventHandler(this.BTN_voltarnotempo_Click);
            // 
            // LBL_voltarnotempo
            // 
            this.LBL_voltarnotempo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_voltarnotempo.BackColor = System.Drawing.Color.Gray;
            this.LBL_voltarnotempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_voltarnotempo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_voltarnotempo.ForeColor = System.Drawing.Color.White;
            this.LBL_voltarnotempo.Location = new System.Drawing.Point(310, 54);
            this.LBL_voltarnotempo.Name = "LBL_voltarnotempo";
            this.LBL_voltarnotempo.Size = new System.Drawing.Size(443, 217);
            this.LBL_voltarnotempo.TabIndex = 8;
            this.LBL_voltarnotempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label9.Location = new System.Drawing.Point(142, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Meses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label8.Location = new System.Drawing.Point(142, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Semanas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label7.Location = new System.Drawing.Point(142, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dias";
            // 
            // TXB_meses
            // 
            this.TXB_meses.Location = new System.Drawing.Point(28, 197);
            this.TXB_meses.Name = "TXB_meses";
            this.TXB_meses.Size = new System.Drawing.Size(100, 27);
            this.TXB_meses.TabIndex = 4;
            this.TXB_meses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_KeyPress);
            // 
            // TXB_semanas
            // 
            this.TXB_semanas.Location = new System.Drawing.Point(28, 164);
            this.TXB_semanas.Name = "TXB_semanas";
            this.TXB_semanas.Size = new System.Drawing.Size(100, 27);
            this.TXB_semanas.TabIndex = 3;
            this.TXB_semanas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_KeyPress);
            // 
            // TXB_dias
            // 
            this.TXB_dias.Location = new System.Drawing.Point(28, 131);
            this.TXB_dias.Name = "TXB_dias";
            this.TXB_dias.Size = new System.Drawing.Size(100, 27);
            this.TXB_dias.TabIndex = 2;
            this.TXB_dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_KeyPress);
            // 
            // DTP_data
            // 
            this.DTP_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_data.Location = new System.Drawing.Point(28, 54);
            this.DTP_data.Name = "DTP_data";
            this.DTP_data.Size = new System.Drawing.Size(195, 27);
            this.DTP_data.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label6.Location = new System.Drawing.Point(24, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Informe a data inicial";
            // 
            // TBP_detalhesdata
            // 
            this.TBP_detalhesdata.BackColor = System.Drawing.Color.DimGray;
            this.TBP_detalhesdata.Controls.Add(this.BTN_limpar4);
            this.TBP_detalhesdata.Controls.Add(this.LBL_informacoes);
            this.TBP_detalhesdata.Controls.Add(this.label12);
            this.TBP_detalhesdata.Controls.Add(this.DTP_datainfo);
            this.TBP_detalhesdata.Location = new System.Drawing.Point(4, 30);
            this.TBP_detalhesdata.Name = "TBP_detalhesdata";
            this.TBP_detalhesdata.Padding = new System.Windows.Forms.Padding(3);
            this.TBP_detalhesdata.Size = new System.Drawing.Size(785, 385);
            this.TBP_detalhesdata.TabIndex = 3;
            this.TBP_detalhesdata.Text = "Detalhes da data";
            // 
            // BTN_limpar4
            // 
            this.BTN_limpar4.Location = new System.Drawing.Point(28, 320);
            this.BTN_limpar4.Name = "BTN_limpar4";
            this.BTN_limpar4.Size = new System.Drawing.Size(200, 40);
            this.BTN_limpar4.TabIndex = 4;
            this.BTN_limpar4.Text = "Limpar";
            this.BTN_limpar4.UseVisualStyleBackColor = true;
            this.BTN_limpar4.Click += new System.EventHandler(this.BTN_limpar4_Click);
            // 
            // LBL_informacoes
            // 
            this.LBL_informacoes.BackColor = System.Drawing.Color.Gray;
            this.LBL_informacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_informacoes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_informacoes.ForeColor = System.Drawing.Color.White;
            this.LBL_informacoes.Location = new System.Drawing.Point(28, 70);
            this.LBL_informacoes.Name = "LBL_informacoes";
            this.LBL_informacoes.Size = new System.Drawing.Size(718, 247);
            this.LBL_informacoes.TabIndex = 2;
            this.LBL_informacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label12.Location = new System.Drawing.Point(24, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Informe a data";
            // 
            // DTP_datainfo
            // 
            this.DTP_datainfo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_datainfo.Location = new System.Drawing.Point(28, 40);
            this.DTP_datainfo.Name = "DTP_datainfo";
            this.DTP_datainfo.Size = new System.Drawing.Size(200, 27);
            this.DTP_datainfo.TabIndex = 0;
            this.DTP_datainfo.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TBP_outroscalendarios
            // 
            this.TBP_outroscalendarios.BackColor = System.Drawing.Color.DimGray;
            this.TBP_outroscalendarios.Controls.Add(this.label17);
            this.TBP_outroscalendarios.Controls.Add(this.label16);
            this.TBP_outroscalendarios.Controls.Add(this.label15);
            this.TBP_outroscalendarios.Controls.Add(this.label14);
            this.TBP_outroscalendarios.Controls.Add(this.label13);
            this.TBP_outroscalendarios.Controls.Add(this.LTB_outroscalendarios);
            this.TBP_outroscalendarios.Controls.Add(this.CMB_datas);
            this.TBP_outroscalendarios.Location = new System.Drawing.Point(4, 30);
            this.TBP_outroscalendarios.Name = "TBP_outroscalendarios";
            this.TBP_outroscalendarios.Padding = new System.Windows.Forms.Padding(3);
            this.TBP_outroscalendarios.Size = new System.Drawing.Size(785, 385);
            this.TBP_outroscalendarios.TabIndex = 4;
            this.TBP_outroscalendarios.Text = "Outros Calendários";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label16.Location = new System.Drawing.Point(119, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 19);
            this.label16.TabIndex = 5;
            this.label16.Text = "Ano Chinês";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label15.Location = new System.Drawing.Point(20, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 19);
            this.label15.TabIndex = 4;
            this.label15.Text = "Calendário Mulçumano";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label14.Location = new System.Drawing.Point(51, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Calendário Judaico";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label13.Location = new System.Drawing.Point(66, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Escolha uma data";
            // 
            // LTB_outroscalendarios
            // 
            this.LTB_outroscalendarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LTB_outroscalendarios.FormattingEnabled = true;
            this.LTB_outroscalendarios.ItemHeight = 21;
            this.LTB_outroscalendarios.Location = new System.Drawing.Point(222, 189);
            this.LTB_outroscalendarios.Name = "LTB_outroscalendarios";
            this.LTB_outroscalendarios.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LTB_outroscalendarios.Size = new System.Drawing.Size(502, 67);
            this.LTB_outroscalendarios.TabIndex = 1;
            // 
            // CMB_datas
            // 
            this.CMB_datas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_datas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_datas.FormattingEnabled = true;
            this.CMB_datas.Items.AddRange(new object[] {
            "11 de fevereiro de 2019",
            "2 de setembro de 2017",
            "6 de julho de 2014",
            "25 de outubro de 2016",
            "30 de dezembro de 2018",
            "9 de janeiro de 2015",
            "7 de setembro de 2014",
            "28 de outubro de 2016",
            "27 de janeiro de 2017",
            "8 de agosto de 2016"});
            this.CMB_datas.Location = new System.Drawing.Point(222, 134);
            this.CMB_datas.Name = "CMB_datas";
            this.CMB_datas.Size = new System.Drawing.Size(502, 29);
            this.CMB_datas.TabIndex = 0;
            this.CMB_datas.SelectedIndexChanged += new System.EventHandler(this.CMB_datas_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.label17.Location = new System.Drawing.Point(66, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(457, 38);
            this.label17.TabIndex = 6;
            this.label17.Text = "Datas em outros calendários";
            // 
            // CalculadoraDeDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TBC_menudatas);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CalculadoraDeDatas";
            this.Size = new System.Drawing.Size(793, 419);
            this.TBC_menudatas.ResumeLayout(false);
            this.TBP_idade.ResumeLayout(false);
            this.TBP_idade.PerformLayout();
            this.TBP_tempoentredatas.ResumeLayout(false);
            this.TBP_tempoentredatas.PerformLayout();
            this.TBP_voltarnotempo.ResumeLayout(false);
            this.TBP_voltarnotempo.PerformLayout();
            this.TBP_detalhesdata.ResumeLayout(false);
            this.TBP_detalhesdata.PerformLayout();
            this.TBP_outroscalendarios.ResumeLayout(false);
            this.TBP_outroscalendarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_nascimento;
        private System.Windows.Forms.Button BTN_idade;
        private System.Windows.Forms.Label LBL_idade;
        private System.Windows.Forms.TabControl TBC_menudatas;
        private System.Windows.Forms.TabPage TBP_idade;
        private System.Windows.Forms.TabPage TBP_tempoentredatas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_limpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_datafinal;
        private System.Windows.Forms.DateTimePicker DTP_datainicial;
        private System.Windows.Forms.Label LBL_tempoentredatas;
        private System.Windows.Forms.Button BTN_limpar2;
        private System.Windows.Forms.TabPage TBP_voltarnotempo;
        private System.Windows.Forms.Label LBL_voltarnotempo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXB_meses;
        private System.Windows.Forms.TextBox TXB_semanas;
        private System.Windows.Forms.TextBox TXB_dias;
        private System.Windows.Forms.DateTimePicker DTP_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_limpar3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BTN_voltarnotempo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage TBP_detalhesdata;
        private System.Windows.Forms.Button BTN_limpar4;
        private System.Windows.Forms.Label LBL_informacoes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DTP_datainfo;
        private System.Windows.Forms.TabPage TBP_outroscalendarios;
        private System.Windows.Forms.ListBox LTB_outroscalendarios;
        private System.Windows.Forms.ComboBox CMB_datas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
    }
}
