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
        List<string[]> datas_calendarios = new List<string[]>();
        
        public CalculadoraDeDatas()
        {
            InitializeComponent();
            DTP_nascimento.Value = DateTime.Today.Date;

            string[] dia11_02_2019= { "6 Adar I, 5779*", "5 Jumada t - Tania, 1440", "Porco de Terra" };
            string[] dia02_09_2017= { "11 Elul, 5777*", "10 Dhu I-Hijja, 1438", "Galo de Fogo" };
            string[] dia06_06_2014= { "8 Tamuz, 5774*", "8 Ramadan, 1435", "Cavalo de Madeira" };
            string[] dia25_10_2016= { "23 Tishrei, 5777*", "23 Muharram, 1438", "Macaco de Fogo" };
            string[] dia30_12_2018= { "22 Tavet, 5779*", "21 Rabi`ath-Thani, 1440", "Cão de Terra" };
            string[] dia09_01_2015= { "18 Tevet, 5775*", "18 Rabi `al-Awwal, 1436", "Cabra de Madeira" };
            string[] dia07_09_2014= { "12 Elul, 5774*", "12 Dhu I-Qa `da, 1435", "Cavalo de Madeira" };
            string[] dia28_10_2016= { "26 Tishrei, 5777*", "26 Muharram, 1438", "Macaco de Fogo" };
            string[] dia27_01_2017= { "29 Tevet, 5777*", "28 Rabi `ath-Thani, 1438", "Galo de Fogo" };
            string[] dia08_08_2016 = { "4 Av, 5776*", "4 Dhu I-Qa `da, 1437", "Macaco de Figo" };

            datas_calendarios.Add(dia11_02_2019);
            datas_calendarios.Add(dia02_09_2017);
            datas_calendarios.Add(dia06_06_2014);
            datas_calendarios.Add(dia25_10_2016);
            datas_calendarios.Add(dia30_12_2018);
            datas_calendarios.Add(dia09_01_2015);
            datas_calendarios.Add(dia07_09_2014);
            datas_calendarios.Add(dia28_10_2016);
            datas_calendarios.Add(dia27_01_2017);
            datas_calendarios.Add(dia08_08_2016);
        }

        private void BTN_idade_Click(object sender, EventArgs e)
        {
            if (DTP_nascimento.Value == DateTime.Today)
            {
                LBL_idade.Text = "Hoje é seu aniversário!\nPARABÉNS!!!";
            }
            else
            {
                int anos = ((DateTime.Today.Year - DTP_nascimento.Value.Year) + ((DateTime.Today.Month != DTP_nascimento.Value.Month) ? ((DateTime.Today.Month > DTP_nascimento.Value.Month) ? 0 : -1) : (DateTime.Today.Day >= DTP_nascimento.Value.Day) ? 0 : -1));
                int meses = (DateTime.Today.Month - DTP_nascimento.Value.Month) + (12 * (DateTime.Today.Year - DTP_nascimento.Value.Year));
                meses += (DateTime.Today.Day < DTP_nascimento.Value.Day) ? -1 : 0;
                int dias = Convert.ToInt32(DateTime.Now.Subtract(DTP_nascimento.Value).TotalDays);
                int horas = Convert.ToInt32(DateTime.Now.Subtract(DTP_nascimento.Value).TotalHours);

                LBL_idade.Text = "Anos: " + anos.ToString() + "\n" + "Meses: " + meses.ToString() + "\n" + "Dias: " + dias.ToString() + "\n" + "Horas: " + horas.ToString();
            }
        }

        private void BTN_limpar_Click(object sender, EventArgs e)
        {
            LBL_idade.Text = null;
        }

        private void Data_ValueChanged(object sender, EventArgs e)
        {
            if (DTP_datafinal.Value > DTP_datainicial.Value)
            {
                int total_em_anos = ((DTP_datafinal.Value.Year - DTP_datainicial.Value.Year) + ((DTP_datafinal.Value.Month != DTP_datainicial.Value.Month) ? ((DTP_datafinal.Value.Month - DTP_datainicial.Value.Month > 0) ? 0 : -1) : (DTP_datafinal.Value.Day >= DTP_datainicial.Value.Day) ? 0 : -1));
                int total_em_meses = (DTP_datafinal.Value.Month - DTP_datainicial.Value.Month) + (12 * (DTP_datafinal.Value.Year - DTP_datainicial.Value.Year));
                total_em_meses += (DTP_datafinal.Value.Day < DTP_datainicial.Value.Day) ? -1 : 0;
                int total_em_dias = Convert.ToInt32(DTP_datafinal.Value.Subtract(DTP_datainicial.Value).TotalDays);
                int total_em_semanas = total_em_dias / 7;
                int total_em_horas = Convert.ToInt32(DTP_datafinal.Value.Subtract(DTP_datainicial.Value).TotalHours);

                LBL_tempoentredatas.Text = total_em_anos.ToString() + " anos" + "\n" + total_em_meses.ToString() + " meses" + "\n" + total_em_semanas.ToString() + " semanas\n" + total_em_dias.ToString() + " dias\n" + total_em_horas.ToString() + " horas";
            }
            else if (DTP_datafinal.Value < DTP_datainicial.Value)
            {
                MessageBox.Show("A data final deve ser após a data de inicio");
                DTP_datainicial.Value = DateTime.Today;
                DTP_datafinal.Value = DTP_datainicial.Value;
            }
            else
            {
                LBL_tempoentredatas.Text = "";
            }

        }

        private void BTN_limpar2_Click(object sender, EventArgs e)
        {
            LBL_tempoentredatas.Text = null;
        }

        private void BTN_limpar3_Click(object sender, EventArgs e)
        {
            LBL_voltarnotempo.Text = null;
        }

        private void TXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox TXB = sender as TextBox;
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void BTN_voltarnotempo_Click(object sender, EventArgs e)
        {
            DateTime nova_data = DTP_data.Value;
            nova_data = (string.IsNullOrEmpty(TXB_dias.Text))? nova_data : nova_data.AddDays(double.Parse(TXB_dias.Text) * -1);
            nova_data = (string.IsNullOrEmpty(TXB_semanas.Text)) ? nova_data : nova_data.AddDays(double.Parse(TXB_semanas.Text) * 7 * -1);
            nova_data = (string.IsNullOrEmpty(TXB_meses.Text)) ? nova_data : nova_data.AddMonths(int.Parse(TXB_meses.Text) * -1);

            LBL_voltarnotempo.Text = nova_data.ToLongDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LBL_informacoes.Text = "O dia " + DTP_datainfo.Value.ToShortDateString() 
                + " é um" + ((DTP_datainfo.Value.DayOfWeek == DayOfWeek.Sunday || DTP_datainfo.Value.DayOfWeek == DayOfWeek.Saturday) ? " " : "a ") 
                + System.Globalization.DateTimeFormatInfo.CurrentInfo.GetDayName(DTP_datainfo.Value.DayOfWeek) 
                + " do mês de " + System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(DTP_datainfo.Value.Month).ToLower() 
                + ", é o dia de número " + DTP_datainfo.Value.DayOfYear + " do ano de " + DTP_datainfo.Value.Year 
                + (DateTime.IsLeapYear(DTP_datainfo.Value.Year)?" que é um ano bissexto.":" que não é um ano bissexto.");
        }

        private void BTN_limpar4_Click(object sender, EventArgs e)
        {
            LBL_informacoes.Text = null;
        }

        private void CMB_datas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LTB_outroscalendarios.Items.Clear();
            foreach(string data in datas_calendarios[CMB_datas.SelectedIndex])
            {
                LTB_outroscalendarios.Items.Add(data);
            }
        }
    }
}
