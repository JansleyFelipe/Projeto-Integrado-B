using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_B_Equipe_E
{
    public partial class Form1
    {
        private void LBL_recuperarsenha_MouseEnter(object sender, EventArgs e)
        {
            LBL_recuperarsenha.Font = new Font("Century Gothic", 12, FontStyle.Bold | FontStyle.Underline);
        }

        private void LBL_recuperarsenha_MouseLeave(object sender, EventArgs e)
        {
            LBL_recuperarsenha.Font = new Font("Century Gothic", 12, FontStyle.Bold);
        }

    }
}
