using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Produto meuProduto = new Produto
            {
                ProdutoId = 1,
                Nome="kayak",
                Descricao="Um bote para uma unica pessoa",
                Categoria="esportes",
                Preco=275M
            };
            return View("meuProduto",meuProduto);
        }
    }
}