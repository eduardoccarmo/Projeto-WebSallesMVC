using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SallesWebMvc.Models;

namespace SallesWebMvc.Models
{
    public class SallesWebMvcContext : DbContext
    {
        public SallesWebMvcContext(DbContextOptions<SallesWebMvcContext> options)
            : base(options)
        {
        }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Vendas> Vendas { get; set; }
    }
}