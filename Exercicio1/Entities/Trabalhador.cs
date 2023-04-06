using Exercicio1.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Exercicio1.Entities
{
    internal class Trabalhador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public NivelTrabalhador NivelTrabalhador { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }

        public List<HorasContrato> Contratos { get; set; } = new List<HorasContrato>();// Não pode começar vazia

        //Construtores
        public Trabalhador()
        {

        }

        public Trabalhador(string nome, NivelTrabalhador nivelTrabalhador, double baseSalario, Departamento departamento)
        {
            Nome = nome;
            NivelTrabalhador = nivelTrabalhador;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }


        //Metodos
        public void AdicionarContrato(HorasContrato contrato)
        {
            Contratos.Add(contrato);

        }
        public void RemoverContrato(HorasContrato contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Ganho(int ano, int mes)
        {
            double result = BaseSalario;
            foreach (HorasContrato contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    result += contrato.ValorTotalReceber();
                }

            }
            return result;
        }


        //Retorno de Mensagem Personalizada da Classe
        //public override string ToString()
        //{
        //    return " Nome: " + Nome
        //        + "Departamento: " + Departamento
        //        + " O ganho para o ano de {} " + BaseSalario;
        //}


    }
}
