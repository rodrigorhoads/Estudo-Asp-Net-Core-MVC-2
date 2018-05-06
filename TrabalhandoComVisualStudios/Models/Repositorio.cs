using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhandoComVisualStudios.Models
{
    public class Repositorio
    {
        private static Repositorio repositorioCompartilhado = new Repositorio();
        private Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();

        public static Repositorio RepositorioCompartilhado => repositorioCompartilhado;

        public Repositorio()
        {
            var itemsIniciais = new[]
            {
                new Produto { Nome = "Kayak", Preco = 275M },
                new Produto { Nome = "Lifejacket", Preco = 48.95M },
                new Produto { Nome = "Soccer ball", Preco = 19.50M },
                new Produto { Nome = "Corner flag", Preco = 34.95M }
            };
            foreach (var p in itemsIniciais)
            {
                AddProdutos(p);
            }
            produtos.Add("Error",null);
        }

        public void AddProdutos(Produto p) => produtos.Add(p.Nome,p);
        public IEnumerable<Produto> Produtos => produtos.Values;
    }
}
