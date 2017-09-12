using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_B_Equipe_E
{
    public partial class Login : UserControl
    {
        
        public Login()
        {
            InitializeComponent();
            LBL_errodeacesso.Text = null;
        }

        private void BTN_login_Click(object sender, EventArgs e)
        {
            if (TXB_login.Text == "teste" && TXB_senha.Text == "PB2017")
            {
                Usuário.Loged = true;
                Usuário.Login = TXB_login.Text;
                Usuário.Nome = TXB_login.Text;
                Usuário.Email = TXB_login.Text;

                Logado status = new Logado(Usuário.Nome){Parent = Parent};

                foreach (Control obj in Parent.Controls)
                {
                    obj.Dispose();
                }

                status.Show();
            }
            else
            {
                if (string.IsNullOrEmpty(TXB_senha.Text))
                {
                    TXB_senha.Clear();
                    LBL_errodeacesso.Text = "Digite a senha!";
                }
                else if (string.IsNullOrEmpty(TXB_login.Text))
                {
                    TXB_login.Clear();
                    TXB_senha.Clear();
                    LBL_errodeacesso.Text = "Digite login e senha!";
                }
                else
                {
                    TXB_login.Clear();
                    TXB_senha.Clear();
                    LBL_errodeacesso.Text = "Login e/ou senha errados!";
                }
            }
        }
    }
}
