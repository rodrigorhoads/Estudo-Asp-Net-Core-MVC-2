using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    List<string> resultados = new List<string>();

        //    foreach (Produto p in Produto.GetProdutos())
        //    {
        //        string nome = p?.Nome ?? "<Sem nome>";
        //        decimal? preco = p?.Preco ?? 0;
        //        string related = p?.Related?.Nome??"<Vazio>";
        //        //resultados.Add(string.Format("Nome : {0}, Preço : {1}, Relacionado :{2}"
        //        //    ,nome,preco,related));

        //        //isso aqui e interpolação de strings 
        //        resultados.Add($"Nome:{nome}, Preço?{preco}, Relacionado:{related}");
        //    }
        //    return View(resultados);
        //}



        public async Task<ViewResult> Index()
        {
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length : {length}"});
        }
    }
}
