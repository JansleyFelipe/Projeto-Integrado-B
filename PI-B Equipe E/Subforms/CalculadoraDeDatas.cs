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
        }

        private void BTN_idade_Click(object sender, EventArgs e)
        {
            LBL_idade.Text = DateTime.Now.Subtract(DTP_nascimento.Value).TotalDays.ToString();
            LBL_idade.Text += "\n" + DateTime.Now.Subtract(DTP_nascimento.Value).TotalHours.ToString();
            LBL_idade.Text = DateTime.Today.CompareTo(DTP_nascimento.Value).ToString();
        }
    }
}
