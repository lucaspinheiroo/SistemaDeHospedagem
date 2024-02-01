using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagem.Models
{
    internal class Reserva
    {

        public List<Pessoa> Hospedes { get; set; }

        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastroHospedes(List<Pessoa> hospedes)
        {

            if (Suite.Capacidade <= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("A capacidade da suíte é menor que a quantidade de hóspedes.");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;


            if (DiasReservados >= 10)
            {
                decimal desconto = 0.10m;
                valor = DiasReservados * Suite.ValorDiaria - (DiasReservados * Suite.ValorDiaria * desconto);
            } else
            {
                valor = DiasReservados * Suite.ValorDiaria;
            }
            return valor;
        }
    }
}
