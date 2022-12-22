﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace SallesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();

        public Vendedor()
        {

        }
        public Vendedor(int id, string nome, string email, DateTime dataNascimento, 
                double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVenda(Vendas venda)
        {
            Vendas.Add(venda);
        }

        public void RemoverVenda(Vendas venda)
        {
            Vendas.Remove(venda);
        }

        public double TotaVendasPorPeriodo(DateTime inicio, DateTime fim)
        {
            return Vendas.Where(p => p.DataVenda >= inicio && p.DataVenda <= fim).Sum(p => p.Valor);
        }
    }
}
