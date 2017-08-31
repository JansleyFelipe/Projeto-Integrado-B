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
        private void TCB_main_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush BRS_text;

            TabPage TBP_selected = TBC_main.TabPages[e.Index];

            Rectangle TBI_item = TBC_main.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                BRS_text = new SolidBrush(Color.Orange);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                BRS_text = new System.Drawing.SolidBrush(e.ForeColor);
                g.FillRectangle(Brushes.Gray, e.Bounds);
                e.DrawBackground();
            }

            Font FNT_item = new Font("Century Gothic", (float)12.0, FontStyle.Bold, GraphicsUnit.Pixel);

            StringFormat ITX_itemtext = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(TBP_selected.Text, FNT_item, BRS_text, TBI_item, new StringFormat(ITX_itemtext));
        }

        private void PIC_home_Click(object sender, EventArgs e)
        {
            TBC_main.SelectedIndex = 0;
        }

        private void PIC_toggleform_Click(object sender, EventArgs e)
        {
            if (this.Size != this.MinimumSize)
            {
                this.Size = this.MinimumSize;
                this.CenterToScreen();
                PIC_toggleform.BackgroundImage = PI_B_Equipe_E.Properties.Resources.maximize;
            }
            else
            {
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.Bounds.Height - 40;

                this.Location = new Point();

                this.StartPosition = FormStartPosition.Manual;

                PIC_toggleform.BackgroundImage = PI_B_Equipe_E.Properties.Resources.minimize;
            }
        }

        private void PIC_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PIC_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PNL_header_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Size == this.MinimumSize)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void PNL_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void PNL_header_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            if (Cursor.Position.Y == 0)
            {
                PIC_toggleform_Click(PNL_header, e);
            }
        }

        private void TBC_main_Selected(object sender, TabControlEventArgs e)
        {
            if (TBC_main.SelectedIndex == 4)
            {
                if (MessageBox.Show("Deseja encerrar o programa?", "Sair", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    Close();
                }
                else
                {
                    PIC_home_Click(TBC_main, e);
                }
            }
        }

        private void PNL_header_DoubleClick(object sender, EventArgs e)
        {
            PIC_toggleform_Click(PNL_header, e);
        }
    }
}
