using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabalhandoComVisualStudios.Models;

namespace TrabalhandoComVisualStudios.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository = Repositorio.RepositorioCompartilhado;

       public IActionResult Index()=> View(Repository.Produtos);

        [HttpGet]
        public IActionResult AddProdutos() => View(new Produto());

        [HttpPost]
        public IActionResult AddProdutos(Produto produto)
        {
            Repository.AddProdutos(produto);
            return RedirectToAction("Index");
        }
    }
}
