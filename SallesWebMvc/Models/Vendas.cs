using SallesWebMvc.Models.Enums;
using System;

namespace SallesWebMvc.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public DateTime DataVenda{ get; set; }
        public double Valor { get; set; }
        public StatusVenda Situacao { get; set; }
        public Vendedor Vendedor { get; set; }

        public Vendas()
        {

        }
        public Vendas(int id, DateTime dataVenda, double valor, StatusVenda situacao, Vendedor vendedor)
        {
            Id = id;
            DataVenda = dataVenda;
            Valor = valor;
            Situacao = situacao;
            Vendedor = vendedor;
        }
    }

}
