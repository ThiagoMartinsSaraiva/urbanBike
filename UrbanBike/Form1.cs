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
    public partial class frmUrbanBike : Form
    {
        public frmUrbanBike()
        {
            InitializeComponent();
        }

        private void btnCriarPedal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemoverPedal_Click(object sender, EventArgs e)
        {
            Ciclista c = new Ciclista();
            int indexRow = dgvPedais.CurrentCell.RowIndex;
            var conteudo = dgvPedais.Rows[indexRow].Cells[0].Value;
            var contaAtual = Ciclista.Pedais.
                Where(p => p.NumeroConta.ToString() == conteudo.ToString())
                .FirstOrDefault();

            try
            {
                dgvPedais.Rows.RemoveAt(dgvPedais.CurrentCell.RowIndex);
                c.Remover(contaAtual);
                MessageBox.Show("Pedal removido com sucesso!");
            } catch (Exception)
            {
                MessageBox.Show("Selecione uma conta para ser removida.");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (chbPremium.Checked)
            {
                if (int.Parse(txbSaldo.Text) < 100)
                {
                    MessageBox.Show("Para ser premium, credite pelo menos R$100");
                } else
                { 
                    Ciclista c = new Ciclista();
                    PedalPremium pp = new PedalPremium();
                    pp.Saldo = double.Parse(txbSaldo.Text.ToString());
                    pp.NumeroConta = int.Parse(txbNumeroConta.Text.ToString());
                    c.Inserir(pp);
                    txbNumeroConta.Clear();
                    txbSaldo.Clear();
                    chbPremium.Checked = false;
                }
            }
            else
            {
                Ciclista c = new Ciclista();
                PedalPop pp = new PedalPop();
                pp.Saldo = double.Parse(txbSaldo.Text.ToString());
                pp.NumeroConta = int.Parse(txbNumeroConta.Text.ToString());
                c.Inserir(pp);
                txbNumeroConta.Clear();
                txbSaldo.Clear();
                chbPremium.Checked = false;
            }

            MessageBox.Show("Pedal criado com sucesso!");

            atualizarGrid();
            if (dgvPedais.CanSelect)
            {
                btnCreditar.Enabled = true;
                btnRemoverPedal.Enabled = true;
                btnTransferir.Enabled = true;
            }
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnCreditar_Click(object sender, EventArgs e)
        {
            gbCreditar.Visible = true;
            gbAdicionar.Visible = false;
            gbTransferir.Visible = false;
            gbCreditar.Left = 12;
            gbCreditar.Top = 12;
            var indexRow = dgvPedais.CurrentCell.RowIndex;
            var conteudo = dgvPedais.Rows[indexRow].Cells[0].Value;
            txbNumeroContaCreditar.Text = conteudo.ToString();
        }

        public void atualizarGrid()
        {
            dgvPedais.Rows.Clear();
            foreach (var pedal in Ciclista.Pedais)
            {
                string isPremium = pedal.GetType().ToString().Equals("UrbanBike.classes.PedalPremium") ? "Sim" : "Não";

                dgvPedais.Rows.Add(pedal.NumeroConta, pedal.Saldo, isPremium);
            }
            dgvPedais.Refresh();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void dgvPedais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            gbCreditar.Visible = false;
            gbAdicionar.Visible = false;
            gbTransferir.Visible = true;
            gbTransferir.Left = 12;
            gbTransferir.Top = 12;
            cbbNumeroConta.Items.Clear();
            int indexRow = dgvPedais.CurrentCell.RowIndex;
            var conteudo = dgvPedais.Rows[indexRow].Cells[0].Value;
            var contaAtual = Ciclista.Pedais.
                Where(p => p.NumeroConta.ToString() == conteudo.ToString())
                .FirstOrDefault();

            foreach(var pedal in Ciclista.Pedais)
            {
                if (pedal != contaAtual)
                    cbbNumeroConta.Items.Add(pedal.NumeroConta);
            }
        }

        private void cbbNumeroConta_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            gbCreditar.Visible = false;
            gbAdicionar.Visible = true;
            gbTransferir.Visible = false;
        }

        private void btnTransferirPedal_Click(object sender, EventArgs e)
        {
            Ciclista c = new Ciclista();
            int indexRow = dgvPedais.CurrentCell.RowIndex;
            int transferindo = indexRow;
            var numeroConta = dgvPedais.Rows[indexRow].Cells[0].Value;
            var contaAtual = Ciclista.Pedais.
                Where(p => p.NumeroConta.ToString() == numeroConta.ToString())
                .FirstOrDefault();

            var conteudo = cbbNumeroConta.Text;
            var contaTransferencia = Ciclista.Pedais.
                Where(p => p.NumeroConta.ToString() == conteudo.ToString())
                .FirstOrDefault();
            contaAtual.Transferir(int.Parse(txbValorTransferencia.Text), contaTransferencia);
            atualizarGrid();
            cbbNumeroConta.Text = "";
            txbValorTransferencia.Clear();
        }

        private void btnCreditarPedal_Click(object sender, EventArgs e)
        {
            var contaAtual = Ciclista.Pedais
                .Where(p => p.NumeroConta.ToString() == txbNumeroContaCreditar.Text.ToString())
                .FirstOrDefault();

            contaAtual.Creditar(double.Parse(txbValorCreditar.Text));

            foreach(var conta in Ciclista.Pedais)
            {
                if (conta.NumeroConta.ToString() == txbNumeroContaCreditar.ToString())
                    conta.Creditar(double.Parse(txbValorCreditar.Text));
            }
            txbValorCreditar.Clear();
            atualizarGrid();
        }

        private void btnPedalar_Click(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Ciclista c = new Ciclista();
            int indexRow = dgvPedais.CurrentCell.RowIndex;
            var conteudo = dgvPedais.Rows[indexRow].Cells[0].Value;
            var contaAtual = Ciclista.Pedais.
                Where(p => p.NumeroConta.ToString() == conteudo.ToString())
                .FirstOrDefault();

            contaAtual.Pedalar(double.Parse(txbQuantidade.Text));
            atualizarGrid();
        }
    }
}
