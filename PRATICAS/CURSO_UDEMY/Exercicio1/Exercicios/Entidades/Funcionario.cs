using Exercicios.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Exercicios.Entidades
{
    class Funcionario
    {
        public string Nome { get; set; }
        public NivelFuncionario Nivel { get; set; }
        public Double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<Contrato> Contratos { get; set; } = new List<Contrato>();

        public Funcionario()
        {

        }

        public Funcionario(string nome, NivelFuncionario nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void InserirContrato(Contrato contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoverContrato(Contrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public Double Ganho(int mes, int ano)
        {
            Double SomaSalario = SalarioBase;
            foreach (Contrato contratos in Contratos)
            {
                if (contratos.Data.Year == ano && contratos.Data.Month == mes)
                {
                    SomaSalario = SomaSalario + contratos.ValorTotal();
                }
            }
            return SomaSalario;
        }
    }
}
