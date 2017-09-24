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
    public partial class CalculadoraDeDatas : UserControl
    {
        public CalculadoraDeDatas()
        {
            InitializeComponent();
            DTP_nascimento.Value = DateTime.Today.Date;
        }

        private void BTN_idade_Click(object sender, EventArgs e)
        {
            if (DTP_nascimento.Value == DateTime.Today)
            {
                LBL_idade.Text = "0" + "\n" + "0" + "\n" + "0";
            }
            else
            {
                LBL_idade.Text = DateTime.Now.Subtract(DTP_nascimento.Value).TotalDays.ToString();
                LBL_idade.Text += "\n" + DateTime.Now.Subtract(DTP_nascimento.Value).TotalHours.ToString();
                LBL_idade.Text += "\n" + DTP_nascimento.Value;
            }
        }
    }
}
