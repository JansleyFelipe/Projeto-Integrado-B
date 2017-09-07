using System;
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

        public Form1()
        {
            InitializeComponent();
        }
        double C, K, F;
        private void BTNcalculo_Click(object sender, EventArgs e)
        {
            double x = double.Parse(TXTvalescala.Text);
            string y = CBOescalas.ToString();
            try
            {
                
                if(y == "Celsius")
                {
                    K = x + 273;
                    F = 1.8 * x + 32;
                    C = x;
                }else if(y == "Kelvin")
                    {
                        C = x - 273;
                        F = 1.8 * C + 32;
                        K = x;
                 }else if(y == "Fahrenheit")
                    {
                        C = (x - 32) / 1.8;
                        K = (x - 32) / 1.8 * C;
                        F = x;
                    }
                LBLresposta.Text = Convert.ToString(C);
                LBLresposta.Text = Convert.ToString(F);
                LBLresposta.Text = Convert.ToString(K);
            }
            catch
            {

            }
        }
    }
}
