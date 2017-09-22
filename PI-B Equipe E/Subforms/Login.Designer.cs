namespace PI_B_Equipe_E
{
    partial class Login
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
            this.TXB_login = new System.Windows.Forms.TextBox();
            this.TXB_senha = new System.Windows.Forms.TextBox();
            this.BTN_login = new System.Windows.Forms.Button();
            this.LBL_login = new System.Windows.Forms.Label();
            this.LBL_senha = new System.Windows.Forms.Label();
            this.LBL_errodeacesso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXB_login
            // 
            this.TXB_login.Location = new System.Drawing.Point(67, 4);
            this.TXB_login.Name = "TXB_login";
            this.TXB_login.Size = new System.Drawing.Size(227, 27);
            this.TXB_login.TabIndex = 0;
            // 
            // TXB_senha
            // 
            this.TXB_senha.Location = new System.Drawing.Point(67, 37);
            this.TXB_senha.Name = "TXB_senha";
            this.TXB_senha.PasswordChar = '*';
            this.TXB_senha.Size = new System.Drawing.Size(227, 27);
            this.TXB_senha.TabIndex = 1;
            this.TXB_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_senha_KeyPress);
            // 
            // BTN_login
            // 
            this.BTN_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_login.Location = new System.Drawing.Point(183, 70);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(111, 35);
            this.BTN_login.TabIndex = 2;
            this.BTN_login.Text = "Log In";
            this.BTN_login.UseVisualStyleBackColor = false;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click);
            // 
            // LBL_login
            // 
            this.LBL_login.AutoSize = true;
            this.LBL_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.LBL_login.Location = new System.Drawing.Point(3, 10);
            this.LBL_login.Name = "LBL_login";
            this.LBL_login.Size = new System.Drawing.Size(51, 19);
            this.LBL_login.TabIndex = 3;
            this.LBL_login.Text = "Login";
            // 
            // LBL_senha
            // 
            this.LBL_senha.AutoSize = true;
            this.LBL_senha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.LBL_senha.Location = new System.Drawing.Point(3, 43);
            this.LBL_senha.Name = "LBL_senha";
            this.LBL_senha.Size = new System.Drawing.Size(58, 19);
            this.LBL_senha.TabIndex = 4;
            this.LBL_senha.Text = "Senha";
            // 
            // LBL_errodeacesso
            // 
            this.LBL_errodeacesso.AutoSize = true;
            this.LBL_errodeacesso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_errodeacesso.ForeColor = System.Drawing.Color.Red;
            this.LBL_errodeacesso.Location = new System.Drawing.Point(3, 70);
            this.LBL_errodeacesso.Name = "LBL_errodeacesso";
            this.LBL_errodeacesso.Size = new System.Drawing.Size(49, 16);
            this.LBL_errodeacesso.TabIndex = 5;
            this.LBL_errodeacesso.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_errodeacesso);
            this.Controls.Add(this.LBL_senha);
            this.Controls.Add(this.LBL_login);
            this.Controls.Add(this.BTN_login);
            this.Controls.Add(this.TXB_senha);
            this.Controls.Add(this.TXB_login);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(297, 112);
            this.MinimumSize = new System.Drawing.Size(297, 112);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(297, 112);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_login;
        private System.Windows.Forms.TextBox TXB_senha;
        private System.Windows.Forms.Button BTN_login;
        private System.Windows.Forms.Label LBL_login;
        private System.Windows.Forms.Label LBL_senha;
        private System.Windows.Forms.Label LBL_errodeacesso;
    }
}
