using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanBike.interfaces;

namespace UrbanBike.classes
{
    public class PedalPop : UrbanBike
    {
        public static double TaxaDeOperacao = 3;

        public override void Creditar(double valor)
        {
            Saldo += valor;
            Saldo -= TaxaDeOperacao;
        }

        public string MostrarDados()
        {
            return $"Saldo: {Saldo}, Taxa de Operação: {TaxaDeOperacao}";
        }

        public override void Pedalar(double valor)
        {
            if (Saldo - (valor + TaxaDeOperacao) >= 0)
            {
                Saldo -= valor;
                Saldo -= TaxaDeOperacao;
            }
            else
                MessageBox.Show("Você não tem saldo suficiente. Realize uma recarga para continuar.");
        }

        public override void Transferir(double valor, UrbanBike conta)
        {
            Pedalar(valor);
            conta.Saldo += valor;
        }
    }
}
