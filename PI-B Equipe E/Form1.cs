﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_B_Equipe_E
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        Registro registro = new Registro();
        Escala_de_temperatura escala_de_temperatura = new Escala_de_temperatura();
        Sobre sobre = new Sobre();
        CalculadoraDeDatas calculadoraDeDatas = new CalculadoraDeDatas();

        public Form1()
        {
            InitializeComponent();
            Login login = new Login() { Parent = PNL_statuslogin };
            login.Show();

            TTP_info.SetToolTip(BTN_option1, BTN_option1.Tag.ToString());
            TTP_info.SetToolTip(BTN_option2, BTN_option2.Tag.ToString());
            TTP_info.SetToolTip(BTN_option0, BTN_option0.Tag.ToString());
            TTP_info.SetToolTip(BTN_option3, BTN_option3.Tag.ToString());
        }

        private void BTN_optionX_Click(object sender, EventArgs e)
        {
            Button BTN = sender as Button;

            foreach (Control btn in TBL_tabitems.Controls)
            {
                try
                {
                    Button button_opt = btn as Button;

                    if (BTN != button_opt)
                    {
                        button_opt.BackColor = Color.FromArgb(250, 189, 63);
                        button_opt.ForeColor = Color.Black;
                    }
                }
                catch { }
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
                    calculadoraDeDatas.Show();
                    break;
            }

            BTN.BackColor = Color.DimGray;
            BTN.ForeColor = Color.FromArgb(250, 189, 63);
        }

        private void PIC_close_MouseEnter(object sender, EventArgs e)
        {
            PIC_close.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void PIC_close_MouseLeave(object sender, EventArgs e)
        {
            PIC_close.BackColor = Color.Transparent;
        }

        private void PIC_toggleform_MouseEnter(object sender, EventArgs e)
        {
            PIC_toggleform.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void PIC_toggleform_MouseLeave(object sender, EventArgs e)
        {
            PIC_toggleform.BackColor = Color.Transparent;
        }

        private void PIC_minimize_MouseEnter(object sender, EventArgs e)
        {
            PIC_minimize.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void PIC_minimize_MouseLeave(object sender, EventArgs e)
        {
            PIC_minimize.BackColor = Color.Transparent;
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
            if(MessageBox.Show("Deseja mesmo fechar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        }
    }
}