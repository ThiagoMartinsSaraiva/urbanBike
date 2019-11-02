using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanBike.interfaces;

namespace UrbanBike.classes
{
    public class Ciclista : Imprimivel
    {
        public static List<UrbanBike> Pedais = new List<UrbanBike>();
        
        public void Inserir(UrbanBike conta)
        {
            Pedais.Add(conta);
        }

        public void Remover(UrbanBike conta)
        {
            Pedais.Remove(conta);
        }

        public UrbanBike Procurar(int numeroConta)
        {
            return Pedais.FirstOrDefault(conta => conta.NumeroConta == numeroConta);
        }

        public string MostrarDados()
        {
            return $"Dados da conta: {Pedais.Count()}";
        }
    }
}
