﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PI_B_Equipe_E
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Registro registro = new Registro() { Dock = DockStyle.Fill };
        Escala_de_temperatura escala_de_temperatura = new Escala_de_temperatura() { Dock = DockStyle.Fill };
        Sobre sobre = new Sobre() { Dock = DockStyle.Fill };
        CalculadoraDeDatas calculadoraDeDatas = new CalculadoraDeDatas() { Dock = DockStyle.Fill };

        List<Button> Botões = new List<Button>();
       
        public Form1()
        {
            InitializeComponent();
            Login login = new Login() { Parent = PNL_statuslogin };
            login.Show();
            sobre.Parent = PNL_principal;
            sobre.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control button in TBL_tabitems.Controls)
            {
                try
                {
                    Button BTN = button as Button;
                    Botões.Add(BTN);
                    TTP_info.SetToolTip(BTN, BTN.Tag.ToString());
                }
                catch
                {

                }
            }
        }

        private void BTN_optionX_Click(object sender, EventArgs e)
        {
            Button BTN = sender as Button;

            foreach (Button button in Botões)
            {
                if (BTN != button)
                {
                    button.BackColor = Color.FromArgb(250, 189, 63);
                    button.ForeColor = Color.Black;
                }
            }

            foreach (Control active in PNL_principal.Controls)
            {
                active.Hide();
            }

            switch (BTN.Tag)
            {
                case "Registro de novo usuário":
                    registro.Parent = PNL_principal;
                    registro.Show();
                    break;
                case "Escala de temperaturas":
                    escala_de_temperatura.Parent = PNL_principal;
                    escala_de_temperatura.Show();
                    break;
                case "Sobre":
                    sobre.Parent = PNL_principal;
                    sobre.Show();
                    break;
                case "Calculadora De Datas":
                    calculadoraDeDatas.Parent = PNL_principal;
                    calculadoraDeDatas.Dock = DockStyle.Fill;
                    calculadoraDeDatas.Show();
                    break;
            }

            BTN.BackColor = Color.DimGray;
            BTN.ForeColor = Color.FromArgb(250, 189, 63);
        }

        private void PIC_MouseEnter(object sender, EventArgs e)
        {
            PictureBox controle = sender as PictureBox;
            controle.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void PIC_MouseLeave(object sender, EventArgs e)
        {
            PictureBox controle = sender as PictureBox;
            controle.BackColor = Color.Transparent;
        }

        private void PIC_toggleform_Click(object sender, EventArgs e)
        {
            if (this.Size != this.MinimumSize)
            {
                this.Size = this.MinimumSize;
                this.CenterToScreen();
                PIC_toggleform.BackgroundImage = PI_B_Equipe_E.Properties.Resources.maximize;
            }
            else
            {
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.Bounds.Height - 40;

                this.Location = new Point();

                this.StartPosition = FormStartPosition.Manual;

                PIC_toggleform.BackgroundImage = PI_B_Equipe_E.Properties.Resources.minimize;
            }
        }

        private void PIC_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo fechar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void PIC_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PNL_header_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Size == this.MinimumSize)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void PNL_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void PNL_header_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            if (Cursor.Position.Y == 0)
            {
                PIC_toggleform_Click(PNL_header, e);
            }
        }

        private void PNL_header_DoubleClick(object sender, EventArgs e)
        {
            PIC_toggleform_Click(PNL_header, e);
        }

        private void PIC_home_Click(object sender, EventArgs e)
        {
            BTN_option0.PerformClick();
        }

        private void PNL_statuslogin_ControlAdded(object sender, ControlEventArgs e)
        {
            if (Usuário.Logado)
            {
                switch (Usuário.Permissao)
                {
                    case "administrador":
                        BTN_option3.Enabled = true;
                        BTN_option3.Visible = true;
                        break;
                    case "usuário":
                        break;
                }
            }
            else
            {
                BTN_option3.Enabled = false;
                BTN_option3.Visible = false;
                BTN_option0.PerformClick();
            }
        }
    }
}