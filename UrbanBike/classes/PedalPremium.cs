using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanBike.interfaces;

namespace UrbanBike.classes
{
    public class PedalPremium : UrbanBike
    {
        public static double Limite = 100;

        public override void Creditar(double valor)
        {
            Saldo += valor;
        }

        public string MostrarDados()
        {
            return $"Saldo: {Saldo}, Limite: {Limite}";
        }

        public override void Pedalar(double valor)
        {
            if ((Saldo + Limite) - valor >= 0)
            {
                Saldo -= valor;
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
