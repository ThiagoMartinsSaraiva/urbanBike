using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanBike.classes
{
    public abstract class UrbanBike
    {
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }

        public abstract void Pedalar(double valor);
        public abstract void Creditar(double valor);
        public abstract void Transferir(double valor, UrbanBike conta);
    }
}
