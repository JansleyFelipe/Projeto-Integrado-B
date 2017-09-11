namespace PI_B_Equipe_E
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PNL_box = new System.Windows.Forms.Panel();
            this.PNL_home = new System.Windows.Forms.Panel();
            this.PNL_principal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBL_tabitems = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_option3 = new System.Windows.Forms.Button();
            this.BTN_option1 = new System.Windows.Forms.Button();
            this.BTN_option2 = new System.Windows.Forms.Button();
            this.PNL_header = new System.Windows.Forms.Panel();
            this.PNL_login = new System.Windows.Forms.Panel();
            this.PNL_statuslogin = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TLP_controlbox = new System.Windows.Forms.TableLayoutPanel();
            this.PIC_minimize = new System.Windows.Forms.PictureBox();
            this.PIC_close = new System.Windows.Forms.PictureBox();
            this.PIC_toggleform = new System.Windows.Forms.PictureBox();
            this.PIC_home = new System.Windows.Forms.PictureBox();
<<<<<<< HEAD
            this.TTP_info = new System.Windows.Forms.ToolTip(this.components);
            this.PNL_box.SuspendLayout();
            this.PNL_home.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TBL_tabitems.SuspendLayout();
            this.PNL_header.SuspendLayout();
            this.PNL_login.SuspendLayout();
            this.panel5.SuspendLayout();
            this.TLP_controlbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_minimize)).BeginInit();
=======
            this.PNL_box = new System.Windows.Forms.Panel();
            this.PNL_body = new System.Windows.Forms.Panel();
            this.PNL_header = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CBOescalas = new System.Windows.Forms.ComboBox();
            this.TXTvalescala = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBLresposta = new System.Windows.Forms.Label();
            this.BTNcalculo = new System.Windows.Forms.Button();
            this.TBC_main.SuspendLayout();
            this.TBP_home.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TBP_login.SuspendLayout();
            this.TBP_scales.SuspendLayout();
>>>>>>> 590eb9829141e478904b001ee953cc8632e67659
            ((System.ComponentModel.ISupportInitialize)(this.PIC_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_toggleform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_home)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_box
            // 
            this.PNL_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_box.Controls.Add(this.PNL_home);
            this.PNL_box.Controls.Add(this.PNL_header);
            this.PNL_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_box.Location = new System.Drawing.Point(0, 0);
            this.PNL_box.Name = "PNL_box";
            this.PNL_box.Size = new System.Drawing.Size(900, 570);
            this.PNL_box.TabIndex = 4;
            // 
            // PNL_home
            // 
            this.PNL_home.BackColor = System.Drawing.Color.Gray;
            this.PNL_home.Controls.Add(this.PNL_principal);
            this.PNL_home.Controls.Add(this.panel1);
            this.PNL_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_home.Location = new System.Drawing.Point(0, 149);
            this.PNL_home.Name = "PNL_home";
            this.PNL_home.Size = new System.Drawing.Size(898, 419);
            this.PNL_home.TabIndex = 0;
            // 
            // PNL_principal
            // 
            this.PNL_principal.BackColor = System.Drawing.Color.DimGray;
            this.PNL_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_principal.Location = new System.Drawing.Point(105, 0);
            this.PNL_principal.Name = "PNL_principal";
            this.PNL_principal.Size = new System.Drawing.Size(793, 419);
            this.PNL_principal.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.TBL_tabitems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 419);
            this.panel1.TabIndex = 1;
            // 
            // TBL_tabitems
            // 
            this.TBL_tabitems.BackColor = System.Drawing.Color.Transparent;
            this.TBL_tabitems.ColumnCount = 1;
            this.TBL_tabitems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TBL_tabitems.Controls.Add(this.button2, 0, 4);
            this.TBL_tabitems.Controls.Add(this.button1, 0, 3);
            this.TBL_tabitems.Controls.Add(this.BTN_option3, 0, 0);
            this.TBL_tabitems.Controls.Add(this.BTN_option1, 0, 1);
            this.TBL_tabitems.Controls.Add(this.BTN_option2, 0, 2);
            this.TBL_tabitems.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBL_tabitems.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TBL_tabitems.Location = new System.Drawing.Point(0, 0);
            this.TBL_tabitems.Margin = new System.Windows.Forms.Padding(0);
            this.TBL_tabitems.Name = "TBL_tabitems";
            this.TBL_tabitems.RowCount = 5;
            this.TBL_tabitems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_tabitems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_tabitems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_tabitems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_tabitems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_tabitems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TBL_tabitems.Size = new System.Drawing.Size(105, 276);
            this.TBL_tabitems.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 220);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 56);
            this.button2.TabIndex = 4;
            this.button2.Tag = "Escala de temperaturas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
