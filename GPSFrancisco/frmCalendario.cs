using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFrancisco
{
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();
        }

        private void cldCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtCalendario.Text = "Daata Selecionada: Start = " + e.Start.ToShortDateString() + " : Final = " + e.End.ToShortDateString();
        }

        private void cldCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtCalendario.Text = "Daata Selecionada: Start = " + e.Start.ToShortDateString() + " : Final = " + e.End.ToShortDateString();
        }

        private void btnCarregadata_Click(object sender, EventArgs e)
        {
            //DateTime dt = new DateTime();
            DateTime dtNow = new DateTime(2025, 06, 09, 09, 47, 06);
            DateTime dataAtual = new DateTime();

            int dia = dataAtual.Day;
            int mes = dataAtual.Month;
            int ano = dataAtual.Year;

             dataAtual.TimeOfDay.Add(dataAtual.TimeOfDay);

            MessageBox.Show("Hora atual:" + dtNow + " Hora local:" + dataAtual);
        }
    }
}
