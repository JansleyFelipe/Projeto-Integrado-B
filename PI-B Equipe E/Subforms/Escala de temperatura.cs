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
    public partial class Escala_de_temperatura : UserControl
    {
        public Escala_de_temperatura()
        {
            InitializeComponent();
            CBOescalas.SelectedIndex = 0;
        }

        private void TXTvalescala_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == ','))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',')
            {
                if (TXTvalescala.Text.Length == 0 || TXTvalescala.Text.Contains(','))
                {
                    e.Handled = true;
                }
            }
        }

        private void TXTvalescala_TextChanged(object sender, EventArgs e)
        {
            Temperaturas();

            try
            {
                double.Parse(TXTvalescala.Text);
            }
            catch
            {
                try
                {
                    TXTvalescala.Text = TXTvalescala.Text.Remove(TXTvalescala.Text.IndexOf(','), 1);
                }
                catch
                {

                }
            }
        }

        private void Temperaturas()
        {
            try
            {
                double C, K, F;

                double x = double.Parse(TXTvalescala.Text);

                if (CBOescalas.SelectedIndex == 0)
                {
                    K = x + 273;
                    F = 1.8 * x + 32;
                    C = x;
                }
                else if (CBOescalas.SelectedIndex == 1)
                {
                    C = x - 273;
                    F = 1.8 * C + 32;
                    K = x;
                }
                else
                {
                    C = (x - 32) / 1.8;
                    K = (x - 32) / 1.8 * C;
                    F = x;
                }

                LBLresposta.Text = "Celsius:" + "\n" + C.ToString("#.##") + "\n" + "\n" + "Kelvin:" + "\n" + K.ToString("#.##") + "\n" + "\n" + "Farenheit:" + "\n" + F.ToString("#.##");
            }
            catch
            {

            }
        }

        private void CBOescalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temperaturas();
        }
    }
}
