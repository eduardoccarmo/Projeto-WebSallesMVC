using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;
using System.Collections.Generic;

namespace SallesWebMvc.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> departamentos = new List<Departamento>();

            departamentos.Add(new Departamento { Id = 1, Nome = "Eletrônicos" });
            departamentos.Add(new Departamento { Id = 2, Nome = "Vendas" });

            return View(departamentos);
        }
    }
}
