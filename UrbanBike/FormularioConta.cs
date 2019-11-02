using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanBike.classes;

namespace UrbanBike
{
    public partial class FormularioConta : Form
    {
        public FormularioConta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            frmUrbanBike form1 = new frmUrbanBike();
            foreach (var pedal in Ciclista.Pedais)
            {
                if (pedal.NumeroConta.ToString() == txbNumeroConta.Text.ToString())
                {
                    pedal.Creditar(double.Parse(txbSaldo.Text.ToString()));
                }
            }
            form1.Visible = true;
            Close();
        }

        private void chbPremium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumeroConta_Click(object sender, EventArgs e)
        {

        }
    }
}