<<<<<<< HEAD
            // button1
=======
            // TBP_scales
            // 
            this.TBP_scales.BackColor = System.Drawing.Color.Gray;
            this.TBP_scales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TBP_scales.Controls.Add(this.BTNcalculo);
            this.TBP_scales.Controls.Add(this.LBLresposta);
            this.TBP_scales.Controls.Add(this.label6);
            this.TBP_scales.Controls.Add(this.label5);
            this.TBP_scales.Controls.Add(this.TXTvalescala);
            this.TBP_scales.Controls.Add(this.CBOescalas);
            this.TBP_scales.Location = new System.Drawing.Point(154, 4);
            this.TBP_scales.Name = "TBP_scales";
            this.TBP_scales.Size = new System.Drawing.Size(1070, 451);
            this.TBP_scales.TabIndex = 2;
            this.TBP_scales.Text = "Escalas de temperatura";
>>>>>>> 590eb9829141e478904b001ee953cc8632e67659
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 55);
            this.button1.TabIndex = 3;
            this.button1.Tag = "Escala de temperaturas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // BTN_option3
            // 
            this.BTN_option3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.BTN_option3.BackgroundImage = global::PI_B_Equipe_E.Properties.Resources.about;
            this.BTN_option3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_option3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_option3.FlatAppearance.BorderSize = 0;
            this.BTN_option3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_option3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_option3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_option3.Location = new System.Drawing.Point(0, 0);
            this.BTN_option3.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_option3.Name = "BTN_option3";
            this.BTN_option3.Size = new System.Drawing.Size(105, 55);
            this.BTN_option3.TabIndex = 2;
            this.BTN_option3.Tag = "Sobre";
            this.BTN_option3.UseVisualStyleBackColor = false;
            this.BTN_option3.Click += new System.EventHandler(this.BTN_optionX_Click);
            // 
            // BTN_option1
            // 
            this.BTN_option1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.BTN_option1.BackgroundImage = global::PI_B_Equipe_E.Properties.Resources.newuser;
            this.BTN_option1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_option1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_option1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_option1.FlatAppearance.BorderSize = 0;
            this.BTN_option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_option1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_option1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_option1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_option1.ImageKey = "(nenhum/a)";
            this.BTN_option1.Location = new System.Drawing.Point(0, 55);
            this.BTN_option1.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_option1.Name = "BTN_option1";
            this.BTN_option1.Size = new System.Drawing.Size(105, 55);
            this.BTN_option1.TabIndex = 0;
            this.BTN_option1.Tag = "Registro de novo usuário";
            this.BTN_option1.UseVisualStyleBackColor = false;
            this.BTN_option1.Click += new System.EventHandler(this.BTN_optionX_Click);
            // 
            // BTN_option2
            // 
            this.BTN_option2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(63)))));
            this.BTN_option2.BackgroundImage = global::PI_B_Equipe_E.Properties.Resources.escala;
            this.BTN_option2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_option2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_option2.FlatAppearance.BorderSize = 0;
            this.BTN_option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_option2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_option2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_option2.Location = new System.Drawing.Point(0, 110);
            this.BTN_option2.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_option2.Name = "BTN_option2";
            this.BTN_option2.Size = new System.Drawing.Size(105, 55);
            this.BTN_option2.TabIndex = 1;
            this.BTN_option2.Tag = "Escala de temperaturas";
            this.BTN_option2.UseVisualStyleBackColor = false;
            this.BTN_option2.Click += new System.EventHandler(this.BTN_optionX_Click);
            // 
            // PNL_header
            // 
            this.PNL_header.BackColor = System.Drawing.Color.Black;
            this.PNL_header.Controls.Add(this.PNL_login);
            this.PNL_header.Controls.Add(this.PIC_home);
            this.PNL_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_header.Location = new System.Drawing.Point(0, 0);
            this.PNL_header.Name = "PNL_header";
            this.PNL_header.Size = new System.Drawing.Size(898, 149);
            this.PNL_header.TabIndex = 4;
            this.PNL_header.DoubleClick += new System.EventHandler(this.PNL_header_DoubleClick);
            this.PNL_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PNL_header_MouseDown);
            this.PNL_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PNL_header_MouseMove);
            this.PNL_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PNL_header_MouseUp);
            // 
            // PNL_login
            // 
            this.PNL_login.Controls.Add(this.PNL_statuslogin);
            this.PNL_login.Controls.Add(this.panel5);
            this.PNL_login.Dock = System.Windows.Forms.DockStyle.Right;
            this.PNL_login.Location = new System.Drawing.Point(601, 0);
            this.PNL_login.Name = "PNL_login";
            this.PNL_login.Size = new System.Drawing.Size(297, 149);
            this.PNL_login.TabIndex = 8;
            // 
            // PNL_statuslogin
            // 
            this.PNL_statuslogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_statuslogin.Location = new System.Drawing.Point(0, 37);
            this.PNL_statuslogin.Name = "PNL_statuslogin";
            this.PNL_statuslogin.Size = new System.Drawing.Size(297, 112);
            this.PNL_statuslogin.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TLP_controlbox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 37);
            this.panel5.TabIndex = 0;
            // 
            // TLP_controlbox
            // 
            this.TLP_controlbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLP_controlbox.ColumnCount = 4;
            this.TLP_controlbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0033F));
            this.TLP_controlbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0033F));
            this.TLP_controlbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0033F));
            this.TLP_controlbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9900991F));
            this.TLP_controlbox.Controls.Add(this.PIC_minimize, 0, 0);
            this.TLP_controlbox.Controls.Add(this.PIC_close, 2, 0);
            this.TLP_controlbox.Controls.Add(this.PIC_toggleform, 1, 0);
            this.TLP_controlbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.TLP_controlbox.Location = new System.Drawing.Point(165, 0);
            this.TLP_controlbox.Name = "TLP_controlbox";
            this.TLP_controlbox.RowCount = 1;
            this.TLP_controlbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_controlbox.Size = new System.Drawing.Size(132, 37);
            this.TLP_controlbox.TabIndex = 4;
            // 
            // PIC_minimize
            // 
            this.PIC_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PIC_minimize.BackgroundImage = global::PI_B_Equipe_E.Properties.Resources.minimize2;
            this.PIC_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PIC_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIC_minimize.Location = new System.Drawing.Point(3, 3);
            this.PIC_minimize.Name = "PIC_minimize";
            this.PIC_minimize.Size = new System.Drawing.Size(37, 27);
            this.PIC_minimize.TabIndex = 1;
            this.PIC_minimize.TabStop = false;
            this.PIC_minimize.Click += new System.EventHandler(this.PIC_minimize_Click);
            this.PIC_minimize.MouseEnter += new System.EventHandler(this.PIC_minimize_MouseEnter);
            this.PIC_minimize.MouseLeave += new System.EventHandler(this.PIC_minimize_MouseLeave);
            // 
            // PIC_close
            // 
            this.PIC_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PIC_close.BackgroundImage = global::PI_B_Equipe_E.Properties.Resources.closee;
            this.PIC_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PIC_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIC_close.Location = new System.Drawing.Point(89, 3);
            this.PIC_close.Name = "PIC_close";
            this.PIC_close.Size = new System.Drawing.Size(37, 27);
            this.PIC_close.TabIndex = 3;
            this.PIC_close.TabStop = false;
            this.PIC_close.Click += new System.EventHandler(this.PIC_close_Click);
            this.PIC_close.MouseEnter += new System.EventHandler(this.PIC_close_MouseEnter);
            this.PIC_close.MouseLeave += new System.EventHandler(this.PIC_close_MouseLeave);
            // 
            // PIC_toggleform
            // 
            this.PIC_toggleform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PIC_toggleform.BackgroundImage = global::PI_B_Equipe_E.Properties.Resources.maximize;
            this.PIC_toggleform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PIC_toggleform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIC_toggleform.Location = new System.Drawing.Point(46, 3);
            this.PIC_toggleform.Name = "PIC_toggleform";
            this.PIC_toggleform.Size = new System.Drawing.Size(37, 27);
            this.PIC_toggleform.TabIndex = 2;
            this.PIC_toggleform.TabStop = false;
            this.PIC_toggleform.Click += new System.EventHandler(this.PIC_toggleform_Click);
            this.PIC_toggleform.MouseEnter += new System.EventHandler(this.PIC_toggleform_MouseEnter);
            this.PIC_toggleform.MouseLeave += new System.EventHandler(this.PIC_toggleform_MouseLeave);
            // 
            // PIC_home
            // 
            this.PIC_home.BackgroundImage = global::PI_B_Equipe_E.Properties.Resources.Alssys1;
            this.PIC_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PIC_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIC_home.Dock = System.Windows.Forms.DockStyle.Left;
            this.PIC_home.InitialImage = global::PI_B_Equipe_E.Properties.Resources.Alssys1;
            this.PIC_home.Location = new System.Drawing.Point(0, 0);
            this.PIC_home.Name = "PIC_home";
            this.PIC_home.Size = new System.Drawing.Size(105, 149);
            this.PIC_home.TabIndex = 0;
            this.PIC_home.TabStop = false;
            this.PIC_home.Click += new System.EventHandler(this.PIC_home_Click);
            // 
            // TTP_info
            // 
            this.TTP_info.ShowAlways = true;
            // 
            // CBOescalas
            // 
            this.CBOescalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOescalas.FormattingEnabled = true;
            this.CBOescalas.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin",
            "Fahrenheit"});
            this.CBOescalas.Location = new System.Drawing.Point(61, 39);
            this.CBOescalas.Name = "CBOescalas";
            this.CBOescalas.Size = new System.Drawing.Size(230, 27);
            this.CBOescalas.TabIndex = 0;
            // 
            // TXTvalescala
            // 
            this.TXTvalescala.Location = new System.Drawing.Point(61, 122);
            this.TXTvalescala.Name = "TXTvalescala";
            this.TXTvalescala.Size = new System.Drawing.Size(230, 27);
            this.TXTvalescala.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Escolha a escala de entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Insira a temperatura:";
            // 
            // LBLresposta
            // 
            this.LBLresposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLresposta.Location = new System.Drawing.Point(402, 55);
            this.LBLresposta.Name = "LBLresposta";
            this.LBLresposta.Size = new System.Drawing.Size(230, 231);
            this.LBLresposta.TabIndex = 4;
            // 
            // BTNcalculo
            // 
            this.BTNcalculo.Location = new System.Drawing.Point(95, 215);
            this.BTNcalculo.Name = "BTNcalculo";
            this.BTNcalculo.Size = new System.Drawing.Size(108, 42);
            this.BTNcalculo.TabIndex = 5;
            this.BTNcalculo.Text = "Converter";
            this.BTNcalculo.UseVisualStyleBackColor = true;
            this.BTNcalculo.Click += new System.EventHandler(this.BTNcalculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.PNL_box);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(900, 570);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
