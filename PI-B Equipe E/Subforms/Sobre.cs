using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PI_B_Equipe_E
{
    public partial class Sobre : UserControl
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void Sobre_Load(object sender, EventArgs e)
        {
            LBL_sobre.Text = PI_B_Equipe_E.Properties.Resources.DescriçãoAllsys;
        }
    }
}
