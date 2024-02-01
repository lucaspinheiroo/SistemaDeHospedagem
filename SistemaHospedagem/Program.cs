﻿using System;
using SistemaHospedagem.Models;

namespace SistemaHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hóspede 1");
            Pessoa p2 = new Pessoa(nome: "Hóspede 2");

            hospedes.Add(p1);
            hospedes.Add(p2);

            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 30);

            Reserva reserva = new Reserva(diasReservados: 11);

            reserva.CadastrarSuite(suite);
            reserva.CadastroHospedes(hospedes);

            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
        }
    }
}