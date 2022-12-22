using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SallesWebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }
        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendaDepartamento(DateTime inicio, DateTime fim)
        {
            return Vendedores.Sum(p => p.TotaVendasPorPeriodo(inicio, fim));
        }
    }
}
