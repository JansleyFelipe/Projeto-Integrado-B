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

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTimeOffset.Now.Subtract(dateTimePicker1.Value).ToString();
        }
    }
}
