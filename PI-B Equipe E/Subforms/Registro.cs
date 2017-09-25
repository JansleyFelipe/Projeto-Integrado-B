using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Security.Cryptography;

namespace PI_B_Equipe_E
{
    public partial class Registro : UserControl
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void senha()
        {
            StringBuilder hash_final = new StringBuilder();

            {
                {
                    MD5CryptoServiceProvider code_hash = new MD5CryptoServiceProvider();

                    byte[] valores_hash = code_hash.ComputeHash(Encoding.Unicode.GetBytes(TXB_regpassword.Text));
                    for (int i = 0; i < valores_hash.Length; i++)
                    {
                        hash_final.Append(valores_hash[i].ToString("x2"));
                    }
                    code_hash.Dispose();
                }
            }

            MessageBox.Show(hash_final.ToString());
        }
    }
}
