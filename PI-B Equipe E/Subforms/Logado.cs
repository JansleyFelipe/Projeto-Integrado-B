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
    public partial class Logado : UserControl
    {
        public Logado(string nome_usuario)
        {
            InitializeComponent();
            TTP_ajuda.SetToolTip(PIC_logof, "Logout");
            LBL_loged.Text = "Bem bvindo, " + nome_usuario;
        }

        private void PIC_logof_Click(object sender, EventArgs e)
        {
            Usuário.Logoff();

            Login login = new Login() { Parent = Parent };

            foreach (Control obj in Parent.Controls)
            {
                obj.Dispose();
            }

            login.Show();
        }
    }
}
