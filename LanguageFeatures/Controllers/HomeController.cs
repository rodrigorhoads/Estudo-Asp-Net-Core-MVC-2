using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller {
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

        public ActionResult Index()
        {
            //declaração antiga do dictionary
            //Dictionary<string, Produto> produtos = new Dictionary<string, Produto>
            //{
            //    {"Kayak",new Produto{ Nome="Kayak",Preco=275M} },
            //    { "ColeteSalvaVidas",new Produto{ Nome="Colete Salva Vidas",Preco=48.49M} }
            //};

            //inicialização de indexes
            //Dictionary<string, Produto> produtos = new Dictionary<string, Produto>
            //{
            //    ["Kayak"]=new Produto { Nome="",Preco=275M},
            //    ["ColeteSalvaVidas"]=new Produto { Preco=48.49M,Nome="Colete salva vidas"}
            //};

            //return View("Index",produtos.Keys);

            //patern matching
            object[] data = new object[] { 275M,29.95M,
                "apple","orange",100,10};
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                //{
                //    if (data[i]is decimal d)
                //    {
                //        total += d;
                //    }
                //}

                //patern matching com switch Case
                switch (data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue;
                        break;

                }
            }
            return View("Index",new string[] { $"Total :{total:C2}"});
        }
    }
}