<<<<<<< HEAD
            this.Text = "Allsys";
            this.PNL_box.ResumeLayout(false);
            this.PNL_home.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TBL_tabitems.ResumeLayout(false);
            this.PNL_header.ResumeLayout(false);
            this.PNL_login.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.TLP_controlbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_minimize)).EndInit();
=======
            this.Text = "Form1";
            this.TBC_main.ResumeLayout(false);
            this.TBP_home.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TBP_login.ResumeLayout(false);
            this.TBP_login.PerformLayout();
            this.TBP_scales.ResumeLayout(false);
            this.TBP_scales.PerformLayout();
>>>>>>> 590eb9829141e478904b001ee953cc8632e67659
            ((System.ComponentModel.ISupportInitialize)(this.PIC_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_toggleform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PIC_close;
        private System.Windows.Forms.PictureBox PIC_toggleform;
        private System.Windows.Forms.PictureBox PIC_minimize;
        private System.Windows.Forms.PictureBox PIC_home;
        private System.Windows.Forms.Panel PNL_box;
        private System.Windows.Forms.Panel PNL_header;
<<<<<<< HEAD
        private System.Windows.Forms.TableLayoutPanel TLP_controlbox;
        private System.Windows.Forms.Panel PNL_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TBL_tabitems;
        private System.Windows.Forms.Button BTN_option3;
        private System.Windows.Forms.Button BTN_option2;
        private System.Windows.Forms.Button BTN_option1;
        private System.Windows.Forms.Panel PNL_principal;
        private System.Windows.Forms.Panel PNL_login;
        private System.Windows.Forms.Panel PNL_statuslogin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolTip TTP_info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
=======
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage TBP_scales;
        private System.Windows.Forms.TabPage TBP_about;
        private System.Windows.Forms.TabPage TBP_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBOescalas;
        private System.Windows.Forms.Button BTNcalculo;
        private System.Windows.Forms.Label LBLresposta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTvalescala;
>>>>>>> 590eb9829141e478904b001ee953cc8632e67659
    }
}

